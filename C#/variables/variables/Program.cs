using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args)
    {

        string metin = "metin";
        int number1 = 10;
        long number2 = 135135315315;
        short number3 = 1413;
        byte number4 = 12;
        bool control = true;
        char character = 'K';
        double number5 = 20.6;
        decimal number6 = 40;
        var number7 = 35;
        Months birthMounth = Months.May;


        Console.WriteLine("Metin : {0}", metin);
        Console.WriteLine("Numara 1 : {0}", number1);
        Console.WriteLine("Numara 2 : {0}", number2);
        Console.WriteLine("Numara 3 : {0}", number3);
        Console.WriteLine("Numara 4 : {0}", number4);
        Console.WriteLine("Numara 5 : {0}", number5);
        Console.WriteLine("Numara 6 : {0}", number6);
        Console.WriteLine("Numara 7 : {0}", number7);
        Console.WriteLine("Kontrol : {0}", control);
        Console.WriteLine("karakter : {0}", character);
        Console.WriteLine("Doğduğum ay : {0}",birthMounth);

        Console.ReadKey();
    }
    enum Months
    {
        January, February, March, April, May, June, July,
        August, September, October, November, December
    }

}


