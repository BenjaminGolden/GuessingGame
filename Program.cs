using System;

//phase 1
Console.WriteLine("Guess the secret number");
Console.Write("enter your guess > ");
string input = Console.ReadLine();
int parsedInput = int.Parse(input);
// Console.Write("your guess = ");
// Console.WriteLine(input);

//phase 2
int theNumber = 42;
if (parsedInput == theNumber)
{
    Console.WriteLine("You're amazing!");
}
else
{
    Console.WriteLine("please guess again");
}