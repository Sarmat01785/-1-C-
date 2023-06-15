// написать программу,котторая на вход принемает число (N), а на выходе показывает все
// четные числа от 1 до N. 5- > 2, 4.     8 - > 2, 4, 6, 8

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int index = 2;
while (index <= N)
{
    Console.Write(index + ", ");

    index = index + 2;
}
