using System;

Main();
void Main()
{
//phase 1

    Console.WriteLine("Guess the secret number");
    // Console.Write("your guess = ");
    // Console.WriteLine(input);


    //phase 3
    // int theNumber = 42;

    //phase 4
    int userGuess = 1;

    //phase5
    int theNumber = new Random().Next(0, 100);

    Console.Write($"guess {userGuess} of 4 > ");
    userGuess++;
    for (int i = 1; i < 5; i++)
    {
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);
    //phase 2
        if (parsedInput != theNumber && i < 4)
        {
            Console.Write($"Nope! guess {userGuess} of 4 > ");
            userGuess++;
        }
        else if (i == 4)
        {
            Console.Write("out of attempts! the number was ");
            Console.WriteLine(theNumber);

        }
        else 
        {
            Console.Write("You're amazing! the number was ");
            Console.WriteLine(theNumber);
            break;
        }
    };
};