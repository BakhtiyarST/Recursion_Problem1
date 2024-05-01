// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

class Program
{
    static void Main()
    {
        int m, n;
        bool flagRise;

        Console.WriteLine("Enter the M-value:");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the N-value:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("The result is:");
        flagRise = (m < n) ? true : false;
        MToN(m, n, flagRise);
    }

    static void MToN(int m, int n, bool flag)
    {
        int arg1, arg2, arg3;
        if (flag)
        {
            arg1 = m;
            arg2 = n + 1;
            arg3 = n - 1;
        }
        else
        {
            arg1 = n - 1;
            arg2 = m;
            arg3 = n + 1;
        }
        if (arg1 < arg2)
        {
            MToN(m, arg3, flag);
            Console.WriteLine($"{n} ");
        }
    }
}