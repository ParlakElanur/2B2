using System.Diagnostics;

IProductService productService = new ProductManager(new FakeBankService(), new StudentCustomerManager());
productService.Sell(new Product() { Id = 1, Name = "Laptop", Price = 1000 }, new Customer() { Id = 1, Name = "Engin Demiroğ" });
productService.Sell(new Product() { Id = 1, Name = "Laptop", Price = 1000 }, new StudentCustomer() { Id = 1, Name = "Ahmet" });

Console.ReadKey();

class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public bool IsStudent { get; set; }
    //public bool IsOfficer { get; set; }
}
class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

internal interface IEntity
{
}
class StudentCustomer : Customer, IEntity
{

}
class OfficerCustomer : Customer, IEntity
{

}
class CustomerManager : ICustomerManager
{
    public decimal GetPrice(Product product)
    {
        Console.WriteLine($"Sabit ürün fiyatı :");
        return product.Price;
    }
}

internal interface ICustomerManager
{
    decimal GetPrice(Product product);
}
class StudentCustomerManager : ICustomerManager
{
    public decimal GetPrice(Product product)
    {
        Console.WriteLine("Öğrenci indirimli fiyat :");
        decimal price = product.Price * (decimal)(0.10);

        return price;
    }
}
class OfficerCustomerManager : ICustomerManager
{
    public decimal GetPrice(Product product)
    {
        Console.WriteLine("Memur indirimli fiyat :");
        decimal price = product.Price * (decimal)(0.20);

        return price;
    }
}

class ProductManager : IProductService
{
    private IBankService _bankService;
    private ICustomerManager _customerManager;
    public ProductManager(IBankService bankService, ICustomerManager customerManager)
    {
        _bankService = bankService;
        _customerManager = customerManager;

    }
    public void Sell(Product product, Customer customer)
    {
        decimal price = product.Price;
        //if (customer.IsStudent)
        //{
        //    price *= (decimal)0.90;
        //}
        //if (customer.IsOfficer)
        //{
        //    price *= (decimal)0.80;
        //}

        //Müşteri bilgilerine göre hesaplama yapması gerek
        _customerManager.GetPrice(product);
        Console.WriteLine("Satış yapıldı");
    }
}

internal interface IProductService
{
    void Sell(Product product, Customer customer);
}

class FakeBankService : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / (decimal)5.30;
    }
}

internal interface IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate);
}

class CurrencyRate
{
    public decimal Price { get; set; }
    public int Currency { get; set; }

}