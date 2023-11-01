//5 - How to determine if the string has all unique characters. 

//Bir stringin tüm karakterlerinin benzersiz (unique) olup olmadığını kontrol etmek için bir C# programı yazın.

Console.Write("Bir metin giriniz: ");
string text = Console.ReadLine().ToLower();


letterControl(text);

Console.ReadKey();

static void letterControl(string text)
{

    for (int i = 0; i < text.Length; i++)
    {

        char x = text[i];
        int count = 1;
        for (int j = i + 1; j < text.Length; j++)
        {
            if (x == text[j])
            {
                count++;

            }

        }

        if (count != 1)
        {
            Console.WriteLine("{0} metninin karakterleri unique değildir.", text);
            break;
        }
        else
        {
            Console.WriteLine("{0} metninin karakterleri unique.", text);
            break;
        }
        
    }
}
