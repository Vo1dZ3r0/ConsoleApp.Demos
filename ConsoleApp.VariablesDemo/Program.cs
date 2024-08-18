// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
    text - string
    integers -int
    decimal - double, float, decimal
    logical - bool
*/

string name = "Craig Donovan";
Console.WriteLine(name);
Console.WriteLine("I am " + name); //  string concatenation 
Console.WriteLine($"They call me {name}"); // string interpolation
Console.WriteLine("I was given the name {0}", name); // formatted string

int age = 60;
Console.WriteLine("\nMy age is: " + age);
int retirementYearsLeft = 5;
int retirementAge = age + retirementYearsLeft;
Console.WriteLine($"I will retire at age {retirementAge}");

bool isRetired = false;

Console.WriteLine("Am I retired? " + isRetired);

