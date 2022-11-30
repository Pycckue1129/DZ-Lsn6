// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2


Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] array = { b1, k1, b2, k2 }; // возврат двух значений (переменных) с метода ( функции) 

System.Console.WriteLine($"Точка пересечения двух прямых, равна: {GetPoint(array)}");

(double, double) GetPoint(double[] array)
{
    double x = ((array[2] - array[0]) / (array[1] - array[3])); //((k1-k2)/(b2-b1))
    double point1 = array[1] * x + array[0];
    double point2 = array[3] * x + array[2];
    return (point1, point2);
}