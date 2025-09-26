/*Name: Kate Mudrow
Date:
Lab: Lab 5 Mastermind*/

Console.Clear();

string welcome = @"
Welcome to the game Mastermind!
I have set a secret code with4 letters between
'k' and 't'and they are arranged in a specific order. 
Your job is to guess which letters and put them in the right order.

Ready? Press any key to continue:";

Console.WriteLine($"{welcome}");
Console.ReadKey(true);

string secretCode = "knot";
int attempts = 0;
string guess;

do
{
    Console.Clear();
    Console.Write("Enter your guess: ");
    guess = Console.ReadLine();

}
while (guess != secretCode);
