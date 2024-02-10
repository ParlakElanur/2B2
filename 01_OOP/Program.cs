
//Değer Tipliler stackte tutulur.

int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;
sayi2 = 100;

Console.WriteLine(sayi1);


//Referans tiplilerin datası heap bölgesinde tutulur

int[] sayilar1 = { 1, 2, 3 };
int[] sayilar2 = { 10, 20, 30 };

sayilar1 = sayilar2;

sayilar2[0] = 1000;

Console.WriteLine(sayilar1[0]);

CreditManager creditManager = new CreditManager(); //instance oluşturma
creditManager.Calculate(1);
creditManager.Save();

Console.WriteLine("-----");
Customer customer = new Customer();
customer.Id = 1;
customer.City = "İstanbul";

CustomerManager customerManager = new CustomerManager(customer, new TeacherCreditManager());
customerManager.Save();
customerManager.Delete();

Company company = new Company();
company.CompanyName = "Arçelik";
company.TaxNumber = "1000000";
company.Id = 100;

CustomerManager customerManager2 = new CustomerManager(new Person(), new MilitaryCredictManager());

Person person = new Person();
person.FirstName = "Engin";
person.LastName = "Demiroğ";

Customer c1 = new Customer();
Customer c2 = new Person();
Customer c3 = new Company();

Person p = (Person)c2;




Console.ReadKey();

class CreditManager
{
    public void Calculate(int credictType)
    {
        if (credictType == 1) //öğretmen kredisi
        {

        }
        if (credictType == 2) //asker kredisi
        {

        }

        Console.WriteLine("Hesaplandı");
    }
    public void Save()
    {
        Console.WriteLine("Kredi verildi");
    }
}
abstract class BaseCreditManager
{
    public abstract void Calculate();

    public virtual void Save()
    {
        Console.WriteLine("Kaydedildi");
    }
}
interface ICreditManager
{
    void Calculate();
    void Save();
}
class TeacherCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Öğretmen kredisi hesaplandı");
    }
    public void Save()
    {
        Console.WriteLine("Öğretmen kredisi verildi");
    }
}
class MilitaryCredictManager : ICreditManager
{
    public void Calculate()
    {
        Console.WriteLine("Asker kredisi hesaplandı");
    }

    public void Save()
    {
        Console.WriteLine("Asker kredisi verildi");
    }
}

class Customer
{
    public Customer()
    {
        Console.WriteLine("Müşteri nesnesi başlatıldı");
    }
    public int Id { get; set; }
    public string City { get; set; }

}
class Person : Customer
{
    public string NationalIdentity { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Company : Customer
{
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
}

class CustomerManager
{
    private Customer _customer;
    private ICreditManager _creditManager;

    public CustomerManager(Customer customer, ICreditManager creditManager)
    {
        _customer = customer;
        _creditManager = creditManager;
    }
    public void Save()
    {
        Console.WriteLine($"Müşteri Kaydoldu : {_customer.Id}");
    }
    public void Delete()
    {
        Console.WriteLine($"Müşteri Silindi : {_customer.Id}");
    }
    public void GiveCredit()
    {
        Console.WriteLine("Kredi verilecek");
        _creditManager.Save();

    }
}


