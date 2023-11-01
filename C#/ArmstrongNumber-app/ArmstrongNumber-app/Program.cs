//1 - Write a C# program to check if the entered number is Armstrong number? 

//TR: Girilen sayının Armstrong sayısı olup olmadığını kontrol eden bir C# programı yazın.

//Armstrong sayıları, bir sayının rakamlarının belirli bir kuvvetinin toplamının
//kendisine eşit olduğu sayılardır.

//Örneğin, 153 bir Armstrong sayısıdır çünkü:

// 1^3 + 5^3 + 3^3 = 153 //Her rakamın kendisinin üçüncü kuvveti alındığında,
// bu üç rakamın toplamı 153'e eşittir.

//1.Adım: Kullanıcından bir sayı al ve convert et.+

//2. Adım: Sayı 2 den büyük ise kod bloğuna gir.+

//3.Adım: girilen sayıyı string'e çevirerek basamak sayısını bul(a). +

//4. Adım: girilen sayının her bir rakamının a sayısı kadar üssünü al ve hepsinin sonucunu topla

//5. Adım: sonucun girilen sayıyla eşit olup olmadığını kontol et

//6. Adım: Eşit ise sonucu true yap ve girilen sayı ile sonucu ekrana yazdır.

//7. Adım: Değilse False yap ve armstrong sayı değildir yazdır.



using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //int number = int.Parse(EnterNumber);
        //int originalNumber = number;
        //int numberOfDigits = EnterNumber.Length;
        //int total = 0;

        Console.Write("Bir sayı giriniz : ");
        string EnterNumber = Console.ReadLine();

        int numbers = int.Parse(EnterNumber);
        int step = EnterNumber.Length;


        int total = 0;

        foreach (char number in EnterNumber)
        {
            int element = Convert.ToInt32(Char.GetNumericValue(number));

            total += Convert.ToInt32(Math.Pow(element, step));
            
        }

        if (total == numbers)
        {
            Console.WriteLine(EnterNumber + " --> armstrong sayısıdır.");
        }
        else
        {
            Console.WriteLine(EnterNumber + " --> armstrong sayısı değildir.");
        }

        Console.ReadLine();




    }

}






































//Console.Write("Bir sayı giriniz : ");
//string EnteredNumber = Console.ReadLine();

//if (int.TryParse(EnteredNumber, out int number) && number > 0)
//{


//    if (IsArmstrongNumber(number))
//    {
//        Console.WriteLine($"{number} bir Armstrong sayıdır");
//    }
//    else
//    {
//        Console.WriteLine($"{number} bir Armstrong sayısı değildir");
//    }
//}
//else
//{
//    Console.WriteLine("Geçerli bir sayı girin");

//}


//Console.ReadLine();

//static bool IsArmstrongNumber(int number)
//{
//    string StringNumber = number.ToString();
//    int DigitNumber = StringNumber.Length;

//    int total = 0;

//    foreach (char digit in StringNumber)
//    {
//        int element = (int)Char.GetNumericValue(digit);

//        total += (int)Math.Pow(element, DigitNumber);
//    }


//    return total == number;

//}