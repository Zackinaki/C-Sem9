// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число 
// А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int rec(int a, int b)
{
    if (b == 0 && a != 0)
        return 1;
    return rec(a, b - 1) * a;
}
Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(a, b));
