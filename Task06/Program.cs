// Напишите программу, 
// 1. которая на вход принимает число и 
// 2. выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да 
// -3 -> нет 
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
