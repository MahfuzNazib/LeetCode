namespace ReversePrefixOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "abcdefd";
            char ch = 'd';
            string t = ReversePrefix(word, ch);
            Console.WriteLine(t);
        }

        public static string ReversePrefix(string word, char ch)
        {
            int firstCharacterIndexNo = 0;

            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    firstCharacterIndexNo = i+1;
                    break;
                }
            }

            string[] result = SplitedStringAtIndex(word, firstCharacterIndexNo);

            char[] charArray = result[0].ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray) + result[1];
        }

        public static string[] SplitedStringAtIndex(string word, int indexNumber)
        {
            string part1 = word.Substring(0, indexNumber);
            string part2 = word.Substring(indexNumber);

            return new string[] { part1, part2 }; 
        }
    }
}