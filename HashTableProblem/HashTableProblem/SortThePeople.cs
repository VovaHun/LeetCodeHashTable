using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    internal class SortThePeople
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            Dictionary<int,string> valuePairs = new Dictionary<int,string>();
            for(int i=0; i<names.Length; i++)
            {
                valuePairs.Add(heights[i], names[i]);
            }

            var dict = valuePairs.OrderByDescending(pair => pair.Key).ToDictionary(obj => obj.Key, obj => obj.Value);

            string[] res = dict.Values.ToArray();

            

            return res;
        }
    }
}
