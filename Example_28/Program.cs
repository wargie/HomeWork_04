// 28.Подсчитать сумму цифр в числе

int randomNumber = new Random().Next(1, 100000);
Console.WriteLine($"Сгенерировано случайное число {randomNumber}");

int sumDigits = 0;
Console.Write($"Сумма цифр числа {randomNumber} равна ");

    while (randomNumber > 0)

        {
            int digit = randomNumber % 10;
            sumDigits = sumDigits + digit;
            randomNumber = randomNumber / 10;
        }

Console.WriteLine(sumDigits);