// Задача.1 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Write("Введите кол-во чисел в массиве: ");
// int Length = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[Length];

// void massive(int Length)
// {
//     for (int count = 0; count < Length; count++)
//     {
//         randomArray[count] = new Random().Next(99, 999);
//         Console.Write(randomArray[count] + " ");
//     }

// }

// int quantity(int[] randomArray)
// {
//     int quantity = 0;
//     for (int count = 0; count < randomArray.Length; count++)
//     {
//         if (randomArray[count] % 2 == 0)
//             quantity++ ;
//     }
//     return quantity;
// }

// massive(Length);
// Console.Write($" Кол-во чётных чисел в массиве: {quantity(randomArray)}");

//Задача. 2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// Console.Write("Введите кол-во чисел в массиве: ");
// int Length = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[Length];

// void massive(int Length)
// {
//     for (int i = 0; i < Length; i++)
//     {
//         randomArray[i] = new Random().Next(1, 9);
//         Console.Write(randomArray[i] + " ");
//     }

// }

// int quantity(int[] randomArray)
// {
//     int sum = 0;
//     int i = 0;
//     while (i < randomArray.Length)
//     {
//         sum = sum + randomArray[i];
//         i = i + 2;
//     }
//     return sum;
// }

// massive(Length);
// Console.Write($"Cумма чисел, находящихся на нечётных позициях: {quantity(randomArray)}");


//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void massive(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write($"{randomArray[i]:F2} ");
}

}

double dif(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

massive(a);
Console.Write($"Разница между максимальным и минимальным элементов массива: {dif(randomArray)}");