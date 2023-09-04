namespace SplitStringInBalancedString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "LLLLRRRR";
            FindBalancedString(s);
        }

        public static int FindBalancedString(string inputString)
        {
            int totalCount = 0;
            int tempCountOfR = 0;
            int tempCountOfL = 0;

            for(int i = 0; i< inputString.Length; i++)
            {
                if (inputString[i] == 'R')
                {
                    tempCountOfR++;
                }
                else
                {
                    tempCountOfL++;
                }

                if(tempCountOfR == tempCountOfL)
                {
                    totalCount++;
                    tempCountOfL = 0; tempCountOfR = 0;
                }
            }

            return totalCount;
        }
    }
}