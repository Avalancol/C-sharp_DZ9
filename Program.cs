// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Задача 64: Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (N >= 1) Console.WriteLine(PrintNumbers(N, 1));
else Console.Write("Число N должно быть больше 0.");

// Метод
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}


// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("\nЗадача 66: Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
N = int.Parse(Console.ReadLine()!);
if (N > M) Console.WriteLine($"Сумма чисел на отрезке [{M};{N}] равна: {SummBetween(M, N)}");
else Console.Write("Число N должно быть больше числа М.");

// Метод
int SummBetween(int start, int end)
{
    if (start == end) return start;
    return (start + SummBetween(start + 1, end));
}


// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("\nЗадача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. A(m,n)");
Console.Write("Введите число m: ");
M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
N = int.Parse(Console.ReadLine()!);
if (N >= 0 && M >= 0) Console.WriteLine($"Значение функции A({M},{N}) равно: {FuncAccerman(M, N)}");
else Console.Write("Числа m, n должны быть неотрицательными.");


int FuncAccerman(int n, int m)
{
    if (n == 0) return (m + 1);
    else if (m == 0) return FuncAccerman(n - 1, 1);
    return (FuncAccerman(n - 1, FuncAccerman(n, m - 1)));
}

