
Except();

int result = addition(15, 30);

Console.WriteLine("Result : {0}", result);

static void Except()
{
    Console.WriteLine("this is except for methots");
}


static int addition(int number1, int number2){
    int result = number1 + number2;
    return result;
}

Console.ReadKey();