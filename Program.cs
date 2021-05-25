using System;

class Program {
static void Main()
{

    //phase 7
    int guessNumber = 0;
    bool difficultyCheck = true;
    while (difficultyCheck)
    {
    Console.WriteLine("please select difficulty level. Easy, Medium, Hard, or Cheater.");
    string difficulty = Console.ReadLine();

        if (difficulty.ToLower() == "easy")
        {
            guessNumber = 8;
            difficultyCheck = false;
        }
        else if (difficulty.ToLower() == "medium")
        {
            guessNumber = 6;
            difficultyCheck = false;
        }
        else if (difficulty.ToLower() == "hard")
        {
            guessNumber = 4;
            difficultyCheck = false;
        }
        else if (difficulty.ToLower() == "cheater")
        {
            guessNumber = 1000;
            difficultyCheck = false;
        }
        else
        {
            Console.WriteLine("please select a valid option.");
            difficultyCheck = false;
        }
    }
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

    Console.Write($"guess {userGuess} of {guessNumber} > ");


    for (int i = 1; i <= guessNumber; i++)
    {
    string input = Console.ReadLine();
    int parsedInput;
    try
    {
    parsedInput = int.Parse(input);
    }
    catch 
    {
        Console.WriteLine("invalid response");
        Console.WriteLine($"Nope! ({i} of {guessNumber})");
        i--;
        continue;
    };
    //phase 2
       if (theNumber == parsedInput) 
        {
            Console.Write("You're amazing! the number was ");
            Console.WriteLine(theNumber);
            break;
        }
        if (parsedInput != theNumber && i < guessNumber)
        {
            Console.WriteLine($"Nope! ({i+1} of {guessNumber})");
            if (parsedInput < theNumber)
            {
                Console.Write("guess higher > ");
            }
            else
            {
                Console.Write("guess lower > ");
            }
            
        }
        else if (i == guessNumber)
        {
            Console.Write("out of attempts! the number was ");
            Console.WriteLine(theNumber);

        }

    };
}
}