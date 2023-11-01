
static void Intro()
{

    string isim = "Kadir";
    string soyisim = "Özdemir";

    foreach (var item in isim)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("{0} {1}", isim, soyisim);
    Console.WriteLine(String.Format("{0} {1}", isim, soyisim));

    Console.ReadKey();
}

//Intro();

string sentence = "My name is Kadir Özdemir";
var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Atilla Akın";

bool result3 = sentence.EndsWith("ö");
bool result4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("namee");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf("");
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3, 4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2, 4);

Console.WriteLine(result13);
Console.ReadLine();