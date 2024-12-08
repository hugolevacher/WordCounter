using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Paste your text below. Press Enter twice (two empty lines) to finish:");

        string input;
        string fullText = string.Empty;
        int emptyLineCount = 0;

        while (true)
        {
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                emptyLineCount++;
                if (emptyLineCount == 2)
                    break;

                fullText += "\n";
                continue;
            }

            emptyLineCount = 0;

            fullText += input + "\n";
        }

        int spaceCount = 0;
        int apostropheCount = 0;

        foreach (char c in fullText)
        {
            if (c == ' ')
                spaceCount++;
            else if (c == '\'')
                apostropheCount++;
        }

        Console.WriteLine("\nThe text contains:");
        Console.WriteLine($"Spaces: {spaceCount}");
        Console.WriteLine($"Apostrophes: {apostropheCount}");
        Console.WriteLine($"Total words: {spaceCount+apostropheCount}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
