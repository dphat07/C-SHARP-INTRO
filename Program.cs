// See https://aka.ms/new-console-template for more information

//Part 1 Print a string to the console
//hint: Console.WriteLine("Hello World!");
Console.WriteLine("Hello World! ");

//Part 2 Get user input and print it to the console
//hint: Console.ReadLine();
Console.WriteLine("What is your Name: ");
var name = Console.ReadLine();

Console.WriteLine("How old are you: ");
int age = int.Parse(Console.ReadLine());
//Part 3 Get two inputs from the user and print them on separate lines
//hint: use \n to create a new line
Console.Write($"Your name {name}\nYour age: {age}");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
