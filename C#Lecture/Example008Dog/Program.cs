int count = 0;
int time = 1;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int DogSpeed = 5;
int friend = 2;
       
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + DogSpeed);
        friend = 1;             
    }
    distance = distance - ((firstFriendSpeed + secondFriendSpeed) * time);
    count++;
    Console.WriteLine("distance" + distance);
}

Console.WriteLine("Собака пробежит " + count + " раз");
