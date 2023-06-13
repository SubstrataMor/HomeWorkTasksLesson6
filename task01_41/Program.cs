// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Input()
{
    int[] array = new int[1];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите числа(q - выход): ");
        string? userInput = Console.ReadLine();
        if (userInput == "q")
        {
            break;
        }
        else if (userInput == "Q")
        {
            break;
        }
        else if ((int.TryParse(userInput, out int num)) == false)
        {
            Console.WriteLine("Это не число");
        }
        else
        {
            Array.Resize(ref array, array.Length + 1);
            array[i] = Convert.ToInt32(userInput);
        }
    }
    Array.Resize(ref array, array.Length - 1);
    return array;
}
void OutputArray(int[] arr)
{
    Console.Write("Вы ввели следующие числа: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}
void ShowMeVolOfNumbers(int[] userNumbers)
{
    Console.Write("Числа больше нуля: ");
    int count = 0;
    foreach (var item in userNumbers)
    {
        if (item > 0)
        {
            count += 1;
            Console.Write($"{item}, ");
        }
    }
    Console.Write($"-> Всего чисел: {count}");
}
int[] newArray = Input();
Console.WriteLine();
OutputArray(newArray);
Console.WriteLine();
ShowMeVolOfNumbers(newArray);
