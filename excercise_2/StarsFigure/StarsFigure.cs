Console.Write("Podaj wysokość trójkąta: ");
int height = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}