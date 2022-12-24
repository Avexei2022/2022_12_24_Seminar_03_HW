// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
int number = 0;
Console.Write("Введите положительное целое число от 1 до 30: ");
int.TryParse(Console.ReadLine(), out number);
while (number < 1 | number > 30)
{
    Console.WriteLine("Вы не выполнили условия ввода.");
    Console.Write("Повторите ввод числа: ");
    int.TryParse(Console.ReadLine(), out number);
}
double count = 1;
Console.Write($"{number} -> ");
for (count = 1; count < number; count++)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
}
Console.WriteLine($"{Math.Pow(count, 3)}.");
Console.WriteLine();