
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




    string employeeName = "kadir";
    string employeeSurName = "özdemir";
    float employeeSalary = calculatingSalary(25000,20);

    Console.WriteLine(
        "Çalışan adı : {0} \n " +
        "Çalışan Soyadı : {1} \n " +
        "Çalışan maaşı : {2}"
        ,employeeName,employeeSurName,employeeSalary);

 

    static float calculatingSalary(float salary , float tax = 18)
    {
         tax = (salary * tax) / 100;
         salary = salary - tax;
         return salary;
    }





Console.ReadKey();