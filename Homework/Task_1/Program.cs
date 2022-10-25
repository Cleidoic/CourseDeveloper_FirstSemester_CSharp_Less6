/* Задача 1: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4
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
            Console.WriteLine($"Ввели не число или оно слишком большое. Введите корректное число \n");
    }
    return result;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetNumber($"Введите число {i+1}: ");
    }
    return array;
}

int IsPositive (int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0)
            count++;
    }
    return count;
}


Console.WriteLine(
    IsPositive(
        GetArray(
            GetNumber("Введите размер массива: ")
        )
    )
);

