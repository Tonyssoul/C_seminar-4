// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int a = InputNumber("Введите число ");
int sum = 0;

void Result(int b)
{
    while (b > 0)
    {
        sum += b % 10;
        b /= 10;
    }
}

Result(a);

System.Console.WriteLine(sum);