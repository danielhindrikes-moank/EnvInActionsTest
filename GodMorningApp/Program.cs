Console.WriteLine("Is it morning?");

var time = TimeOnly.FromDateTime(DateTime.Now);

if(time < new TimeOnly(9,0) && time > new TimeOnly(5,0))
{
    Console.WriteLine("Good morning!");
    return;
}

Console.WriteLine("It is not morning!");