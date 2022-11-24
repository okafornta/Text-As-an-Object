/* TASK: 
 *  You will create a program that displays a number of characters of text, converts the text
    into uppercase, and checks whether the text contains a specific word
 */

// Some text to try things on 
string text = "My name is Hillary Chinemerem Okafornta, born on 9th sept 1992";

// What e.g. can be done with texts
Console.WriteLine("This is the origianl writeup - " + text);
Console.WriteLine("Number of characters - " + text.Length);
Console.WriteLine("Converting all the characters to uppercase - " + text.ToUpper());
Console.WriteLine("Does it contain word \"Hillary\"? " + text.
Contains("Hillary"));
Console.WriteLine("Does it contain word \"Come\"? " + text.
Contains("Come"));

// Waiting for Enter
Console.ReadLine();


/* DISCUSSION:
 * 
 *  Data members (for example, Length) are not accompanied by parentheses, contrary to
    methods (such as ToUpper, Contains), which always need parentheses even if there is
    nothing between them.
    How can you quickly find out whether something is a method (and therefore will
    need parentheses)? You can do this either by looking at the violet cube in IntelliSense or
    looking for parentheses in the tooltip
 */