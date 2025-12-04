// See https://aka.ms/new-console-template for more information
Console.WriteLine("Palindrome Checker");

Console.Write("Enter a string to check if it's a palindrome: ");
string input = Console.ReadLine();

string reversed = new string(input.Reverse().ToArray());

if (input == reversed)
{
    Console.WriteLine("The string is a palindrome.");
}
else
{
    Console.WriteLine("The string is not a palindrome.");
}
