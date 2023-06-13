// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// k1 * x + b1 = k2 * x + b2
// 5x + 2 = 9x + 4
// 5x -9x -4 + 2 = 0
// -4x -2 = 0
// -4x = 2
// x = -0,5
// y = 5*(-0, 5) +2
// y = -2,5 + 2
// y = -0,5
// Ответ: x = -0,5; y = -0,5

// double b1 = 2;
// double k1 = 5;
// double b2 = 4;
// double k2 = 9;

// double x = ((b1 - b2) * (-1)) / (k1 - k2);
// double y = k1 * x + b1;
// Console.WriteLine($"{x}, {y}");

double Input()
{
    string? userInput = Console.ReadLine();
    if ((double.TryParse(userInput, out double num)) == false)
    {
        Console.WriteLine("Это не число");
    }
    return num;
}
void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = ((b1 - b2) * (-1)) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты пересечения прямых: ({Math.Round(x, 1)}, {Math.Round(y, 1)})");
}
Console.WriteLine("Введите значения первой прямой: ");
double numB1 = Input();
double numK1 = Input();
Console.WriteLine("Введите значения второй прямой: ");
double numB2 = Input();
double numK2 = Input();
FindIntersectionPoint(numB1, numK1, numB2, numK2);