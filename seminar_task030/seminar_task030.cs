// выводит массив из X элементов, заполненный числами от min до max в случайном порядке

// создание массива случайных чисел
int [] CreateRandomArray(int Length, int min, int max)
{
    int[] RandomArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
    }
    return RandomArray;
}

// // создание массива пользовательского размера и пользовательских значений
// int[] CreateUserArray()
// {
//     Console.Write("Введите количество элементов массива: ");
//     int length = int.Parse(Console.ReadLine());
//     int[] UserArray = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write($"Введите значение {i + 1} элемента массива: ");
//         UserArray[i] = int.Parse(Console.ReadLine());
//     }
//     return UserArray;
// }

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение в массиве: ");
int arrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение в массиве: ");
int arrayMax = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateRandomArray(arrayLength, arrayMin, arrayMax);

// int[] MyArray = CreateUserArray();

Console.WriteLine();
Console.WriteLine(String.Join(", ", MyArray));
Console.WriteLine();