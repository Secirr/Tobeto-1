
//Checker Board App for Macos

static void CheckerBoardButton()
{
    string[,] buttons = new string[9, 9];

    for (int i = 1; i <= buttons.GetUpperBound(0); i++)
    {
        for (int j = 1; j <= buttons.GetUpperBound(1); j++)
        {
            buttons[i, j] = j.ToString();

            if ((i + j) % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.Write(" {0} ", buttons[i, j]);
        }
        Console.WriteLine();
    }
    Console.ReadKey();
}

CheckerBoardButton();