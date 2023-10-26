
//Interfaces concepts

interface IPerson
{
    int Id { get; set; }
    int FirtName { get; set; }
    int LastName { get; set; }
}

class Customer:IPerson
{
    public int Id { get; set; }
    public int FirtName { get; set; }
    public int LastName { get; set; }

    public string Address { get; set; }


}

class Student:IPerson
{
    public int Id { get; set; }
    public int FirtName { get; set; }
    public int LastName { get; set; }

    public string Departmant { get; set; }
}