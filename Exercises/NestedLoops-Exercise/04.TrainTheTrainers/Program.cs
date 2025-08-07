int people = int.Parse(Console.ReadLine());
string presentationName = Console.ReadLine();

double sum = 0;
double sumAll = 0;
double count = 0;

while (presentationName != "Finish")
{
    for (int i = 0; i < people; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        count++;
        sum += grade;
        sumAll += grade;
    }
    Console.WriteLine($"{presentationName} - {(sum / people):f2}.");
    sum = 0;
    presentationName = Console.ReadLine();
}

if (presentationName == "Finish")
{
    Console.WriteLine($"Student's final assessment is {(sumAll / count):f2}.");
}