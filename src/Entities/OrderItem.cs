namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;


public class OrderItems{

public OrderItems(int Quantity, int Total_pirce)
{
quantity = Quantity;

total_pirce = Total_pirce;

}

public string order_item_id {get;} = Guid.NewGuid().ToString();
public string order_id {get; set; } = Guid.NewGuid().ToString();

public string product_id {get; set;} = Guid.NewGuid().ToString();

public int quantity {get; set;}

public int total_pirce {get; set;}

}