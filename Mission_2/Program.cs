// Написать программу,которая на вход принемает три числа и выдаёт максимальное
// из этих трех чисел. 2, 3, 7 -> max = 7; 44, 5, 78 -> max = 78; 22, 3, 9 -> max = 22. 

Console.Write("Ввидите первое целое числ:");
string number = Console.ReadLine()!;
int a = int.Parse(number);

Console.Write("Ввидите второе целое числ:");
number = Console.ReadLine()!;
int b = int.Parse(number);

Console.Write("Ввидите третье целое числ:");
number = Console.ReadLine()!;
int c = int.Parse(number);

int max = a;

if (a > b) max = a;
if (b > a) max = b;
if (c > a) max = c;

Console.WriteLine(max);
