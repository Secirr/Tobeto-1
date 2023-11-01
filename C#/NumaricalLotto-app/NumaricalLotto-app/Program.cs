



//columnCount = ex: 8 --> up to 8. More than 8 is not allowed
//1-49-->2,6,15,19,45,48 -->column -->all numbers are different
//get column count from the user. ex : 3
//play the game randomly-->use random class in c#
//output ex:
//2,6,15,18,45,48
//4,6,18,19,43,49 //1,6,15,25,45,48
//all columns must be the type of integer array

int deger;
Console.WriteLine("Bir değer giriniz: ");
deger = Convert.ToInt32(Console.ReadLine());
Random number = new Random();
int[] random = new int[6];

if (deger <= 8)
{
    for (int i = 0; i < deger; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            random[j] = number.Next(1, 49);

        }
        Array.Sort(random);

        for (int k = 0; k < 6; k++)
        {
            Console.Write(random[k] + " ");
        }

        Console.WriteLine("\n");
    }
}

else { Console.WriteLine("Hata!!!"); }



Console.ReadKey();


