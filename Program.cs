/*Name: Kate Mudrow
Date:
Lab: Lab 5 Mastermind*/

Console.Clear();

string welcome = @"
Welcome to the game Mastermind!
I have set a secret code with 4 letters between
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
    Console.WriteLine($"Guess#: {attempts + 1}  Please guess a sequence of 4 lowercase letters with no repeats.");
    Console.Write("Enter your guess: ");
    guess = Console.ReadLine();

    attempts++;
}
while (guess != secretCode);
Console.WriteLine($"You guessed the secret code ({secretCode}) in {attempts} guesses!");
