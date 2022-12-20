// Дана послед-ть чисел завершающаяся числом 0.Найдите сумму всех этих чисел   

int sum()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
        return 0;
    return sum() + x;
}


Console.Clear();
Console.WriteLine(sum());