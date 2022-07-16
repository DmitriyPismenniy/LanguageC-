Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1) Console.WriteLine("Это понедельник");
    else if (number == 2) Console.WriteLine("Это вторник");
    else if (number == 3) Console.WriteLine("Это среда");
    else if (number == 4) Console.WriteLine("Это четверг");
    else if (number == 5) Console.WriteLine("Это пятница");
    else if (number == 6) Console.WriteLine("Это суббота");
    else if (number == 7) Console.WriteLine("Это воскресенье");
    else Console.WriteLine("Не верное число");
/*
string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"}; 
Console.WriteLine(array[Convert.ToInt32(Console.ReadLine()) - 1]); 

Console.WriteLine("Введите число "); 
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
} 


*/