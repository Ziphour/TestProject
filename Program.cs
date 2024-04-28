// Goal of this code is to reverese the string and detail how many times the letter "o" 
// appears

string sentenceMessage = "The quick brown fox jumps over the lazy dog.";

char[] letterMessage = sentenceMessage.ToCharArray();
Array.Reverse(letterMessage);

int letterCount = 0;

foreach (char letter in letterMessage)
{
    if (letter == 'o') { letterCount++; }
}


string newMessage = new String(letterMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");