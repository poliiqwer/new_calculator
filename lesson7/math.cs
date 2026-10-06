using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7
{
    internal class math
    {
        public double sum(double[] array)
        {
            double result = 0.0;
            foreach (double number in array)
            {
                result += number;
            }
            return result;
        }

        //public double count(double[] array)
        //{

        }
    }
//}