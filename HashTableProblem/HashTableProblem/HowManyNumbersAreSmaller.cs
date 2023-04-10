using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    internal class HowManyNumbersAreSmaller
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] mas = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = nums.Length-1; j >= 0; j--)
                {
                    if (nums[i] > nums[j])
                    {
                        count++;
                    }
                }
                mas[i] = count;
            }

            return mas;
        }

        //Solution from internet

        //int[] copy = new int[nums.Length];
        //for(int i=0; i<nums.Length; i++)
        //    copy[i] = nums.Where(x => x<nums[i]).Count(); 
        //return copy;
    }
}
