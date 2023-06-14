// Написать программу которая на вход принемает число и выдает являеться ли число четным
// (делиться ли оно на два без остатка). 
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
Console.WriteLine("число четное");
else 
Console.WriteLine("число не четное");