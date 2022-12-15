namespace ShuffleString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
            RestoreString(s, indices);
        }
        public static void RestoreString(string s, int[] indices)
        {
            string output = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (indices[i] == i)
                {
                    Console.WriteLine("Value : " + indices[i] + " and Index : " + i);
                }
                else
                {
                    continue;
                }

            }
        }

    }
}