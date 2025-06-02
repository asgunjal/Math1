// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number:");
string input1 = Console.ReadLine();
Console.WriteLine("Enter the second number:");
string input2 = Console.ReadLine();

if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
{
    double sum = number1 + number2;
    Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");
}
else
{
    Console.WriteLine("Invalid input. Please enter valid numbers.");
}
