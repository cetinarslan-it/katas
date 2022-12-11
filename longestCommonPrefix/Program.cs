namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(LongestCommonPrefix(new string[]{"fower","flo","flowight"}));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
           
            string result = strs[0];

        
            for (int i = 1; i < strs.Length; i++)
            {
   
                int j = 0;
                while (j < result.Length && j < strs[i].Length && result[j] == strs[i][j])
                {
                    j++;
                }
       
                result = result.Substring(0, j);
           
                if (result == "")
                {
                    return "";
                }
            }

            return result;
        }
    }
}


