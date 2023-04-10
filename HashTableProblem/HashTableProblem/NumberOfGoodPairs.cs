using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    internal class NumberOfGoodPairs
    {
        //if the array contains nums[i], then it increases mas[nums[i]] by one and increases res 

        public int NumIdenticalPairs(int[] nums)
        {
            int[] mas = new int[101];
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res += mas[nums[i]];
                ++mas[nums[i]];
            }
            return res;



            
        }
    }
}
