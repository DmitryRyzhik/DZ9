// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string prompt)
{
    System.Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

int m=ReadInt("Введите неотрицательное число m: ");
int n=ReadInt("Введите неотрицательное число n: ");
System.Console.WriteLine($"Вычисление функции Аккермана: {Ackermann(m,n)}");