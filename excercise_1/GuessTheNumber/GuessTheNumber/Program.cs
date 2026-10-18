int number = 0;

Random rnd = new Random();
int randomNumber = rnd.Next(1, 101);

while (number != randomNumber)
{
    Console.Write("Zgadnij liczbę (1-100): ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > randomNumber)
    {
        Console.WriteLine("Liczba za duża, spróbuj ponownie.");
    } else if (number < randomNumber)
    {
        Console.WriteLine("Liczba za mała, spróbuj ponownie.");
    } else
    {
        Console.WriteLine($"Brawo!! Wylosowana liczba to {randomNumber}.");
    }
}