namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] people = new Person[3]
            {

                new Person
                {
                    Id = 1,
                    FirstName = "Kadir",
                    LastName = "Özdemir"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Atilla",
                    LastName = "Akın"
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Nebahat",
                    LastName = "Akın"
                }

            };

            foreach (var person in people)
            {
                Console.Write(person.Id + " ) ");
                Console.Write(person.FirstName + " ");
                Console.Write(person.LastName);
                Console.WriteLine();
          

            }


            Console.ReadKey();
        }

    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}

