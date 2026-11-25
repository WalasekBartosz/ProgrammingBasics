Console.Write("Podaj liczbę: ");

if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
{
    Console.WriteLine("Podana wartość nie jest liczbą całkowitą dodatnią.");
    return;
}

int digitCount = 0;
int digitSum = 0;

while (number > 0)
{
    int digit = number % 10;
    digitSum += digit;
    digitCount++;
    number /= 10;
}

Console.WriteLine($"Liczba cyfr: {digitCount}");
Console.WriteLine($"Suma cyfr: {digitSum}");