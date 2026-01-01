
using System.ComponentModel.Design;

int count = 100; 

for (int i = 1; i <= count; i++)
{
    if (i % 15 == 0)
    {
        Write("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Write("Buzz");
    }
    else if (i % 3 == 0)
    {
        Write("Fizz");
    }
    else
    {
        Write($"{i}");
    }

    if (i < 100) Write(", ");

    if (i % 10 == 0) WriteLine();
}
WriteLine();
