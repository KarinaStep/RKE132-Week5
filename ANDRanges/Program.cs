//temp <= 0 - Freezing cold               -lõpmatus kuni 0
//temp > 0 AND temp < 10  - Cold                  1 kuni 9
//temp >= 10 AND temp < 15 - Chilly              10 kuni 14
//temp >= 15 AND temp < 20 - Warm                15 kuni 19
//temp >= 20 AND temp < 30 - Hot                 20 kuni 29
//temp >= 30 - Boiling hot                       30 kuni lõpmatus

Console.WriteLine("Enter the temperature: ");
int temp = Int32.Parse(Console.ReadLine());

if(temp >= 30)
{
    Console.WriteLine("Boiling hot.");
}
else if(temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot.");
}
else if (temp < 20 && temp >= 15) 
{
    Console.WriteLine("Warm.");
}
else if(temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly.");
}
else if(temp < 10 && temp > 0)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("Freezing cold.");
}