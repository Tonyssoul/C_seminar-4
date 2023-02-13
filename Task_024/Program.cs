// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36




int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}
int num = InputNumber("Введите число А ");


int GetSumElement(int A)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result += i; // result = result + i
    }  
    return result;
}


System.Console.WriteLine($"сумма чисел от 1 до числа {num} = {GetSumElement(num)}");