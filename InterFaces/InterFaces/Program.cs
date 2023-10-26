
//Interfaces concepts


using InterFaces;

class Program
{
    private static void Main(string[] args)
    {

        //InterFacesIntro();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleCustomerDal());

        Console.ReadKey();

    }
    private static void InterFacesIntro()
    {

        Customer customer = new Customer //customer nesnesi oluşturma
        {

            Id = 1,
            FirtName = "Kadir",
            LastName = "Özdemir",

            Address = "İstanbul"
        };

        Student student = new Student //student nesnesi oluşturma
        {

            Id = 2,
            FirtName = "Atilla",
            LastName = "Akın",

            Departmant = "Anaokulu"
        };

        Worker worker = new Worker //worker nesnesi oluşturma
        {

            Id = 3,
            FirtName = "Nebahat",
            LastName = "Akın",

            Salary = 30000
        };



        PersonManager manager = new PersonManager(); //manager nesnesi oluşturma

        manager.Add(customer); //manager içindeki metodu interface desteği ile kullandık
        manager.Add(student);
        manager.Add(worker);

    }
}

interface IPerson  //interface oluşturmak
{
    int Id { get; set; } //classlara bu değerleri kullanmaya zorlayacağız. (ortak özellik)
    string FirtName { get; set; }
    string LastName { get; set; }
}

class Customer:IPerson //interface bağlı customer class'ı oluşturmak
{
    public int Id { get; set; } //Bu değerler interfaceden geldiği için kullanmak zorundayız.(ortak özellik)
    public string FirtName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; } //bu class'a özel değer


}

class Student: IPerson //interface bağlı student class'ı oluşturmak
{
    public int Id { get; set; } //Bu değerler interfaceden geldiği için kullanmak zorundayız.(ortak özellik)
    public string FirtName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; } //bu class'a özel değer
}

class Worker : IPerson //interface bağlı worker class'ı oluşturmak
{
    public int Id { get; set; } //Bu değerler interfaceden geldiği için kullanmak zorundayız.(ortak özellik)
    public string FirtName { get; set; }
    public string LastName { get; set; }

    public int Salary { get; set; } //bu class'a özel değer
}

class PersonManager  //classların ortak kullanımı için metot oluşturulacak olan class
{
    public void Add(IPerson person) //metodumuz
    {
        Console.WriteLine(person.FirtName); // tüm nesnelerin FirstName değerini ekrana yazdırır.
    }
}