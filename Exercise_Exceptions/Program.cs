
WriteLine("Enter a number between 0 and 255: ");
string? firstNum = ReadLine();

WriteLine("Enter another number between 0 and 255: ");
string? secondNum = ReadLine();

try
{
    byte inputOne = byte.Parse(firstNum!);
    byte inputTwo = byte.Parse(secondNum!);

    WriteLine($"{inputOne} divided by {inputTwo} is {inputOne / inputTwo}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}
