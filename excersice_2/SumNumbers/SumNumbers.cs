int sum = 0;

Console.Write("Podaj swoją liczbę: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    sum = sum + i;
}

Console.WriteLine($"Suma liczb od 1 do {number} wynosi: {sum}");