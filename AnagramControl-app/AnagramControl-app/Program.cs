//4 - How to check if two Strings are anagrams of each other?

//İki stringin birbirinin anagramı olup olmadığını kontrol etmek için bir C# fonksiyonu yazın.

Console.Write("Lütfen birinci değeri giriniz: ");
string text1 = Console.ReadLine();

Console.Write("Lütfen ikinci değeri giriniz: ");
string text2 = Console.ReadLine();

bool areAnagrams = AnagramControl(text1, text2);

if (areAnagrams)
    Console.WriteLine("{0} ve {1} birbirinin anagramıdır.", text1, text2);
else
    Console.WriteLine("{0} ve {1} birbirinin anagramı değildir.", text1, text2);


Console.ReadKey();


static bool AnagramControl(string text1, string text2)
{
    // Uzunluklarının aynı olup olmadığının kontrolü
    if (text1.Length != text2.Length)
        return false;

    // Her iki stringi karakter dizilerine dönüştür
    char[] text1Array = text1.ToCharArray();
    char[] text2Array = text2.ToCharArray();
    

    // Karakter dizilerini sırala
    Array.Sort(text1Array);
    Console.WriteLine(text1Array);
    Array.Sort(text2Array);
    Console.WriteLine(text2Array);

    // Sıralanmış karakter dizilerini karşılaştır
    for (int i = 0; i < text1Array.Length; i++)
    {
        if (text1Array[i] != text2Array[i])
            return false;
    }

    return true;
}




