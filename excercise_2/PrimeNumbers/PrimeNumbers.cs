Console.Write("Podaj liczbę: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isPrime = number > 1;

for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
}

Console.WriteLine(isPrime ? $"{number} jest liczbą pierwszą." : $"{number} nie jest liczbą pierwszą.");