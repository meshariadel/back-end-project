using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Repository;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserOrderService, UserOrderService>();
builder.Services.AddScoped<IUserOrderRepository, UserOrderRepository>();

var app = builder.Build();


app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();