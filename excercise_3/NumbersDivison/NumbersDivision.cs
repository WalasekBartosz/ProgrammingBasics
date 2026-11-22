Console.Write("Podaj liczbę całkowitą: ");
int number = Convert.ToInt32(Console.ReadLine());

List<int> dividedByThree = [];
List<int> dividedByFive = [];
List<int> dividedByBoth = [];

for (int i = 1; i <= number; i++)
{
    if (i % 3 == 0)
    {
        dividedByThree.Add(i);
        continue;
    }
    else if (i % 5 == 0)
    {
        dividedByFive.Add(i);
        continue;
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        dividedByBoth.Add(i);
        continue;
    }
}

Console.WriteLine($" Podzielne przez 3: {string.Join(" ", dividedByThree)}");
Console.WriteLine($" Podzielne przez 5: {string.Join(" ", dividedByFive)}");
Console.WriteLine($" Podzielne przez 3 i 5: {string.Join(" ", dividedByBoth)}");