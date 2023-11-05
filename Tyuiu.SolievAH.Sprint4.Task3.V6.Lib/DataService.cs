using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.SolievAH.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[1, i] > max)
                {
                    max = array[1, i];
                }
            }
            return max;
        }
    }
}
