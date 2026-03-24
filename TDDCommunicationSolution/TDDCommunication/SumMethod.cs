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

        

        public int[] indexKiller(int[] numbers)
        {
            Array.Sort(numbers);
            var list = numbers.ToList();
            list.RemoveAt( 0 );
            list.RemoveAt(list.Count - 1);
            int[] input = list.ToArray();
            return input;
        }

        public int SumMethod(int[] input)
        {
            Array.Sort(input);

            if (input.Length < 3)
            {
                return 0;
            }

            if (input.Length == 3)
            {
                
                return input[1];
            }

           return input.Sum();
            
        }
        
        

    }
}
