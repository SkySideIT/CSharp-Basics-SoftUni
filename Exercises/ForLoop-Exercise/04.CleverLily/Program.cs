int age = int.Parse(Console.ReadLine());
double washerPrice =  double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

double sum = 0;
double giftedMoney = 10;
int countToys = 0;
for (int i = 1; i <= age; i++)
{
	if (i % 2 == 0)
	{
		sum += giftedMoney;
		giftedMoney += 10;
	}
	else
	{
		countToys++;
	}
}

int moneyLeftFromGifted = (age / 2) * 1;
int moneyFromToys = countToys * toyPrice;
sum = sum + moneyFromToys - moneyLeftFromGifted;
if (sum >= washerPrice)
{
    Console.WriteLine($"Yes! {sum - washerPrice:f2}");
}
else
{
    Console.WriteLine($"No! {washerPrice - sum:f2}");
}