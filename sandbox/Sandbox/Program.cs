// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string intro = "Hello";
//         Console.WriteLine(intro.ToUpper());
//         //Console.WriteLine(intro.);
//         //Console.WriteLine("Hello Sandbox World!");
//     }
// }

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// This program takes a user's journal entry and writes it into
/// a beautiful ASCII art book.
/// </summary>
public class AsciiJournal
{
    // --- Configuration Constants ---

    // The exact width, in characters, of a single page's content area.
    // Based on counting the spaces: "||||                   |"
    private const int PageWidth = 19;

    // The number of writable lines on each page.
    // Based on the template below (lines at index 2 through 11).
    private const int PageHeight = 10;

    /// <summary>
    /// This is the "template" for the book.
    /// The page areas (lines 3-12, or index 2-11) are left blank
    /// so we can insert our text there.
    /// </summary>
    private static readonly List<string> BookTemplate = new List<string>
    {
        @"    __________________   __________________",
        @".-/|                   \ /                   |\-.",
        @"||||                   |                   ||||", // Index 2
        @"||||                   |                   ||||", // Index 3
        @"||||                   |                   ||||", // Index 4
        @"||||                   |                   ||||", // Index 5
        @"||||                   |                   ||||", // Index 6
        @"||||                   |                   ||||", // Index 7
        @"||||                   |                   ||||", // Index 8
        @"||||                   |                   ||||", // Index 9
        @"||||                   |                   ||||", // Index 10
        @"||||                   |                   ||||", // Index 11
        @"||||__________________ | __________________||||",
        @"||/===================\|/===================\||",
        @"`--------------------~___~-------------------''"
    };

    /// <summary>
    /// Main entry point for the program.
    /// </summary>
    public static void Main()
    {
        // 1. Get the user's message
        string message = GetJournalEntry();

        // 2. Process the message into formatted lines
        List<string> formattedLines = WordWrap(message, PageWidth);

        // 3. Populate the pages
        // We get two lists of strings, one for each page.
        var (leftPage, rightPage) = PopulatePages(formattedLines);

        // 4. Build the final book string
        string finalBook = BuildBook(leftPage, rightPage);

        // 5. Display the result
        Console.Clear();
        Console.WriteLine("Here is your journal entry:");
        Console.WriteLine(finalBook);
        Console.ReadLine();
    }

    /// <summary>
    /// Prompts the user for a multi-line journal entry.
    /// </summary>
    /// <returns>The complete entry as a single string.</returns>
    private static string GetJournalEntry()
    {
        Console.WriteLine("Write your journal entry (press Enter on an empty line to finish):");
        var messageLines = new List<string>();
        while (true)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
            {
                break;
            }
            messageLines.Add(line);
        }
        // Join all lines with spaces to treat it as one continuous text block
        return string.Join(" ", messageLines);
    }

    /// <summary>
    /// Takes a long string of text and wraps it into a list of lines
    /// that do not exceed the specified maximum width.
    /// </summary>
    /// <param name="text">The text to wrap.</param>
    /// <param name="maxWidth">The maximum width for a line.</param>
    /// <returns>A list of wrapped lines.</returns>
    private static List<string> WordWrap(string text, int maxWidth)
    {
        var lines = new List<string>();
        if (string.IsNullOrEmpty(text))
        {
            return lines;
        }

        string[] allWords = text.Split(' ');
        var lineBuilder = new StringBuilder();

        foreach (string word in allWords)
        {
            // If a single word is longer than the line, we have to break it.
            if (word.Length > maxWidth)
            {
                // Add any text we had before this long word
                if (lineBuilder.Length > 0)
                {
                    lines.Add(lineBuilder.ToString());
                    lineBuilder.Clear();
                }
                // Add the long word, broken into chunks
                for(int i = 0; i < word.Length; i += maxWidth)
                {
                    lines.Add(word.Substring(i, Math.Min(maxWidth, word.Length - i)));
                }
            }
            // If the word fits on the current line
            else if (lineBuilder.Length == 0)
            {
                lineBuilder.Append(word);
            }
            else if (lineBuilder.Length + 1 + word.Length <= maxWidth)
            {
                lineBuilder.Append(" " + word);
            }
            // If the word does *not* fit, start a new line
            else
            {
                lines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
                lineBuilder.Append(word);
            }
        }

        if (lineBuilder.Length > 0)
        {
            lines.Add(lineBuilder.ToString());
        }

        return lines;
    }

    /// <summary>
    /// Distributes the formatted lines onto the left and right pages.
    /// </summary>
    /// <param name="formattedLines">The list of lines from WordWrap.</param>
    /// <returns>A tuple containing two lists: left page lines and right page lines.</returns>
    private static (List<string> Left, List<string> Right) PopulatePages(List<string> formattedLines)
    {
        var leftPage = new List<string>();
        var rightPage = new List<string>();
        string emptyLine = new string(' ', PageWidth);

        for (int i = 0; i < PageHeight; i++)
        {
            // Add to left page
            if (i < formattedLines.Count)
            {
                leftPage.Add(formattedLines[i].PadRight(PageWidth));
            }
            else
            {
                leftPage.Add(emptyLine);
            }

            // Add to right page (lines 10-19)
            int rightIndex = i + PageHeight;
            if (rightIndex < formattedLines.Count)
            {
                rightPage.Add(formattedLines[rightIndex].PadRight(PageWidth));
            }
            else
            {
                rightPage.Add(emptyLine);
            }
        }

        // Handle truncation if the text is too long (more than 20 lines)
        if (formattedLines.Count > PageHeight * 2)
        {
            // Overwrite the last line of the right page with "..."
            string lastLine = rightPage[PageHeight - 1];
            rightPage[PageHeight - 1] = lastLine.Substring(0, PageWidth - 3) + "...";
        }

        return (leftPage, rightPage);
    }

    /// <summary>
    /// Injects the page content into the book template and returns the final string.
    /// </summary>
    /// <param name="leftPage">The list of 10 lines for the left page.</param>
    /// <param name="rightPage">The list of 10 lines for the right page.</param>
    /// <returns>The complete ASCII book as a single string.</returns>
    private static string BuildBook(List<string> leftPage, List<string> rightPage)
    {
        // Create a copy of the template to avoid modifying the original
        var finalBookLines = new List<string>(BookTemplate);

        // Loop from 0 to 9 (for the 10 writable lines)
        for (int i = 0; i < PageHeight; i++)
        {
            // The writable lines in the template start at index 2
            int templateLineIndex = i + 2;

            // Reconstruct the line with our text
            string newLine = $"||||{leftPage[i]}|{rightPage[i]}||||";

            // Replace the template's blank line with our new line
            finalBookLines[templateLineIndex] = newLine;
        }

        // Join all lines into a single string with newlines
        return string.Join(Environment.NewLine, finalBookLines);
    }
}
