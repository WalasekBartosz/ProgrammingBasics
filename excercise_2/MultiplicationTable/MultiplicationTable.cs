Console.Write("Podaj swoją liczbę: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i=1; i <= number; i++)
{
    int result = number*i;
    Console.WriteLine($"{number} x {i} = {result}");
}