using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public class ListViewItemComparer : IComparer
    {
        private readonly int col;
        private static int colOrder;
        private static short order = 1;

        private readonly int col2;
        private static int colOrder2;
        private static short order2 = 1;

        public ListViewItemComparer()
        {
            col = 0;
            colOrder = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
            if (col == colOrder)
            {
                order *= -1;
            }
            else { colOrder = col; order = 1; }
        }
        public ListViewItemComparer(int column1, int column2)
        {
            col = column1;
            if (col == colOrder)
            {
                order *= -1;
            }
            else { colOrder = col; order = 1; }

            col2 = column2;
            if (col2 == colOrder2)
            {
                order2 *= -1;
            }
            else { colOrder2 = col2; order2 = 1; }
        }

        public int CompareOne(object x, object y, int colToCompare, int orderToUse)
        {
            double.TryParse(((ListViewItem)x).SubItems[colToCompare].Text, out double xDouble);
            double.TryParse(((ListViewItem)y).SubItems[colToCompare].Text, out double yDouble);

            if (xDouble != 0 && yDouble != 0)
            {
                double difference = xDouble - yDouble;
                if(difference == 0) { return 0; }
                if (difference < 0)
                {
                    return (int)(Math.Floor(xDouble - yDouble) * orderToUse);
                }
                return (int)(Math.Ceiling(xDouble - yDouble) * orderToUse);
            }

            DateTime.TryParse(((ListViewItem)x).SubItems[colToCompare].Text, out DateTime xDateTime);
            DateTime.TryParse(((ListViewItem)y).SubItems[colToCompare].Text, out DateTime yDateTime);

            int xTimestamp = (int)(xDateTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            int yTimestamp = (int)(yDateTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            if (xTimestamp > 0 && yTimestamp > 0) { return (xTimestamp - yTimestamp) * orderToUse; }

            return string.Compare(((ListViewItem)x).SubItems[colToCompare].Text, ((ListViewItem)y).SubItems[colToCompare].Text) * orderToUse;
        }

        public int Compare(object x, object y)
        {
            int result = CompareOne(x, y, col, order);
            if (result == 0 && col2 != -1)
            {
                result = CompareOne(x, y, col2, order2);
            }
            return result;
        }
    }
}
