namespace GoalParserInterpretation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commands = "(al)G(al)()()G";
            Interpret(commands);
        }

        public static void Interpret(string commands)
        {
            string output = "";
            for(int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'G')
                {
                    output += "G";
                }
                else if (commands[i] == '(' && commands[i+1] == ')')
                {
                    output += "o";
                }
                else if (commands[i] == '(' && commands[i+1] == 'a' && commands[i+2] == 'l' && commands[i+3] == ')' )
                {
                    output+= "al";
                }
            }

            Console.WriteLine(output);
        }
    }
}