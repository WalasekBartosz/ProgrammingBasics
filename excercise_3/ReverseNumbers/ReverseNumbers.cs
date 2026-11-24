Console.Write("Podaj liczbę: ");

if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
{
    Console.WriteLine("Podana wartość nie jest liczbą całkowitą dodatnią.");
    return;
}

Console.Write("Liczba odwrotna: ");

while (number > 0)
{
    int digit = number % 10;
    Console.Write(digit);
    number /= 10;
}

Console.WriteLine();