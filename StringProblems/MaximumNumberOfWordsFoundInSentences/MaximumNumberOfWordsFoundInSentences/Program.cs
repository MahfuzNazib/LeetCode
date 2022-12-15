namespace MaximumNumberOfWordsFoundInSentences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentances = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            MostWordsFound(sentances);
        }

        public static int MostWordsFound(string[] sentences)
        {
            int maxWord = 0;
            foreach (string sentence in sentences)
            {
                if(sentence.Split(" ").Length > maxWord)
                {
                    maxWord = sentence.Split(" ").Length;
                }    
            }

            return maxWord;
        }
    }
}