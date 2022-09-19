/* Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 

int [] Create_random_array(int size, int min_value, int max_value) // size = 4
{
    int[] new_array = new int[size];
    for (int i = 0; i < size; i++)
    {
        new_array[i] = new Random().Next(min_value, max_value + 1);
    }
    return new_array;
}

// void Show_array(int[] array) // Для проверки
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");           
//     }
//     Console.WriteLine();
// }


void Сhecking_even_values (int [] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] % 2 == 0)
         {
            Console.Write($"{array[i]} является четным значением. // ");
         }
    }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное трехзначное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное трехзначное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] my_array = Create_random_array(size, min, max);
// Show_array(my_array); // Для проверки
Сhecking_even_values(my_array);
 */


 /* Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 [3, 7, 23, 12] -> 19   /   [-4, -6, 89, 6] -> 0 

 int [] Create_random_array(int size, int min_value, int max_value) 
{
    int[] new_array = new int[size];
    for (int i = 0; i < size; i++)
    {
        new_array[i] = new Random().Next(min_value, max_value + 1);
    }
    return new_array;
}

void Show_array(int[] array) // Для проверки
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");           
    }
    Console.WriteLine();
}

void Сhecking_even_values (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i +2)
    {         
        sum += array[i]; 
    }    
    Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна: {sum}"); 
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] my_array = Create_random_array(size, min, max);
Show_array(my_array); // Для проверки
Сhecking_even_values(my_array);*/

/* Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/


double[] Array(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
        array[i] = Math.Round(array[i], 3);
    }

    return array;
}

void ShowArray(double[] array)
{
    int size = array.Length;

    for(int i = 0; i < size; i++)
    {
        if(i == 0) Console.Write($"[{array[i]}, ");
        if((i > 0) && (i < size - 1)) Console.Write($"{array[i]}, ");
        if(i == size - 1) Console.WriteLine($"{array[i]}]");
    }

    Console.WriteLine();
}

double Min(double[] array)
{
    int size = array.Length;
    double min = array[0];
    for(int i = 1; i < size; i++)
    {
        if(array[i] < min) min = array[i];
    }

    return min;
}

double Max(double[] array)
{
    int size = array.Length;
    double max = array[0];
    for(int i = 1; i < size; i++)
    {
        if(array[i] > max) max = array[i];
    }

    return max;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

double[] array = Array(sizeArray);
ShowArray(array);

Console.WriteLine($"Минимальный элемент: {Min(array)}. \nМаксимальный элемент: {Max(array)}");
Console.WriteLine($"Разница равна: {Max(array) - Min(array)}"); // [3 7 22 2 78] -> 76