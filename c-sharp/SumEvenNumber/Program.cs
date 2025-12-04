// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sum Even Numbers 1-100");
int sum = 0;    

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}
Console.WriteLine($"Sum of even numbers from 1 to 100 is: {sum}");