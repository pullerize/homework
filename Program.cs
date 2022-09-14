/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)    /   2, 4 -> 16 

int Find(int number_a, int number_b)
{
    int result = 1;
    for (int i = 1; i <= number_b; i++)
    {
        result = result * number_a;
    }
    
    return result;
}

Console.Write("Введите число A: ");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number_b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Возведенние из числа {number_a} в число {number_b} равняется : {Find(number_a, number_b)}");
*/

/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11   /   82 -> 10    /   9012 -> 12 


int Sum_num(int num)
{
    int counter = Convert.ToString(num).Length; // 3
    int advance = 0;
    int result = 0;

    for (int current = 0; current < counter; current++)
    {
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
    return result;
}

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма цифр из числа {num} равна: {Sum_num(num)}");
*/

/* Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  /   6, 1, 33 -> [6, 1, 33] 


static void Show_array(string[] args)
{

    Console.Write("Введите количество элементов массива: ");

    int element_count = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Вывод массива: ");

    int [] my_array = new int [element_count];

    for (int i = 0; i < my_array.Length; i++)
    { 
        Console.Write($"Введите значение массива под индексом {i}: ");
        my_array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write($"Значения массива в {element_count} елементах: ");

    for (int i = 0; i < my_array.Length; i++)
    {
        Console.Write($"[{my_array[i]}] ");
    }
   
}

Show_array(args);
*/