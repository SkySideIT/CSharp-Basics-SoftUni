// 02. Radians to Degrees

Console.Write("Enter Radian: ");
double radians = double.Parse(Console.ReadLine());
double degrees = radians * (180 / Math.PI);
Console.WriteLine("Radians to Degrees: " + degrees);