int badGrades = int.Parse(Console.ReadLine());
int count = 0;
double problems = 0;
double sumGrades = 0;
string lastProblem = "";
bool isFailed = true;

while (count < badGrades)
{
    string name = Console.ReadLine();
    if (name == "Enough")
    {
        isFailed = false;
        break;
    }
    int grade = int.Parse(Console.ReadLine());
    if (grade <= 4)
    {
        count++;
    }
    problems++;
    sumGrades += grade;
    lastProblem = name;
}

if (isFailed)
{
    Console.WriteLine($"You need a break, {badGrades} poor grades.");
}
else
{
    Console.WriteLine($"Average score: {(sumGrades / problems):f2}");
    Console.WriteLine($"Number of problems: {problems}");
    Console.WriteLine($"Last problem: {lastProblem}");
}