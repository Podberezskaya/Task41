//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел: ");
int [] array = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        {
            count++;
        }
}
Console.WriteLine($"{count}");
