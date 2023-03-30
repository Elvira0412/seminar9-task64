// Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.

int m = InputInt("Введите положительное число: M= ");
int n = InputInt("Введите положительное число: N= ");

if (n < m)
{
    Console.WriteLine("Ввели отрицательное число");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
