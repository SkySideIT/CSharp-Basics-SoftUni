// 03. Deposit Calculator

double depositSum = double.Parse(Console.ReadLine());
int termofDeposit = int.Parse(Console.ReadLine());
double annualPercentage = double.Parse(Console.ReadLine());

double sum = depositSum + termofDeposit * ((depositSum * (annualPercentage/100)) / 12);

Console.WriteLine(sum);