
int sayi = 10;

/*
  
    int sayi2 = 20;

    if(sayi == 8)
    {
        Console.WriteLine("Sayı 10'dur");
    }
    else if(sayi == 15)
    {
        Console.WriteLine("Sayı 15'dir");
    }
    else
    {
        Console.WriteLine("Sayı 10 veya 20 değildir.");
    }

    Console.WriteLine(sayi2 == 15 ? "Sayı 20'dir" : "Sayı 20 değildir.");

*/

switch (sayi)
{
    case 10:
        Console.WriteLine("Sayı 10'dur");
        break;
    case 20:
        Console.WriteLine("Sayı 20'dir.");
        break;
    default:
        Console.WriteLine("sayı 10 ya da 20 değildir.");
        break;
}

Console.ReadKey();