var shop = new Shop();
var phone = new Phone();
phone.Name = "iPhone"; 
phone.Price = 999;
phone.ram = "128G"; 
var phone1 = new Phone(); 
phone1.Name = "Samsung";
phone1.Price = 899;
phone1.ram = "256G"; 
var car = new Car();
car.Name = "Mersedec-Benz"; 
car.Price = 100000;
car.Model = "GLS600";
var car1 = new Car(); 
car1.Name = "BMW";
car1.Price = 80000; 
car1.Model = "X6"; 
System.Console.WriteLine("----------------------");

shop.AddProduct(phone);
shop.AddProduct(phone1);
shop.AddProduct(car);
shop.AddProduct(car1);

shop.PrintProductList();

shop.RemoveProduct(phone1);
shop.RemoveProduct(car1);
System.Console.WriteLine("----------------------");

shop.PrintProductList();

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name},\nPrice: {Price}");
        System.Console.WriteLine("----------------------");
    }
}

public class Phone : Product
{
    public string ram { get; set; }
    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Ram: {ram}");
        System.Console.WriteLine("----------------------");
    }
}

public class Car : Product
{
    public string Model { get; set; }
    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Model: {Model}");
        System.Console.WriteLine("----------------------");
    }
}

public class Shop
{
    private List<Product> products = new List<Product>();
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }
    public void PrintProductList()
    {
        foreach (var product in products)
        {
            product.PrintInfo();
        }
    }
}