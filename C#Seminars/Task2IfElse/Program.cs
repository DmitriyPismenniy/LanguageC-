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

/*
Console.WriteLine("Введите первое число ");
 int b = Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine("Введите второе число "); 
 int a = Convert.ToInt32(Console.ReadLine()); 
 int res=b*b; Console.WriteLine((a==res)? "Да":"Нет");*/
