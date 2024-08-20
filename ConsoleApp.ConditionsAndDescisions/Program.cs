// Prompt for input
Console.Write("Please enter student's grade: ");
// Global variable/ globe scope
int grade = Convert.ToInt32(Console.ReadLine());

//Simple If ...Else...statement - Decide to print or pass of fail based on input
Console.WriteLine("******************** Simple IF Results *******************");
if (grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to student affair's office");
}
Console.WriteLine("******************** Simple IF Results End *******************");

Console.WriteLine("******************** Complex IF.. Else IF Results *******************");



if ( grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered");
}
else if (grade < 70)
{
    Console.WriteLine("Student has failed - F");
    

}
else if ((grade <= 79) && (grade >= 70))
{
    Console.WriteLine("C");
   

}
else if (grade >= 80 && grade <= 89)
{
    Console.WriteLine("B");
  

}
else
{
    Console.WriteLine("A - Good job!!!");
}

int gradeAfterBonus = grade > 0 || grade < 100 ? grade += 10 : 0;


Console.WriteLine("******************** Complex IF.. Else IF Results End *******************\n");

Console.WriteLine("******************** Ternary Operator Result *******************");

string passStatus = grade < 50 ? "Failed" : "Pass";

Console.WriteLine($"Student Status: {passStatus}");

Console.WriteLine("******************** Ternary Operator Result End *******************");

Console.WriteLine("\n******************** Switch Statement Results *******************");

Console.WriteLine("Choose the day of the week by entering a number between 1 - 7.");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1: 
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        Console.WriteLine("Hump day!");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Not a day of the week.");
        break;
}
Console.WriteLine("******************** Switch Statement Results End *******************");

Console.WriteLine("******************** Switch Statement Results End *******************");




// The rest of the application
Console.WriteLine("Thank you for using this program");

