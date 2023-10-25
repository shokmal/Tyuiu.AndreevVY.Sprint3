using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndreevVY.Sprint3.Task5.V4.Lib
{
    public class DataService : ISprint3Task5V4
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int j, k;
            for (j = startValue1; j <= stopValue1; j++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries = sumSeries + (x / Math.Cos(k));
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
