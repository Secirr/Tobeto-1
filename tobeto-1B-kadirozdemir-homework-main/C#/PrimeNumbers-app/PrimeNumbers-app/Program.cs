//7 - Write a C# program find perfect numbers.

// Bir sayının mükemmel sayı olup olmadığını bulan programı giriniz.

//Bir sayının pozitif bölenleri toplamı, o sayıya eşitse bu sayı mükemmel bir sayıdır. 


Console.Write("Bir sayı giriniz: ");
long number = (long)Convert.ToDouble(Console.ReadLine());


PrimeNumbers(number);


Console.ReadKey();

static void PrimeNumbers(long number)
{

    long control = 0;

    for (long i = 1; i < number/2 ; i++)
    {
        if (number %i == 0)
        {
            control += i;
        }
    }
    if (control*2 == number)
    {
        Console.WriteLine("{0} bir mükemmel sayıdır",number);
    }
    else
    {
        Console.WriteLine("{0} bir mükemmel sayı değildir.", number);
    }


}