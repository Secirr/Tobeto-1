

//  Write a C# function to print first 100 numbers in Fibonacci series?
//  Fibonacci serisinde ilk 100 sayıyı yazdırmak için bir C # işlevi yazın?



// ALGORİTMA
// 1. Adım: a (0) ,b (1), c ve counter (1) değişkenleri tanımla.
// 2. Adım: do while döngüsü oluştur ve şartı counter <= 100 yap (döngü 100 kere döner)
// 3. Adım: a ve b yi ekrana yazdır.
// 4. Adım: c(1) = a(0) + b(1) (a ve b yi c y eşitle c 1 olsun)
// 5. Adım: a(0) = b(1) ( a yı b ye eşitle yani a 1 oldu döngü dökdükçe a nın değeri b kadar artar)
// 6. Adım: c(1) = b(1) ( c yi b ye eşitle döngü döndükçe b nin değeri c kadar artar.
// 7. Adım: c yi ekrana yazdır.

Fibonacci();

static void Fibonacci()
{


    double a = 0, b = 1, c, counter = 1;

    do
    {
        Console.Write(a + " " + b);

        c = a + b;
        a = b;
        b = c;


        Console.WriteLine(" --> " + c);

        counter++;


    } while (counter < 100);

    Console.ReadKey();


}