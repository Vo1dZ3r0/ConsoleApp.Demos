// Declare variables
using System.Runtime.CompilerServices;

string? firstName = string.Empty;
string lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;

//Prompt the user for input
Console.WriteLine("Please enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your salary: "); // int 2 | decimal 2.5
salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Please enter your working status (true or false).");
working = Convert.ToBoolean(Console.ReadLine());


//Process the data
int workingYearsRemaining = retirementAge - age;

//Output the results to the user
Console.WriteLine($"\nFull name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Are you employed: {working}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");







