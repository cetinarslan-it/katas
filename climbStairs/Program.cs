namespace Climbstairs;
class Program
{
    public static void Main(string[] args)
    {
        int itiration = 1;

        while (itiration <= 10)
        {

            Console.WriteLine("Please enter the stair number");

            int stairNumber = Int32.Parse(Console.ReadLine());

            if (stairNumber < 1 || stairNumber > 45)
            {
                Console.WriteLine("Please type a number between 1 and 45");
            }

            Console.WriteLine($"The stairs can be climbed up in { ClimbStairs(stairNumber) } way(s).");

            Console.WriteLine($"Number of iteration {itiration++}/10");
        }

    }
    public static int ClimbStairs(int n)
    {
        if (n < 0 || n > 45)
        {
            return -1;
        }
        else if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }
        else
        {
            int previousVariationNumber = 1;
            int currentVariationNumber = 2;
            int totalVariationNumber = 0;

            for (int i = 2; i < n; i++)
            {
                totalVariationNumber = previousVariationNumber + currentVariationNumber;
                previousVariationNumber = currentVariationNumber;
                currentVariationNumber = totalVariationNumber;
            }
            return totalVariationNumber;
        }
    }
}