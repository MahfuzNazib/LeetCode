namespace CountItemMatchingRule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> items = new List<List<string>>
            {
                new List<string> {"phone","blue","pixel"},
                new List<string> { "computer", "silver", "phone" },
                new List<string> { "phone", "gold", "iphone" }
            };

            string ruleKey = "type";
            string ruleValue = "phone";
            int count = 0;
            
            for(int i = 0; i< items.Count; i++)
            {
                if(ruleKey == "type")
                {
                    if(ruleValue == items[i][0])
                    {
                        count++;
                    }
                }

                if (ruleKey == "color")
                {
                    if (ruleValue == items[i][1])
                    {
                        count++;
                    }
                }

                if (ruleKey == "name")
                {
                    if (ruleValue == items[i][2])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        
    }
}