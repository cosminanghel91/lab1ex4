/*
* Scrieti un program care va afisa semnul unui numar citit de la tastatura
* - Daca numarul este pozitiv, va afisa "+"
* - Daca numarul este negativ, va afisa "-"
* - Daca numarul este 0, va afisa "0"
*/

using System.ComponentModel.Design;
using System.Net.Security;

Console.WriteLine("Va rugam introduceti numarul:");
int numar = int.Parse(Console.ReadLine());

if (numar > 0)
{
    Console.WriteLine("+");
}
else if (numar < 0)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine("0");
}