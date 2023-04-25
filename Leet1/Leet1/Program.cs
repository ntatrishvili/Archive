using System;

namespace Leet1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
            int[] sum =TwoSum([2, 7, 14, 29],9);
            string text = Console.ReadLine();
            Console.WriteLine(text);
            
        }
        public int[] TwoSum(int[] nums, int target)
        {
            int[] returnValue = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i < j && (i + j) == target)
                    {
                        returnValue[0] = i;
                        returnValue[1] = j;
                    }
                }
            }
            return returnValue;
        }
    }
}
