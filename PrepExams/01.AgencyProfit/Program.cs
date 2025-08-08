string companyName = Console.ReadLine();
int adultTickectCount = int.Parse(Console.ReadLine());
int childTickectCount = int.Parse(Console.ReadLine());
double adultTicketPrice = double.Parse(Console.ReadLine());
double serviceFee = double.Parse(Console.ReadLine());

double childTickedPrice = 0.30 * adultTicketPrice;
double totalPrice = (adultTickectCount * (adultTicketPrice + serviceFee)) + (childTickectCount * (childTickedPrice + serviceFee));
double agencyProfit = totalPrice * 0.20;

Console.WriteLine($"The profit of your agency from {companyName} tickets is {agencyProfit:f2} lv.");