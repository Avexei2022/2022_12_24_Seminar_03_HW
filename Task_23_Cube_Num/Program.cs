// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

class GetNum {
    public int CheckInt() {
        int num;
        Console.Write("Введите число: ");
        int.TryParse(Console.ReadLine(), out num);
        while (num < 1) {
            Console.Write("Число не соответствует условиям задачи, повторите ввод числа: ");
            int.TryParse(Console.ReadLine(), out num);
        }
        Console.WriteLine();
        return num;
    }
}

class PrintResult {
    public void PrntRslt(int num) {
        int number = num;
        double count = 1;
        Console.Write($"{number} -> ");
        for (count = 1; count < number; count++) {
            Console.Write($"{Math.Pow(count, 3)}, ");
        }
        Console.WriteLine($"{Math.Pow(count, 3)}.");
        Console.WriteLine(); 
    }
}

class FindCub {
    static void Main() {
        Console.Clear();
        Console.WriteLine(@"Программа, принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
        Console.WriteLine();
        GetNum gn = new GetNum();
        PrintResult pr = new PrintResult();
        pr.PrntRslt(gn.CheckInt());
    }
}
