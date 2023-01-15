// See https://aka.ms/new-console-template for more information
using SecondConsole;
using System.Linq.Expressions;

Console.WriteLine("Enter 1 for if else \nEnter 2 for do while");

switch(Console.ReadLine())
{
    case "1":
        Console.WriteLine(SecondClass.secondMethod());
        break;
    case "2":
        Console.WriteLine(SecondClass.password());
        break;
    default:
        Console.WriteLine("Invalid input!!");
        break;

}