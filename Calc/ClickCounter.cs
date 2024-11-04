using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class ClickCounter
    {

        private int[,] clickCounts;

        public ClickCounter(int rows, int columns)
        {
            clickCounts = new int[rows, columns];
        }

        public void IncrementCount(int row, int col)
        {
            clickCounts[row, col]++;
        }

        public int GetCount(int row, int col)
        {
            return clickCounts[row, col];
        }
    }
}
