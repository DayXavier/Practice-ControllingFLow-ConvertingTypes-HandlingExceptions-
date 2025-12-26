
#region Looping with the while statment

int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

#endregion

#region Looping with the do statment 
Console.WriteLine();

//string? actualPassword = "Pa$$W0rd";
//string? password;
//int count = 0;

//do
//{
//    Write("Enter your password: ");
//    password = ReadLine();

//    count++;

//    if (count == 3)
//    {
//        break;
//    }
//}
//while (password != actualPassword);

//string output = (count == 3 && password != actualPassword) ? "Wrong password" : "Correct";

//WriteLine(output);

#endregion

#region Looping with the for statment

for (int y = 1; y <= 10; y++)
{
    Write(y);
}

Console.WriteLine();

for (int Y = 0; Y <= 10; Y += 3)
{
    Write(Y);
}

Console.WriteLine();

for (int Y = 10; Y >= 0; Y -= 2)
{
    Write($"\t{Y}");
}

#endregion

#region Looping with the foreach statment
Console.WriteLine();  


string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"\n{name} has {name.Length} characters.");
}

#endregion