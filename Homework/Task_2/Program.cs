/* Задача 2: 
Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
Значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    Console.WriteLine(message);
    while (!isCorrect)
    {
        isCorrect = int.TryParse(Console.ReadLine(), out result);
        if (!isCorrect)
            Console.WriteLine("Ввели не число или оно слишком большое.\n Введите корректное число: \n");
    }
    return result;
}

void GetPoint(int k1, int b1, int k2, int b2)
{
    double x = (double)(b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;

    if (k1 - k2 != 0)
        Console.WriteLine("Точка пересечения прямых: ({0}, {1})", x, y1);
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else
        Console.WriteLine("Точек пересечения нет");
}

int k1 = GetNumber("Введите коэффициент k1: ");
int b1 = GetNumber("Введите коэффициент b1: ");
int k2 = GetNumber("Введите коэффициент k2: ");
int b2 = GetNumber("Введите коэффициент b2: ");

GetPoint(k1, b1, k2, b2);