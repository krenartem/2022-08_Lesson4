// задает массив из 8 элементов и выводит их на экран
// удобно, когда можно воспользоваться готовыми кусками программ. Решение задачи заняло 4 минуты
int[] CreateRandomArray(int Length, int min, int max)
{
    int[] RandomArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine(String.Join(", ", array));
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Создаем массив из 8 элементов.");
Console.Write("Введите минимальное значение в массиве: ");
int arrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение в массиве: ");
int arrayMax = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateRandomArray(8, arrayMin, arrayMax);
ShowArray (MyArray);
