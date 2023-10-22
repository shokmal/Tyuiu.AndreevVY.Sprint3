using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndreevVY.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries = multSeries * (Math.Sin(startValue) * 1 / 2);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
