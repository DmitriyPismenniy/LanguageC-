//Console.WriteLine("Введите число: ");
//string numberString = Console.ReadLine();
//int number = Convert.ToInt32(numberString);
//int number = Convert.ToInt32(Console.ReadLine());
//int result = number * number;
//Console.WriteLine("Квадрат числа равен: " + result);
//Console.WriteLine($"{numbers} * {numbers} = {result}");
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