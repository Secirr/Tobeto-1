
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

//switch (sayi)
//{
//    case 10:
//        Console.WriteLine("Sayı 10'dur");
//        break;
//    case 20:
//        Console.WriteLine("Sayı 20'dir.");
//        break;
//    default:
//        Console.WriteLine("sayı 10 ya da 20 değildir.");
//        break;
//}


//if (sayi > 0 && sayi <= 100)
//{
//    Console.WriteLine("sayi 1 ve 100 arasındadır.");
//}
//else if(sayi >= 101 && sayi <= 200)
//{
//    Console.WriteLine("sayı 100 ve 200 arasındadır.");
//}
//else if(sayi < 0 || sayi > 200)
//{
//     Console.WriteLine("sayi 0 dan küçük ya da 200 den büyük");
//}

if(sayi < 100)
{
    if(sayi > 5)
    {
        Console.WriteLine("{0} Sayısı 100 den küçük ve 5 ten büyüktür.", sayi);
    }
}


Console.ReadKey();