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
        private int col;
        private static int colOrder;
        private static short order = 1;

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
        public int Compare(object x, object y)
        {
            double.TryParse(((ListViewItem)x).SubItems[col].Text, out double xDouble);
            double.TryParse(((ListViewItem)y).SubItems[col].Text, out double yDouble);

            if (xDouble != 0 && yDouble != 0) {
                double difference = xDouble - yDouble;
                if(difference < 0)
                {
                    return (int)(Math.Floor(xDouble - yDouble) * order);
                }
                return (int)(Math.Ceiling(xDouble - yDouble) * order);
            }

            //int.TryParse(((ListViewItem)x).SubItems[col].Text, out int xInt);
            //int.TryParse(((ListViewItem)y).SubItems[col].Text, out int yInt);

            //if (xInt != 0 && yInt != 0) { return (xInt - yInt) * order; }

            DateTime.TryParse(((ListViewItem)x).SubItems[col].Text, out DateTime xDateTime);
            DateTime.TryParse(((ListViewItem)y).SubItems[col].Text, out DateTime yDateTime);

            int xTimestamp = (int)(xDateTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            int yTimestamp = (int)(yDateTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            if (xTimestamp > 0 && yTimestamp > 0) { return (xTimestamp - yTimestamp) * order; }

            return string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text) * order;
        }
    }
}
