
//Except();

//int result = addition(15, 30);

//Console.WriteLine("Result : {0}", result);

//static void Except()
//{
//    Console.WriteLine("this is except for methots");
//}


//static int addition(int number1, int number2){
//    int result = number1 + number2;
//    return result;
//}




//string employeeName = "kadir";
//string employeeSurName = "özdemir";
//float employeeSalary = calculatingSalary(25000,20);

//Console.WriteLine(
//    "Çalışan adı : {0} \n " +
//    "Çalışan Soyadı : {1} \n " +
//    "Çalışan maaşı : {2}"
//    ,employeeName,employeeSurName,employeeSalary);



//static float calculatingSalary(float salary , float tax = 18)
//{
//     tax = (salary * tax) / 100;
//     salary = salary - tax;
//     return salary;
//}


//int number1;
//int number2 = 100;
//var result = Add(out number1, number2);

//Console.WriteLine(result);
//Console.WriteLine(number1);


//Console.ReadKey();

//static int Add(out int number1, int number2)
//{
//    number1 = 30;
//    return number1 + number2;
//}



// Overloading

//class Overloading
//{
//    static void Main()
//    {
//        Console.WriteLine(overLoad(2, 9));
//        Console.WriteLine(overLoad(2, 9, 2));

//        Console.ReadKey();
//    }

//    static int overLoad(int number1, int number2)
//    {
//        return number1 * number2;
//    }
//    static int overLoad(int number1, int number2, int number3)
//    {
//        return number1 * number2 * number3;
//    }
//}


//Params Keyword

Console.Write(Params(5,2,4,5,6));
Console.ReadKey();

static int Params(int number1, params int[] numbers)
{
    return number1 + numbers.Sum();
}



