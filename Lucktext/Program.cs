// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("vad du namn?");
string name = Console.ReadLine();
Console.WriteLine("var du bor?");
string hus = Console.ReadLine();
Console.WriteLine("vad är din bankinformation?");
string bank = Console.ReadLine();
Console.WriteLine($"Hej {name} som bor vid {hus}.");
Console.WriteLine("om detta är din bankinformation tryck Y om det är fel tryck något annat");
Console.WriteLine($"{bank}");
string svar = Console.ReadLine();
if(svar == "Y" || svar == "y"){
    Console.WriteLine("tack för din hjälp");
    Console.ReadLine();
}
else
{
    Console.WriteLine("to bad");
    Console.ReadLine();
}
// gud
