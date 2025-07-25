int degrees = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();
string outfit = "";
string shoes = "";

if (degrees >= 10 && degrees <= 18)
{
    //if (timeOfDay == "Morning")
    //{
    //    outfit = "Sweatshirt";
    //    shoes = "Sneakers";
    //}
    //else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
    //{
    //    outfit = "Shirt";
    //    shoes = "Moccasins";
    //}

    switch (timeOfDay)
    {
        case "Morning":
            outfit = "Sweatshirt";
            shoes = "Sneakers";
            break;
        case "Afternoon":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        default:
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
else if (degrees > 18 && degrees <= 24)
{
    //if (timeOfDay == "Morning" || timeOfDay == "Evening")
    //{
    //    outfit = "Shirt";
    //    shoes = "Moccasins";
    //}
    //else if (timeOfDay == "Afternoon")
    //{
    //    outfit = "T-Shirt";
    //    shoes = "Sandals";
    //}

    switch (timeOfDay)
    {
        case "Morning":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case "Afternoon":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        default:
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
else if (degrees > 24 && degrees <= 42)
{
    //if (timeOfDay == "Morning")
    //{
    //    outfit = "T-Shirt";
    //    shoes = "Sandals";
    //}
    //else if (timeOfDay == "Afternoon")
    //{
    //    outfit = "Swim Suit";
    //    shoes = "Barefoot";
    //}
    //else if (timeOfDay == "Evening")
    //{
    //    outfit = "Shirt";
    //    shoes = "Moccasins";
    //}

    switch (timeOfDay)
    {
        case "Morning":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Afternoon":
            outfit = "Swim Suit";
            shoes = "Barefoot";
            break;
        default:
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");