using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication
{
    public class SumClass
    {

        public int SumMethod(int[] input)
        {
            if (input.Length < 3)
            {
                return 0;
            }

            if (input.Length == 3)
            {
                Array.Sort(input);
                return input[1];
            }

            return int.MaxValue;
        }
        

    }
}
