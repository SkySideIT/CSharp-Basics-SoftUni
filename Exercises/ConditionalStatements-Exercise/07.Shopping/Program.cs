double budget = double.Parse(Console.ReadLine());
int numGPUs = int.Parse(Console.ReadLine());
int numCPUs  = int.Parse(Console.ReadLine());
int numRAMs =  int.Parse(Console.ReadLine());

double gpuCost = numGPUs * 250;
double cpuCost = numCPUs * (gpuCost * 0.35);
double ramCost = numRAMs * (gpuCost * 0.10);

double allInAll = 0.0;
if (numGPUs > numCPUs)
{
    allInAll = (gpuCost + cpuCost + ramCost) * 0.85;
}
else
{
    allInAll = gpuCost + cpuCost + ramCost;
}

if (budget < allInAll)
{
    double needed = allInAll - budget;
    Console.WriteLine($"Not enough money! You need {needed:f2} leva more!");
}
else
{
    double left = budget - allInAll;
    Console.WriteLine($"You have {left:f2} leva left!");
}