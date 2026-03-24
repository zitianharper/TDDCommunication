using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication
{
    public class Mean
    {
        public double MeanMethod(int[] numbers)
        {
            double output = numbers.Average();
            return output;

        }

    }
}
