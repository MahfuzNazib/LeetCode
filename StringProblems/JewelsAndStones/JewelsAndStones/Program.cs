namespace JewelsAndStones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jewels = "z", stones = "ZZ";
            NumJewelsInStones(jewels, stones);
        }

        public static int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;
            for(int i = 0; i< jewels.Length; i++)
            {
                for(int j = 0; j< stones.Length; j++)
                {
                    if (jewels[i] == stones[j])
                    {
                        count += 1;
                    }
                }
            }

            return count;
        }
    }
}