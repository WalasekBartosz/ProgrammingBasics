Console.Write("Podaj N: ");

if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Podana wartość nie jest liczbą całkowitą.");
    return;
}

if (number >= 1)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i} - kwadrat: {i * i}");
    }
}
else
{
    for (int i = 1; i >= number; i--)
    {
        Console.WriteLine($"{i} - kwadrat: {i * i}");
    }
}
