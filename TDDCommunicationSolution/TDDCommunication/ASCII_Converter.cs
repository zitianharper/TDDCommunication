using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication
{
    public class ASCII_Converter
    {
        string input = "no";
        public string[] Splitter(string input)
        {
            string[] splitChars = input.Split("");
            string [] letters = splitChars.ToArray();
            return letters;
        }


        public int ASCII_ConverterMethod(string[] letters)
        {
            int output = (int)'a';

            return output;

        }

    }
}
