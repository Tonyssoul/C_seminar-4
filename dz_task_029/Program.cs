// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Требуется ввести размер массива и диапазон");

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int a = InputNumber("Введите начальное число диапазона ");
int b = InputNumber("Введите конечное число диапазона ");
int size = InputNumber("Введите размер массива ");

var rand = new Random();

int[] FillArray()
{
    var array = new int[size];
    var rand = new Random();
    if (a < b)
    {
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(a, b);
        }
        return array;
    }
    else
    {
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(b, a);
        }
        return array;
    }
}


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

var myArray = FillArray();
PrintArray(myArray);
