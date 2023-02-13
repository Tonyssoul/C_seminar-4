// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



string InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Console.ReadLine();
}

string a = InputNumber("Введите число ");
int result = a.Length;

System.Console.WriteLine(result);