// // принимает на вход число N и выдает произведение чисел от 1 до N
void Factorial(double n)
{
    double pseudoFactorial = 1;
    for (int i = 1; i <= n; i++)
    {
        pseudoFactorial = pseudoFactorial * i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {n} = {pseudoFactorial}");
}

Console.Clear();
Console.WriteLine("Эта программа принимает на вход число N и выдает произведение чисел от 1 до N.");
Console.WriteLine("Что вы хотите сделать?:");
Console.WriteLine("Нажмите 1, если хотите задать число N самостоятельно");
Console.WriteLine("Нажмите 2, если хотите задать максимум для диапазона случайных чисел");
Console.WriteLine("Нажмите любую другую клавишу, если хотите выйти");
int choice = int.Parse(Console.ReadLine());
// switch (choice)
// {
//     case 1:
//         Console.WriteLine("Отлично. Вы хотите сами задать число. Введите число N: ");
//         double number = Convert.ToDouble(Console.ReadLine());
//         Factorial(number); break;
//     case 2:
//         Console.WriteLine("Ок. Пусть будет случайное число. Введите максимальное число для поиска случайного значения: ");
//         int max = Convert.ToInt32(Console.ReadLine());
//         double number = new Random().Next(0, max+1);
//         Factorial(number); break;
//     default: Console.WriteLine("Всего доброго!"); break;
// }

if (choice == 1)
{
    Console.WriteLine("Отлично. Вы хотите сами задать число. Введите число N: ");
    double number = Convert.ToDouble(Console.ReadLine());
    Factorial(number);
}
else
{
    if (choice == 2)
    {
        Console.WriteLine("Ок. Пусть будет случайное число. Введите максимальное число для поиска случайного значения: ");
        int max = Convert.ToInt32(Console.ReadLine());
        double number = new Random().Next(0, max+1);
        Factorial(number);
    }
    else
    {
        Console.WriteLine("Всего доброго!");
    }
}