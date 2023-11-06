// text character calculation

// Write a C# program gives character counts in a string Ex: To be to --> t:2, o:2, b:1, e:1

// Verilen bir metin dizesindeki karakter sayılarını hesaplayarak sonuçları gösteren bir örnek


// Algoritma
// 1.Adım: Kullanıcıdan bir metin girişi iste ve bunu string türünde tut(text).
// 2.Adım: iç içe for döngü yapısı kur.
// 3.Adım: harflerin teker teker kontrolünü sağla 2 tane olan harfi bulunca sil

    Console.WriteLine("Bir metin giriniz : ");
    string text = Console.ReadLine().ToLower();



    letterControl(text);
    

    Console.ReadKey();

    static void letterControl(string text)
    {

        Console.WriteLine(text.Length);

        

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
            Console.WriteLine("{0}" + count, text[i]);

        }
    }




//Console.WriteLine("Metin Yazınız : ");
//string input = Console.ReadLine();
//input = input.ToLower();
//for (int i = 0; i < input.Length; i++)
//{
//    char x = input[i];
//    int count = 1;
//    for (int j = i + 1; j < input.Length; j++)
//    {
//        if (x == input[j])
//        {
//            count++;
//            input = input.Remove(j, 1);
//        }

//    }
//    Console.WriteLine("{0}" + count, input[i]);
//}
//Console.ReadLine();

