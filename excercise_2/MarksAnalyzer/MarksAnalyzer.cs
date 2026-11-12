Console.Write("Ile ocen chcesz wprowadzić? ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

int[] arrayOfGrades = new int[numberOfGrades];

for (int i = 1; i <= numberOfGrades; i++)
{
    Console.Write($"Podaj ocenę {i} (1-6): ");
    int grade = Convert.ToInt32(Console.ReadLine());

    arrayOfGrades[i - 1] = grade;
}

double average = arrayOfGrades.Average();
Console.WriteLine($"Średnia ocen wynosi: {average:F2}");

int maxGrade = arrayOfGrades.Max();
Console.WriteLine($"Najwyższa ocena wynosi: {maxGrade}");

int minGrade = arrayOfGrades.Min();
Console.WriteLine($"Najniższa ocena wynosi: {minGrade}");

int PositiveGrades = 0;
foreach (int grade in arrayOfGrades)
{
    if (grade >= 3)
    {
        PositiveGrades++;
    }
}
Console.WriteLine($"Liczba ocen pozytywnych: {PositiveGrades}");