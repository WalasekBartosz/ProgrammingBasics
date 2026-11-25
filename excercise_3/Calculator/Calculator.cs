Console.Write("Podaj pierwszą liczbę: ");
if (!double.TryParse(Console.ReadLine(), out double firstNumber))
{
    Console.WriteLine("Podana wartość nie jest poprawną liczbą.");
    return;
}

Console.Write("Podaj drugą liczbę: ");
if (!double.TryParse(Console.ReadLine(), out double secondNumber))
{
    Console.WriteLine("Podana wartość nie jest poprawną liczbą.");
    return;
}

while (true)
{
    Console.WriteLine("\n1 - Dodawanie");
    Console.WriteLine("2 - Odejmowanie");
    Console.WriteLine("3 - Mnożenie");
    Console.WriteLine("4 - Dzielenie");

    Console.Write("Wybierz operację: ");
    string? choice = Console.ReadLine();

    double result;

    switch (choice)
    {
        case "1":
            result = firstNumber + secondNumber;
            break;
        case "2":
            result = firstNumber - secondNumber;
            break;
        case "3":
            result = firstNumber * secondNumber;
            break;
        case "4":
            if (secondNumber == 0)
            {
                Console.WriteLine("Nie można dzielić przez zero!");
                continue;
            }
            result = firstNumber / secondNumber;
            break;
        default:
            Console.WriteLine("Nieprawidłowy wybór operacji.");
            continue;
    }

    Console.WriteLine($"Wynik: {result}");
    break;
}