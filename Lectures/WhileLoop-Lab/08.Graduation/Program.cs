//string name = Console.ReadLine();
//double grade = double.Parse(Console.ReadLine());
//int year = 1;
//double sum = 0.0;
//int count = 0;

//while (year <= 12)
//{
//    grade = double.Parse(Console.ReadLine());
//	if (grade < 4.00)
//	{
//		count++;
//	}
//	else
//	{
//		sum = sum + grade;
//		year++;
//	}

//	if (count == 2)
//	{
//		Console.WriteLine($"{name} has been excluded at {year} grade");
//		break;
//	}
//}
//Console.WriteLine($"{name} graduated. Average grade: {(sum / 12):f2}");

string name = Console.ReadLine();

int year = 1;
int failures = 0;
double sum = 0;

while (year <= 12 && failures < 2)
{
    double grade = double.Parse(Console.ReadLine());
	if (grade >= 4)
	{
		sum += grade;
		year++;
	}
	else
	{
		failures++;
	}
}

if (failures == 2)
{
    Console.WriteLine($"{name} has been excluded at {year} grade");
}
else
{
    Console.WriteLine($"{name} graduated. Average grade: {(sum / 12):f2}");
}