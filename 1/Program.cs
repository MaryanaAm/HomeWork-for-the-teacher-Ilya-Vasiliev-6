// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите длину массива: ");
int lengthOfArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lengthOfArray];


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите значение эдемента {i} : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Вывод массива: ");

for (int i = 0; i < array.Length; i++)
{
        Console.Write($"{array[i]} ");
        
}

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if(array[j] > 0)
     count++;
}

Console.WriteLine();
Console.WriteLine($"Количество положительных чисел {count}: ");
