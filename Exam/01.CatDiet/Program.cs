double fats = double.Parse(Console.ReadLine());
double proteins = double.Parse(Console.ReadLine());
double carbohydrates = double.Parse(Console.ReadLine());
double totalCalories = double.Parse(Console.ReadLine());
double water = double.Parse(Console.ReadLine());

double totalFatGrams = (totalCalories * (fats / 100)) / 9;
double totalProteinGrams = (totalCalories * (proteins / 100)) / 4;
double totalCarboGrams = (totalCalories * (carbohydrates / 100)) / 4;

double foodWeight = totalCarboGrams + totalFatGrams + totalProteinGrams;
double caloriesPerGram = totalCalories / foodWeight;
double realCalories = ((100 - water) / 100) * caloriesPerGram;
Console.WriteLine($"{realCalories:f4}");