// See https://aka.ms/new-console-template for more information
using Calculator;

main obj = new main();

Console.WriteLine("Enter a number");
var a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
var b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 1 to add \nEnter 2 to subtract \nEnter 3 to mutiply \nEnter 4 to divide ");

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine(main.addition(a, b));
        break;
    case "2":
        Console.WriteLine(main.subtraction(a, b));
        break;
    case "3":
        Console.WriteLine(main.multiplicaiton(a, b));
        break;
    case "4":
        Console.WriteLine(main.division(a,b));
        break;
    default:
        Console.WriteLine("That is not an option. Bye!");
        break;
}


Console.ReadLine();