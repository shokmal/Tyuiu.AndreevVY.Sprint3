using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndreevVY.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] VauleArray;
            int len = (stopValue - startValue) + 1;
            VauleArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 1)
                {
                    y = Math.Round(4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2)), 2);
                    VauleArray[count] = y;
                    count++;
                }
                else
                {
                    VauleArray[count] = 0;
                    count++;
                }

            }
            return VauleArray;
        }
    }
}
