// Напишите программу,которая на вход принемает два числа и выдает какое число число больше,а какое меньше.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите первое целое число:");
string number = Console.ReadLine()!;
int a = int.Parse(number);
Console.Write("Введите второе целое число:");
number = Console.ReadLine()!;
int b = int.Parse(number);
int max = a;
if (a > max) max = a;
else
{
    if (b > max) max = b;
}
Console.WriteLine(max);
    
