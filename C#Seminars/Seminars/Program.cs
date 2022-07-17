//dotnet new console
//dotnet run

//Zadacha1 - Преобразование строки в число (Convert to Int) / Возведение числа в квадрат
//Zadacha2 - Операторы IF ELSE/ Является ли число квадратом другого
//Zadacha3 - Операторы несколько IF ELSE и SWITCH / Определение дня недели
//Zadacha4 - Процедура / Квадрат числа 
//Zadacha5 - Метод / Вывод всех чисел от -N до +N
//Zadacha9 - Вывод случайного числа из отрезка [10, 99] и показ наибольшей цифры числа
//Zadacha11 - Вывод случайное трёхзначного числа и удаление второй цифры 731 -> 71
//Zadacha12 - Ввод двух чисел и вывод кратности 2го числа 1му, Если не кратно, то вывод остатка
//Zadacha14 - Ввод числа и проверка кратности одновременно 7 и 23.
//Zadacha16 - Ввод двух чисел и проверка, является ли одно число квадратом другого
//Zadacha22 - Цикл for / Ввод числа N и вывод квадратов всех чисел от 1 до N
//Zadacha24 - Программа принимает число (А) и выдаёт сумму чисел от 1 до А
//Zadacha26 - Программа принимает число и выдаёт количество цифр в числе
//Zadacha28 - Программа принимает число и выдаёт произведение цифр в числе
//Zadacha30 - Ввод и вывод массива
//Football  - Программа про футбол
//FillArray     - Заполнение массива случайными числами
//PrintArray    - Печать массива


void Zadacha1()
{
    Console.WriteLine("Введите число: ");
    //string numberString = Console.ReadLine();
    //int number = Convert.ToInt32(numberString);
    int number = Convert.ToInt32(Console.ReadLine());
    int result = number * number;
    //Console.WriteLine("Квадрат числа равен: " + result);
    Console.WriteLine($"{number} * {number} = {result}");
}

void Zadacha2()
{
    Console.WriteLine("Введите первое число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberВ = Convert.ToInt32(Console.ReadLine());

    if (numberA * numberA == numberВ)
        {
        Console.WriteLine("Второе число является квадратом первого");
        }
        else
        {
        Console.WriteLine("Второе число не является квадратом первого");   
        }

    //Вариант2: b - первое число; a - второе число; решение -
    //int res=b*b; 
    //Console.WriteLine((a==res)? "Да":"Нет");
}

void Zadacha3()
{
    Console.Write("Введите номер дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 1) Console.WriteLine("Это понедельник");
        else if (number == 2) Console.WriteLine("Это вторник");
        else if (number == 3) Console.WriteLine("Это среда");
        else if (number == 4) Console.WriteLine("Это четверг");
        else if (number == 5) Console.WriteLine("Это пятница");
        else if (number == 6) Console.WriteLine("Это суббота");
        else if (number == 7) Console.WriteLine("Это воскресенье");
        else Console.WriteLine("Не верное число");

    
    /*Console.WriteLine("Введите число "); 
    int a = Convert.ToInt32(Console.ReadLine()); 
    switch (a) 
    { 
        case 1: Console.WriteLine("Понедельник"); 
        break; 
        case 2: Console.WriteLine("Вторник"); 
        break; 
        case 3: Console.WriteLine("Среда"); 
        break; 
        case 4: Console.WriteLine("Четверг"); 
        break; 
        case 5: Console.WriteLine("Пятница"); 
        break; 
        case 6: Console.WriteLine("Суббота"); 
        break; 
        case 7: Console.WriteLine("Воскресенье"); 
        break; 
    }*/ 


    
}

void Zadacha4()
{
    int number = 3;
    Console.WriteLine(Power(number));
    PowerProcedural(number);

    int Power(int currentNumber)
        {
            return currentNumber * currentNumber;        
        }

        void PowerProcedural(int currentNumber)
        {
            Console.WriteLine(currentNumber * currentNumber);
                
        }
}

void Zadacha5()
{
     Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
            int count = -number;

            while (count != (number+1))
                {
                    Console.Write(count + ",");
                    count++;
                }
        Console.Write("\b.");
        Console.WriteLine();

}

void Zadacha9()
{
    Random rand = new Random();
    int number = rand.Next(10, 100);
    Console.WriteLine(number);
    int digitOnes = number % 10;
    int digitTens = number / 10;
    Console.WriteLine(digitTens);
    Console.WriteLine(digitOnes);
    int max = digitTens;

    if (digitOnes > digitTens) max = digitOnes;

    Console.WriteLine("Наибольшая цифра числа: " + max);



}

void Zadacha11()
{
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine(number);
    int digitHundreds = number / 100;
    int digitTens = number / 10 %10;
    int digitOnes = number % 10;

    Console.WriteLine(digitHundreds);
    Console.WriteLine(digitTens);
    Console.WriteLine(digitOnes);

    int result = digitHundreds * 10 + digitOnes;

    Console.WriteLine("Итоговое число = " + result);

}

void Zadacha12()
{
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int result = number2 % number1;

    if (result != 0)
    {
        Console.WriteLine("Число 2 не кратно числу 1. Остаток от деления: " + result);
    }
    else Console.WriteLine("Число 2 кратно числу 1");
    
}

void Zadacha14()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("Число одновременно кратно 7 и 23");
        }
        else Console.WriteLine("Число не кратно 7 или 23");
        
}


void Zadacha16()
{
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 * number1 == number2 || number2 * number2 == number1)
    {
        Console.WriteLine("Одно число является квадратом другого");
    }
    else Console.WriteLine("Одно число не является квадратом другого");    
}


void Zadacha22()
{
    Console.Write("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int startnumber = 1;
    
    for (startnumber=1; startnumber <= number; startnumber++)
    {
        Console.Write(Math.Pow(startnumber, 2) + ", ");
    }
    Console.Write("\b\b.");
    Console.WriteLine();
}

void Zadacha24()
{
    Console.Write("Введите число: ");
    int numberА = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    int sum = 0;
    Console.Write(count + "+");

    while (count <= numberА)
    {
        sum += count;
        count++;
        Console.Write(count + "+");
        
    }
    Console.Write("\b\b\b=");
    Console.WriteLine(sum);
}

void Zadacha26()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    
    while (number > 0)
    {
        number /= 10;
        count++;
        
    }
    Console.WriteLine("Количество цифр в числе = " + count);

}

void Zadacha28()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    int mult = 1;
    Console.Write(count + "* ");

    while (count <= number)
    {
        mult *= count;
        count++;
        Console.Write(count + "* ");
        
    }
    Console.Write("\b\b\b\b\b = ");
    Console.WriteLine(mult);

}

void Zadacha30()
{
    int size = 10;
    Random random = new Random();
    int[] array = new int[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
     Console.WriteLine();  

}

//Даны два массива. В первом массиве записано количество 
//мячей, забитых футбольной командой в той или иной игре, 
//во втором — количество пропущенных мячей в этой же игре. 
//а) Для каждой проведенной игры напечатать словесный результат: 
//"выигрыш", "ничья" или "проигрыш". 
//б) Определить количество выигрышей данной команды. 
//в) Определить количество выигрышей и количество проигрышей данной команды. 
//г) Определить количество выигрышей, количество ничьих и количество проигрышей 
//данной команды. 
//д) Определить, в скольких играх разность забитых и пропущенных мячей была 
//большей или равной трем. 
//е) Определить общее число очков, набранных командой (за выигрыш даются 3 очка, 
//за ничью — 1, за проигрыш — 0). 

void Football()
{
    Random random = new Random();
    int size = random.Next(6, 10);
    int[] scored = new int[size];
    int[] conceded = new int[size];

    FillArray(scored);
    FillArray(conceded);
    
    Console.WriteLine("Забитые мячи");
    PrintArray(scored);
    Console.WriteLine();
    
    Console.WriteLine("Пропущенные мячи");
    PrintArray(conceded);
    Console.WriteLine(); 

    int wins = 0;
    int loses = 0;
    int draw = 0;
    int scores = 0;

    for (int i=0; i < scored.Length; i++)
    {
        int goal = scored[i];
        int miss = conceded[i];
        Console.Write($"{goal} : {miss}");
        if (goal > miss)
        {
            Console.WriteLine($" - Победа");
            wins++;
            scores+=3;
        }
        else if (goal < miss)
        {
            Console.WriteLine(" - Поражение");
            loses++;
        }
        else
        {
            Console.WriteLine(" - Ничья");
            draw++;
            scores+=1;
        }
    }
    Console.WriteLine($"Побед - {wins}, Поражений - {loses}, Ничьи - {draw}, Очков - {scores}");
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);        
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }

}




//Zadacha1();
//Zadacha2();
//Zadacha3();
//Zadacha4();
//Zadacha5();
//Zadacha9();
//Zadacha11();
//Zadacha12();
//Zadacha14();
//Zadacha16();
//Zadacha22();
//Zadacha24();
//Zadacha26();
//Zadacha28();
//Zadacha30();
Football();