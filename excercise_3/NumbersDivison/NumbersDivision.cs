Console.Write("Podaj liczbę: ");

if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Podana wartość nie jest liczbą");
    return;
}

List<int> dividedByThree = [];
List<int> dividedByFive = [];
List<int> dividedByBoth = [];

for (int i = 1; i <= number; i++)
{
    bool byThree = i % 3 == 0;
    bool byFive = i % 5 == 0;

    if (byThree)
    {
        dividedByThree.Add(i);
    }

    if (byFive)
    {
        dividedByFive.Add(i);
    }

    if (byThree && byFive)
    {
        dividedByBoth.Add(i);
    }
}

Console.WriteLine($"Podzielne przez 3: {string.Join(" ", dividedByThree)}");
Console.WriteLine($"Podzielne przez 5: {string.Join(" ", dividedByFive)}");
Console.WriteLine($"Podzielne przez 3 i 5: {string.Join(" ", dividedByBoth)}");