Console.Write("Podaj liczbę całkowitą dodatnią: ");
int number = Convert.ToInt32(Console.ReadLine());
int reversedNumber = 0;

if (number <= 0)
{
    Console.WriteLine("Podana liczba nie jest liczbą dodatnią.");
}
else
{
    while (number > 0)
    {
        int digit = number % 10;
        reversedNumber = reversedNumber * 10 + digit;
        number /= 10;
    }
    Console.WriteLine($"Odwrócona liczba to: {reversedNumber}");
}