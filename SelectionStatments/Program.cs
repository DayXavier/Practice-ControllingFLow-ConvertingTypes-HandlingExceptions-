using System.Security.Principal;

string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 chars.");
}
else
{
    WriteLine("Your password is strong.");
}

#region Pattern matching with the if statment

Console.WriteLine();

// Add and remove the "" to change between string and int
object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

#endregion

#region Branching with the switch statment

// Inclusive lower bound but exclusive upper bound.
int number = Random.Shared.Next(minValue:1, maxValue:7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break; // jumps to end of switch statment.
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // Multiple case section.
    case 4:
        WriteLine("Three or 4");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // End of switch statment.
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

Console.WriteLine();

var animals = new Animal?[]
{
    new Cat { Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic = true },
    null,
    new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12 )},
    new Spider { Name = "Sid Vicious", Born = DateTime.Today, IsVenomous = true },
    new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;
        case Cat willdCat when willdCat.IsDomestic == false:
            message = $"The non-domestic cat is named {willdCat.Name}.";
            break;
        case Cat cat:
            message = $"The car is named {cat.Name}";
            break;
        default: // default is alwasy evaluated last.
            message = $"{animal.Name} is a {animal.GetType().Name}";
            break;
        case Spider spider when spider.IsVenomous:
            message = $"The {spider.Name} spider is venomous. Run!";
            break;
        case null:
            message = "The animal is null";
            break;
    }
    WriteLine($"Switch statment: {message}");
}

#endregion

#region Simplifying switch statments with switch expressions
Console.WriteLine();

foreach (Animal? animal in animals)
{
    string message;

    message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4
          => $"The cat name {fourLeggedCat.Name} has four legs.",
        Cat wildCat when wildCat.IsDomestic == false
          => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat
          => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsVenomous
          => $"The {spider.Name} spider is venomous. Run!",
        null
          => "The animal is null",
        _
         => $"{animal.Name} is a {animal.GetType().Name}."
    };
    WriteLine($"Switch statment: {message}");
}

#endregion

