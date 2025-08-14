double kgPacket = double.Parse(Console.ReadLine());
string typeService = Console.ReadLine();
int km = int.Parse(Console.ReadLine());

double totalPrice = 0;
double up = 0;

if (typeService == "standard")
{
    if (kgPacket < 1)
    {
        totalPrice = 0.03 * km;
    }
    else if (kgPacket >= 1 && kgPacket < 10)
    {
        totalPrice = 0.05 * km;
    }
    else if (kgPacket >= 10 && kgPacket < 40)
    {
        totalPrice = 0.10 * km;
    }
    else if (kgPacket >= 40 && kgPacket < 90)
    {
        totalPrice = 0.15 * km;
    }
    else if (kgPacket >= 90 && kgPacket < 150)
    {
        totalPrice = 0.20 * km;
    }
}
else
{
    if (kgPacket < 1)
    {
        totalPrice = (km * (kgPacket * (0.80 * 0.03))) + (km * 0.03);
    }
    else if (kgPacket >= 1 && kgPacket < 10)
    {
        totalPrice = (km * (kgPacket * (0.40 * 0.05))) + (km * 0.05);
    }
    else if (kgPacket >= 10 && kgPacket < 40)
    {
        totalPrice = (km * (kgPacket * (0.05 * 0.10))) + (km * 0.10);
    }
    else if (kgPacket >= 40 && kgPacket < 90)
    {
        totalPrice = (km * (kgPacket * (0.02 * 0.15))) + (km * 0.15);
    }
    else if (kgPacket >= 90 && kgPacket < 150)
    {
        totalPrice = (km * (kgPacket * (0.01 * 0.20))) + (km * 0.20);
    }
}

Console.WriteLine($"The delivery of your shipment with weight of {kgPacket:f3} kg. would cost {totalPrice:f2} lv.");