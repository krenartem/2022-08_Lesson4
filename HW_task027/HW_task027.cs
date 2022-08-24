// принимает на вход число и выдает сумм цифр в числе
Console.Clear();
Console.Write("Введите любое целое число, программа посчитает сумму цифр в числе: ");
int number = int.Parse(Console.ReadLine());
int initNumber = number;
int sum = 0;
if (initNumber>0)
{
   while (number != 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
}
else
{
    while (number != 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    sum *= -1;
}
Console.WriteLine($"Сумма цифр в числе {initNumber} = {sum}");