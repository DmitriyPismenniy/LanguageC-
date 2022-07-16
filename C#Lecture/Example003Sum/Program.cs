//int numberA = 3;
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9 
Console.Write("Первое число: " + numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine("; Второе число: " + numberB);
//Console.WriteLine(numberA + numberB);
int result = numberA + numberB;
Console.WriteLine("Сумма чисел: " + result);