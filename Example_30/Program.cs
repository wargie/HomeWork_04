//30.Показать кубы чисел, заканчивающихся на четную цифру

int randomNumber = new Random().Next(1, 10);

Console.WriteLine($"Сгенерировано случайное число {randomNumber}");

int number = 1;

    while (number <= randomNumber)
    
    {
        int cube = number * number * number;
        
            if (cube % 2 == 0) Console.Write(cube + " ");

        number++;
    }