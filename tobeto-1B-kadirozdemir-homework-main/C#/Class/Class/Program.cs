

using Class;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Kadir", LastName = "Özdemir"
            };
            Console.WriteLine(customer.FirstName);

            Console.ReadLine();

        }

    }
}
