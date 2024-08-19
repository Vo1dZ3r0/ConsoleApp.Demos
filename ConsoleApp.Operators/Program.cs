Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
    Math Operations and Operators  
*/
// Add the numbers
int sum = num1 + num2;
// Multiply 
int product = num1 * num2;
// Division 
int quotient = num1 / num2;
// Subtraction
int difference = num1 - num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine("******************** Math Results ********************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("******************** End Math Results ********************");
Console.WriteLine();

/*
    Logic Operations and Operators 
*/

bool isGreaterThan  = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("******************** Logic Results ********************");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("******************** End of Logic Results ********************");
Console.WriteLine();

/*
    Assignment Operations and Operators 
*/

Console.WriteLine("Enter random value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("******************** Assignment Results ********************");
Console.WriteLine();
num1 += randomValue;
Console.WriteLine($"Num 1 increased by {randomValue}: {num1}");
num1 -= randomValue;
Console.WriteLine($"Num 1 decreased by {randomValue}: {num1}");
num1 /= randomValue;
Console.WriteLine($"Num 1 divided by {randomValue}: {num1}");
num1 %= randomValue;
Console.WriteLine($"Num 1 mod by {randomValue}: {num1}");
num1 *= randomValue;
Console.WriteLine($"Num 1 multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("******************** End of Assignment Results ********************");
