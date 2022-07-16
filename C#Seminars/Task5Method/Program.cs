void Zadacha7()
{
    Console.WriteLine("Введите число: ");
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

    Zadacha7();
/*
    Console.WriteLine("Введите число "); 
    int N = Convert.ToInt32(Console.ReadLine()); 
    int a=-N; 
    int b=N; 
    for(int i=a; i<=b; i++)
    { 
        Console.Write(i+" "); 
    } 
    */