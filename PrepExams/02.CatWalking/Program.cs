int minutesWalk = int.Parse(Console.ReadLine());
int numberOfWalks = int.Parse(Console.ReadLine());
int calories = int.Parse(Console.ReadLine());

int totalMinutesWalk = minutesWalk * numberOfWalks;
int totalCaloriesBurned =  5 * totalMinutesWalk;
int halfCalories =  calories / 2;

bool isEnough = totalCaloriesBurned * 2 >= calories;

if (isEnough)
{
    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurned}.");
}
else
{
    Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurned}.");
}