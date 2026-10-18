string name = "";
int firstGrade = 0; int secondGrade = 0; int thirdGrade = 0;

Console.Write("Podaj swoje imię: ");
name = Console.ReadLine();   

Console.Write("Podaj pierwszą ocenę (1-6): ");
firstGrade = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj drugą ocenę (1-6): ");
secondGrade = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj trzecią ocenę (1-6): ");
thirdGrade = Convert.ToInt32(Console.ReadLine());

double average = (firstGrade + secondGrade + thirdGrade) / 3.0;

if (average >= 3.0) 
{
    Console.WriteLine($"Witaj {name}, zaliczone!! - Twoja średnia ocen wynosi {average:F1}");
} else
{
    Console.WriteLine($"Witaj {name}, niezaliczone!! - Twoja średnia ocen wynosi {average:F1}");
}