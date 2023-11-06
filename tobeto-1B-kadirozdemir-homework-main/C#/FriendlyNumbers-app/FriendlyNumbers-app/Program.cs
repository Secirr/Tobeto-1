//6 - Write a C# program finds first two amicable pairs. (Output: 1-> 220-284 2: 1184-1210))

//İlk iki dost sayı çiftini bulan bir C# programı yazın. (Çıktı: 1-> 220-284, 2: 1184-1210)

//İki sayı, birbirinin bölenlerinin toplamıyla eşitse, bu iki sayı arkadaş sayılardır.

int count1 = 220, count2 = 284, count3 = 1184, count4 = 1210;

FriendlyNumber(count1, count2);
FriendlyNumber(count3, count4);

Console.ReadKey();

static void FriendlyNumber(int number1 ,int number2)
{

    
    int result1 = 0;
    int result2 = 0;



    for (int i = 1; i < number1; i++)
    {      
        if (number1 %i == 0)
        {
            result1 += i;
        }
       
    }
    for (int i = 1; i < number2; i++)
    {
        if (number2 %i == 0)
        {
            result2 += i;
        }
    }

    if (result1 == number2)
    {
        Console.WriteLine("{0} ve {1} sayıları arkadaş sayılardır", number1, number2);
    }
    else if(result2 == number1)
    {
        Console.WriteLine("{0} ve {1} sayıları arkadaş sayılardır", number1, number2);
    }
    else
    {
        Console.WriteLine("{0} ve {1} sayıları arkadaş sayı değildir.", number1, number2);
    }


}