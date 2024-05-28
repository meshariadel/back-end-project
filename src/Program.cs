using System.Text;
using Microsoft.AspNetCore.Authentication.Jwt_Bearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Npgsql;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Middlewares;
var builder = WebApplication.CreateBuilder(args);
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program).Assembly); // Add Mapper in build
var _config = builder.Configuration;
var dataSourceBuilder = new NpgsqlDataSourceBuilder(@$"Host={_config["Db_:Host"]};Username={_config["Db_:Username"]};Database={_config["Db_:Database"]};Password={_config["Db_:Password"]}");
dataSourceBuilder.MapEnum<Role>();
dataSourceBuilder.MapEnum<ProductSize>();
var dataSource = dataSourceBuilder.Build();
builder.Services.AddDb_Context<DatabaseContext>((options) =>
{
    options.UseNpgsql(dataSource).UseSnakeCaseNamingConvention();
});
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Adding injections in Container
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductService, productService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<CustomErrorMiddleware>();

var MyAllowSpecificOrigins = "_MyAllowSpecificOrigins";
builder.Services.AddCors(Options =>
{
    Options.AddPolicy(name: MyAllowSpecificOrigins,
    policy =>
    {
        policy.WithOrigins(builder.Configuration["Cors:Origin"]!)
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials(); ;
    });
});

builder.Services.AddAuthentication(Jwt_BearerDefaults.AuthenticationScheme)
    .AddJwt_Bearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt_:Issuer"],
            ValidAudience = builder.Configuration["Jwt_:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt_:SigningKey"]!))
        };
    });
var app = builder.Build();
// Error Handling Middleware:
app.UseMiddleware<CustomErrorMiddleware>();
app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowSpecificOrigins);
// Middlewares:
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.Run();
