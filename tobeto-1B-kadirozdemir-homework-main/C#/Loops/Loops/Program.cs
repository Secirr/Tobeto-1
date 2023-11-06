//for

static void ForLoops()
{

    //Numbers from 0 to 100
    //for (int i = 0; i <= 100; i++)
    //{
    //    Console.WriteLine(i);
    //}

    //Even numbers from 0 to 100
    //for (int i = 0; i <= 100; i += 2)
    //{
    //    Console.WriteLine(i);
    //}

    //Odd numbers from 1 to 99
    //for (int i = 1; i <= 100; i += 2)
    //{
    //    Console.WriteLine(i);
    //}

    //Numbers from 100 to 0
    //for (int i = 100; i >= 0; i--)
    //{
    //    Console.WriteLine(i);
    //}

    //Even numbers from 100 to 0
    //for (int i = 100; i >= 0; i -= 2)
    //{
    //    Console.WriteLine(i);
    //}

    //Odd numbers from 99 to 1
    for (int i = 99; i >= 1; i -= 2)
    {
        Console.WriteLine(i);
    }

    Console.ReadKey();

}

//While
static void WhileLoop()
{
    int number = 50;

    while (number >= 50)
    {
        Console.WriteLine(number);
        number--;
    }

    Console.WriteLine("Now number is {0}", number);
    Console.ReadKey();
}

//Do While
static void DoWhileLoop()
{
    int number = 10;

    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 0);
    Console.ReadKey();

}

//ForEach
static void ForEachLoop()
{

    string[] customers = { "Atilla", "Mina", "Nebahat" };

    foreach (var customer in customers)
    {
        Console.WriteLine(customer);
    }
    Console.ReadKey();
}


//ForLoops();
//WhileLoop();
//DoWhileLoop();
ForEachLoop();

