using System;


Console.WriteLine("Guess the secret number");
Console.Write("enter your guess > ");
string input = Console.ReadLine();
int parsedInput = int.Parse(input);
Console.Write("your guess = ");
Console.WriteLine(input);