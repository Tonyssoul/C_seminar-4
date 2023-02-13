// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}
int a = InputNumber("Введите число А ");
int b = InputNumber("Введите число B ");

System.Console.WriteLine($"{a} в степени {b} равно {Math.Pow(a,b)}");