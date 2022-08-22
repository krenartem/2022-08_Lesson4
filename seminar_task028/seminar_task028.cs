// принимает на вход число N и выдает произведение чисел от 1 до N
// задана переменная double, т.к. int при 13 и больше - уже не считает произведение корректно
// очень хотелось применить функцию switch. Получилось)))
// и получилось проверить, что из метода можно ссылаться на другой метод.
// и команда Convert.ToDouble работает. Красота! Столько нового в одном задании!
void Factorial(double n)
{
    double pseudoFactorial = 1;
    for (int i = 1; i <= n; i++)
    {
        pseudoFactorial = pseudoFactorial * i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {n} = {pseudoFactorial}");
}

void selfWrite(int x)
{
    Console.WriteLine("Отлично. Вы хотите сами задать число. Введите число N: ");
    double number = Convert.ToDouble(Console.ReadLine());
    if (number < 0)
    {
        Console.WriteLine("Вы ввели отрицательное число, поэтому возьмем модуль от него и дальше работать будем с ним");
        number = number * -1;
        Factorial(number);
    }
    else
    {
        if (number > 0)
        {
            Factorial(number);
        }
        else
        {
            Console.WriteLine("Умножение на 0 дает 0");
        }
    }
}

void randomWrite(int y)
{
    Console.WriteLine("Ок. Пусть будет случайное число. Введите максимальное число для поиска случайного значения: ");
    int max = Convert.ToInt32(Console.ReadLine());
    if (max < 0)
    {
        Console.WriteLine("Вы ввели отрицательное число, поэтому возьмем модуль от него и дальше работать будем с ним");
        max = max * -1;
        double number = new Random().Next(0, max+1);
        Factorial(number);
    }
    else
    {
        if (max > 0)
        {
            double number = new Random().Next(0, max+1);
            Factorial(number);
        }
        else
        {
            Console.WriteLine("Умножение на 0 дает 0");
        }
    }
}

Console.Clear();
Console.WriteLine("Эта программа принимает на вход положительное число N и выдает произведение чисел от 1 до N.");
Console.WriteLine("Что вы хотите сделать?:");
Console.WriteLine("Нажмите 1, если хотите задать число N самостоятельно");
Console.WriteLine("Нажмите 2, если хотите задать максимум для диапазона случайных чисел");
Console.WriteLine("Нажмите любое другое число, если хотите выйти");
int choice = int.Parse(Console.ReadLine());

 switch (choice)
{
    case 1: selfWrite(choice); break;
    case 2: randomWrite(choice); break;
    default: Console.WriteLine("Всего доброго!"); break;
}

// if (choice == 1)
// {
//     Console.WriteLine("Отлично. Вы хотите сами задать число. Введите число N: ");
//     double number = Convert.ToDouble(Console.ReadLine());
//     Factorial(number);
// }
// else
// {
//     if (choice == 2)
//     {
//         Console.WriteLine("Ок. Пусть будет случайное число. Введите максимальное число для поиска случайного значения: ");
//         int max = Convert.ToInt32(Console.ReadLine());
//         double number = new Random().Next(0, max+1);
//         Factorial(number);
//     }
//     else
//     {
//         Console.WriteLine("Всего доброго!");
//     }
// }