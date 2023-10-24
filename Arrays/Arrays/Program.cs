
// Array | concept one

// String[] customers = new string[4];
// customers[0] = "Mina";
// customers[1] = "Atilla";
// customers[2] = "Sevim";
// customers[3] = "Nebahat";




// Array | Concept two

// String[] customers = { "Mina", "Atilla", "Sevim", "Nebahat"};




// Array | Concept three

//String[] customers = new String[4]{"Mina","Atilla","Sevim","Nebahat"};



//foreach (String customer in customers)
//{
//    Console.WriteLine(customer);
//}

//Console.ReadKey();

// Multidimensional Arrays

String[,] multidimensional = new string[3, 2]
{
    {"Iphone 13","Iphone 13 pro"},
    {"Samsung s23","Samsung 23 Ultra"},
    {"Xiaomi mi 13 lite","Xiaomi mi 13 pro"}
};

for (int i = 0; i <= multidimensional.GetUpperBound(0); i++)
{
    for (int j = 0; j <= multidimensional.GetUpperBound(1); j++)
    {
        Console.WriteLine(multidimensional[i,j]);
    }
    Console.WriteLine("************");
}

Console.ReadKey();