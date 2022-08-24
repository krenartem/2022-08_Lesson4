// цикл принимает на вход 2 числа А и В, и возводит А в натуральную степень В
void ShowResult(int X, int Y, double XpowY)
{
    Console.WriteLine($"Число {X} в степени {Y} = {XpowY}");
}

void MathPow(int number, int pow)
{
    double result = 1;
    if (pow == 0)
    {
        ShowResult(number, pow, result);
    }
    else
    {
        if (pow > 0)
        {
            for (int i = 1; i <= pow; i++)
            {
                result *= number;
            }
            ShowResult(number, pow, result);
        }
        else
        {
            for (int i = 1; i <= -pow; i++)
            {
                result *= number;
            }
            result = 1 / result;
            ShowResult(number, pow, result);
        }
    }
}

Console.Clear();
Console.WriteLine("Программа возводит целое число X в натуральную степень Y.");
Console.WriteLine();
Console.Write("Введите число X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
MathPow(X, Y);