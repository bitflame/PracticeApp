using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //[230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789]
            //542
            int[] myArr = { 3, 2, 4 }; 
            //int[] myArr = { 2, 7, 11, 15 };
             
            foreach (var i in twoSum(myArr, 6))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        private static int [] twoSum (int [] nums, int target)
        {
          int [] result = new int [2];
          if ( nums == null || nums.Length == 0 )
            return result;
          Dictionary<int, int> visited = new Dictionary<int, int>();
          for ( int i = 0; i < nums.Length; i++)
          {
            
             if (visited.ContainsKey(target - nums[i]))
             {
               visited.TryGetValue((target - nums[i]),out int value);
               result[0] = value;
	           result[1] = i;     
             }
             if (visited.ContainsKey(nums[i])) continue;
             else 
             visited.Add(nums[i],i);
          }
          return result;
        }
        //This works also. It is slower and uses the same amount of memory my procedure above uses
        private static int [] twoTum (int [] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i])) // checks if compliment is in dict
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                else if (!dict.ContainsKey(nums[i])) // handles duplicates in array
                {
                    dict.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
