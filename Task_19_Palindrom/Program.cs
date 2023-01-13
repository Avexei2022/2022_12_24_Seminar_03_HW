// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

class InputNumber {
    public int Nmb_5() {
        int num;
        Console.Write("Введите пятизначное положительное целое число: ");
        int.TryParse(Console.ReadLine(), out num);
        while (num < 10000 | num > 99999) {
            Console.WriteLine("Вы не выполнили условия ввода.");
            Console.Write("Повторите ввод числа: ");
            int.TryParse(Console.ReadLine(), out num);
        }
        return num;
    }
}

class CheckPalindrom {
    static void Main(){
        Console.Clear();
         int number;
       InputNumber obNum = new InputNumber();
       number = obNum.Nmb_5();
        if (number/10000 == number%10 && number/1000%10 == number%100/10) {
            Console.WriteLine($"Число {number} является полиндромом");
            Console.WriteLine($"{number} -> Да");
        }
        else {
            Console.WriteLine($"Число {number} не является полиндромом");
            Console.WriteLine($"{number} -> Нет");
        }
    }
}



