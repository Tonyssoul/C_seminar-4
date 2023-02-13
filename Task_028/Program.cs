// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}
int num = InputNumber("Введите число А ");


int GetSumElement(int A)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i; // result = result + i
    }  
    return result;
}


System.Console.WriteLine($"сумма чисел от 1 до числа {num} = {GetSumElement(num)}");