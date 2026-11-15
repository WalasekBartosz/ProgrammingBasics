Console.Write("Ile ocen chcesz wprowadzić? ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

List<int> grades = [];

for (int i = 1; i <= numberOfGrades; i++)
{
    Console.Write($"Podaj ocenę {i} (1-6): ");
    int grade = Convert.ToInt32(Console.ReadLine());

    grades.Add(grade);
}

double average = grades.Average();
Console.WriteLine($"Średnia ocen wynosi: {average:F2}");

int maxGrade = grades.Max();
Console.WriteLine($"Najwyższa ocena wynosi: {maxGrade}");

int minGrade = grades.Min();
Console.WriteLine($"Najniższa ocena wynosi: {minGrade}");

int positiveGrades = 0;
grades.ForEach(grade => {
    if (grade >= 3)
    {
        positiveGrades++;
    }
});
   
Console.WriteLine($"Liczba ocen pozytywnych: {positiveGrades}");