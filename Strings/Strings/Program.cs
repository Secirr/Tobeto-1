

string isim = "Kadir";
string soyisim = "Özdemir";

foreach (var item in isim)
{
    Console.WriteLine(item);
}

Console.WriteLine("{0} {1}", isim, soyisim);
Console.WriteLine(String.Format("{0} {1}",isim,soyisim));

Console.ReadKey();