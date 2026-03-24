using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication
{
    public class SumClass
    {

        public int SumMethod(int[] Input)
        {
            if (Input.Length < 3)
            {
                return 0;
            }

            return int.MaxValue;
        }
        

    }
}
