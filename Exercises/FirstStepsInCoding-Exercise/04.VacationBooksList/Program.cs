// 04. Vacation Books List

int numOfPages = int.Parse(Console.ReadLine());
int pagesForHour = int.Parse(Console.ReadLine());
int numOfDays = int.Parse(Console.ReadLine());

int readingTime = numOfPages / pagesForHour;
int neededHours = readingTime / numOfDays;

Console.WriteLine(neededHours);