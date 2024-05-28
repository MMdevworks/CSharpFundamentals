// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("What's your name?");

// ? null conditional operator. Allows null value
// ReadLine awaits user input
string? str = Console.ReadLine();

Console.WriteLine("Welcome to the world " + str + "!");
