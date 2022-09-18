// See https://aka.ms/new-console-template for more information
using firstConsoleApp;
using SecondConsole;

Console.WriteLine("Hello, World!");

firstClass obj = new firstClass();
var first = obj.firstMethod();

SecondClass obj2 = new SecondClass();
var second = obj2.secondMethod();

Console.WriteLine(first);
Console.WriteLine(second);
Console.ReadLine();
