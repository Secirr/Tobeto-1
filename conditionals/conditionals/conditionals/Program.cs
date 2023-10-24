
int sayi = 10;
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

Console.ReadKey();