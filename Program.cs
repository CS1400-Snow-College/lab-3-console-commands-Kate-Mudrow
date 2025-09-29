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
Console.Clear();

string secretCode = "knot";
int attempts = 0;
string guess;

do
{
    //Console.Clear();
    Console.WriteLine();
    Console.WriteLine($"Guess#: {attempts + 1}  Please guess a sequence of 4 lowercase letters with no repeats.");
    Console.Write("Enter your guess: ");
    guess = Console.ReadLine();
    attempts++;

    int correctLetterAndPosition = 0;
    int correctLetterWrongPosition = 0;

    for (int i = 0; i < secretCode.Length; i++) //correct letter at correct position
    {
        if (guess[i] == secretCode[i])
        {
            correctLetterAndPosition++;
        }
        else if (secretCode.Contains(guess[i])) //correct letter in wrong position
        {
            correctLetterWrongPosition++;
        }
        
    }

    if (guess == secretCode)
    {
        Console.Clear();
        Console.WriteLine($"You guessed the secret code ({secretCode}) in {attempts} guesses!");
    }
    else 
    {
        Console.WriteLine($"Correct Letters in Correct Position: {correctLetterAndPosition}");
        Console.WriteLine($"Correct Letters in Wrong Position: {correctLetterWrongPosition}");  
    }
}
while (guess != secretCode);
