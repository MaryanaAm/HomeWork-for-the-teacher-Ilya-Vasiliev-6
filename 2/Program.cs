// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

(double, double)GetValue(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1) / (k1-k2);
    double y = k1 * x + b1;
    return (x, y);
}

(double x, double y) = GetValue(4, 12, 8, 4);
Console.Write($"X: {x}, Y: {y}");

