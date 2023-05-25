namespace Solution4;

public class Assigment4
{
    static void Main(string[] args)
    {
        string text = "Programuotojo ar tiesiog bet kokio IT specialisto profesija taps vis labiau įprasta.";

        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'ą', 'ę', 'ė', 'į', 'ų', 'ū' };
        List<char> consonants = new List<char> { 'b', 'c', 'č', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'š', 't', 'v', 'z', 'ž' };

        int vowelCount = 0;
        int consonantCount = 0;

        // Convert the text to lowercase for case-insensitive matching
        text = text.ToLower();

        foreach (char c in text)
        {
            if (vowels.Contains(c))
            {
                vowelCount++;
            }
            else if (consonants.Contains(c))
            {
                consonantCount++;
            }
        }

        Console.WriteLine("Vowel count: " + vowelCount);
        Console.WriteLine("Consonant count: " + consonantCount);
        
    }
}