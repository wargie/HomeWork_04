// 26.Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень В: ");
int exponenta = Convert.ToInt32(Console.ReadLine());

int GetExponentiation(int number, int exponenta)

{

    int count = 1;
    int result = number;

    while (count < exponenta)

    {
        result = result * number;
        count++;
    }

    return result;

}

int result = GetExponentiation(number, exponenta);
Console.WriteLine($"число {number} в степени {exponenta} = {result}");