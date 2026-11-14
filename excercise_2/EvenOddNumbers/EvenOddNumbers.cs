Console.Write("Podaj liczbę całkowitą: ");
int number = Convert.ToInt32(Console.ReadLine());

List<int> evenNumbers = [];
List<int> oddNumbers = [];

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0 )
    {
        evenNumbers.Add(i);
    }
    else
    {
        oddNumbers.Add(i);
    }
}

Console.WriteLine($"Liczby parzyste: {string.Join(" ", evenNumbers)}");
Console.WriteLine($"Liczb parzystych: {evenNumbers.Count}");
Console.WriteLine($"Liczb nieparzystych: {oddNumbers.Count}");