using System;

Main();
void Main()
{
//phase 1

    Console.WriteLine("Guess the secret number");
    Console.Write("enter your guess > ");
    // Console.Write("your guess = ");
    // Console.WriteLine(input);


    //phase 3
    int theNumber = 42;
    //phase 4
    int userGuess = 1;

    for (int i = 0; i < 4; i++)
    {
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);
    //phase 2
        if (parsedInput != theNumber && i < 3)
        {
            Console.Write($"Nope! guess {userGuess} of 4 > ");
            userGuess++;
        }
        else if (i == 3)
        {
            Console.WriteLine("out of attempts");
        }
        else 
        {
            Console.Write("You're amazing!");
            break;
        }
    };
};