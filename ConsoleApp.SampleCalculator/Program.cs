// Welcome message
Console.WriteLine("Welcome to the sample calculator!");

// Prompt for user input
Console.WriteLine("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator options
Console.WriteLine("Please select the operation you would like to perform");
Console.Write("(+) - Addition\n");
Console.Write("(-) - Subtraction\n");
Console.Write("(*) - Multiplication\n");
Console.Write("(/) - Division\n");
Console.Write("(%) - Modulus\n\n");
char operation = Convert.ToChar(Console.ReadLine());
Console.Write("\n");

Console.WriteLine($"You've chosen {operation}.");

// Decide which operation is needed based on selected option 
int result = 0;
switch (operation)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
    case '%':
        result = num1 % num2;
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}
//print output

Console.WriteLine($"The result is {result}.");
