using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    internal class DesignOrderedStream
    {
        public string[] stream;
        public int ptr;

        public DesignOrderedStream(int n)
        {
            stream = new String[n];
            ptr = 0;
        }

        public IList<string> Insert(int idKey, string value)
        {

            stream[idKey - 1] = value;

            List<string> chunk = new List<string>() { };

            while (ptr < stream.Count() && stream[ptr] != null)
            {
                chunk.Add(stream[ptr]);
                ptr++;
            }
            return chunk;

        }
    }
}
