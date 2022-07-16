//Программа, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа.

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

//Метод, который выводит случайное трёхзначное число
//и удаляет вторую цифру этого числа, напр. 731 -> 71

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

//Метод, который принимает на вход два числа и выводит, является ли второе число 
//кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления

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

//Метод, который принимает на вход число и проверяет, кратно ли оно
//одновременно 7 и 23.

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

//Метод, который принимает на вход два числа и проверяет, является ли одно 
//число квадратом другого.

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

//&& number2 * number2 == number 1

//Zadacha9();
//Zadacha11();
//Zadacha12();
//Zadacha14();
//Zadacha16();