using System.Text;

namespace MorseCode
{
    internal class Program
    {
        // The characters required according to the assignment
        public static readonly string AllowedCharacters = "abcdefghijklmnopqrstuvwxyzæøóöåäàą1234567890.,:?'\"-/()*@ ";

        // A dictionary for the translation
        public static readonly Dictionary<char, string> MorseCode = new()
        { { 'a', ".- " }, { 'b', "-... " }, { 'c', "-.-. " }, { 'd', "-.. " }, { 'e', ". " }, { 'f', "..-. " }, { 'g', "--. " },
        { 'h', ".... " }, { 'i', ".. " }, { 'j', ".--- " }, { 'k', "-.- " }, { 'l', ".-.. " }, { 'n', "-. " }, { 'm', "-- " },
        { 'o', "--- " }, { 'p', ".--. " }, { 'q', "--.- " }, { 'r', ".-. " }, { 's', "... " }, { 't', "- " }, { 'u', "..- " },
        { 'v', "...- " }, { 'w', ".-- " }, { 'x', "-..- " }, { 'y', "-.-- " }, { 'z', "--.. " }, { 'æ', ".-.- " }, { 'ä', ".-.- " },
        { 'ą', ".-.- " }, { 'ø', "---. " }, { 'ó', "---. " }, { 'ö', "---. " }, { 'å', ".--.- " }, { 'à', ".--.- " },
        { '1', ".---- " }, { '2', "..--- " }, { '3', "...-- " }, { '4', "....- " }, { '5', "..... " }, { '6', "-.... " },
        { '7', "--... " }, { '8', "---.. " }, { '9', "----. " }, { '0', "----- " }, { '.', ".-.-.- " }, { ',', "--..-- " },
        { ':', "---... " }, { '?', "..--.. " }, { '\'', ".----. " }, { '-', "-....- " }, { '/', "-..-. " }, { '(', "-.--. " },
        { ')', "-.--.- " }, { '"', ".-..-. " }, { ' ', "/ " }, { '*', "-..- " }, { '@', ".--.-. " },};

        static void Main()
        {
            // Awaiting input
            Console.Clear();
            Console.Write("Skriv noget tekst som skal konverteres til morsekode: ");
            char[] Input = Console.ReadLine()!.ToCharArray();

            // String builder for concatenating output
            StringBuilder sb = new();

            // Iterating over each character in input, checking if is in "AllowedCharacters", then appending value of key (the morse code)
            foreach (char c in Input)
            {
                char lowerc = char.ToLower(c);
                if (IsAllowed(lowerc))
                {
                    if (MorseCode.ContainsKey(lowerc))
                    {
                        sb.Append(MorseCode[lowerc]);
                    }
                }
                // Else if character was not in AllowedCharacters inform allowed characters
                else
                {
                    Console.Clear(); Console.WriteLine($"Tilladte tegn: {AllowedCharacters}");
                    Console.ReadKey();
                    Main();
                }
            }

            // Providing translation
            Console.WriteLine($"Det indtastede tekst i morsekode er: \n{sb}");
            Console.ReadKey();
            Main();
        }

        private static bool IsAllowed(char c) 
        {
            if (!AllowedCharacters.Contains(c))
            {
                return false;
            }
            return true;
        }
    }
}