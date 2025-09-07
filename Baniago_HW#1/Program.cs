namespace Baniago_HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> originalStrings = new List<string>();
            List<string> reversedStrings = new List<string>();
            List<string> isPalindromeList = new List<string>();
            while (true)
            {
                Console.Write("Enter string: ");
                string input = Console.ReadLine();

                if (input == "*")
                    break;

                string lowerInput = input.ToLower();
                string reversed = ReverseString(lowerInput);
                string result = (lowerInput == reversed) ? "Yes" : "No";

                originalStrings.Add(input);
                reversedStrings.Add(reversed);
                isPalindromeList.Add(result);
            }

            Console.WriteLine("\n\nOriginal String         Reversed String            Palindrome?");
            Console.WriteLine("---------------------------------------------------------------");

            for (int i = 0; i < originalStrings.Count; i++)
            {
                Console.WriteLine($"{originalStrings[i].PadRight(25)}{reversedStrings[i].PadRight(25)}{isPalindromeList[i]}");
            }

            Console.WriteLine("\n//End execution");
        }
        // Method to reverse string manually (no built-in reverse methods)
        static string ReverseString(string input)
        {
            char[] reversed = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[input.Length - 1 - i];
            }

            return new string(reversed);
        }
    }
}
