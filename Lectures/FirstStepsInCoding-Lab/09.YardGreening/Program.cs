// 09. Yard Greening

double area = double.Parse(Console.ReadLine());
double price = (area * 7.61) * 0.82;
double discount = (area * 7.61) * 0.18;

Console.WriteLine($"The final price is: {price}");
Console.WriteLine($"The discount is: {discount}");