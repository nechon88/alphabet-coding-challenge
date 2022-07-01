using AlphabetCodingChallengeApp;

string welcomeMessage = @"Alphabet Coding Challenge
Enter a string up to 256 characters long and press enter.
This application will print a string of the letters in the english
alphabet that were not contained in the input, and the size of that output.";

Console.WriteLine(welcomeMessage);

while (true)
{
    string? userInput = Console.ReadLine();
    if (!AlphabetUtility.ValidateInput(userInput, out string error))
    {
        Console.WriteLine($"Error: {error}");
        continue;
    }
    string output = AlphabetUtility.Parse(userInput);
    Console.WriteLine($"Output: {output}");
    Console.WriteLine($"Output Size: {output.Length}");
}