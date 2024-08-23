// Simple For Loop Demo
//Print Hello World 10 times 

// Ask the User how many times they wish to print hello world and print accordingly

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("How many times would you like to print Hello World");
int numberOfPrints = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("**************** Simple For Loop ***************************");
for (int i = 0; i < numberOfPrints; ++i)
{
    Console.WriteLine($"hello, world!!! - {i + 1}");
}
Console.WriteLine("**************** Simple For Loop Ended ***************************\n");


Console.WriteLine("*********************** While Loop ***************************");

int counter = 0; 
while(counter < numberOfPrints)
{
    Console.WriteLine($"Hello, World!!! - {counter + 1}");
    counter++;

}

// Ask the user for a number and find the total for each number that is entered. Print the final sum when the user
// enters -1 to exit.
int sum = 0;
int input = 0;
Console.WriteLine("\nPlease enter a number to be summed up. (press -1 to stop or exit)");
while(input != -1)
{
    input = Convert.ToInt32(Console.ReadLine());
    if(input != -1)
    {
        sum += input;
    }
    
    
}

Console.WriteLine($"Your sum is {sum}");

Console.WriteLine("********************* While Loop Ended ***************************\n");

Console.WriteLine("*********************** Do While Loop ***************************");
sum = 0;
input = 0;
do
{
    Console.WriteLine("\nPlease enter a number to be summed up. (press -1 to stop or exit)");
    input = Convert.ToInt32(Console.ReadLine());
    if (input != -1)
    {
        sum += input;
    }

} while (input != -1);

Console.WriteLine($"Your sum is {sum}");

Console.WriteLine("*********************** Do While Loop Ended ***************************");

