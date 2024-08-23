// Welcome message
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Welcome to the sample calculator!");


// Show calculator options
Console.WriteLine("\nPlease select the operation you would like to perform (q to exit)");
Console.Write("(+) - Addition\n");
Console.Write("(-) - Subtraction\n");
Console.Write("(*) - Multiplication\n");
Console.Write("(/) - Division\n");
Console.Write("(%) - Modulus\n");
Console.Write("(f) - Fibonacci Sequence\n\n");
char input = Convert.ToChar(Console.ReadLine());
Console.Write("\n");

while (input != 'q')
{
    

    Console.WriteLine($"You've chosen {input}.\n");
    // Prompt for user input
    Console.WriteLine("Please enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    // Decide which operation is needed based on selected option 
    int result = 0;
    switch (input)
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
        case 'f':
            for (int i = num1; i <= num2; i++)
            {
                result += i;
            }
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
    //print output
    Console.WriteLine($"The result is {result}.\n");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();
    Console.Clear();

    // Show calculator options
    Console.WriteLine("\nPlease select the operation you would like to perform (q to exit)");
    Console.Write("(+) - Addition\n");
    Console.Write("(-) - Subtraction\n");
    Console.Write("(*) - Multiplication\n");
    Console.Write("(/) - Division\n");
    Console.Write("(%) - Modulus\n");
    Console.Write("(f) - Fibonacci Sequence\n\n");
    input = Convert.ToChar(Console.ReadLine());
    Console.Write("\n");
    

    
} 

Console.WriteLine("Thank you for using the sample calculator!!!!");
