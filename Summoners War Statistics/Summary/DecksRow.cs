using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class DecksRow
    {
        public string Place { get; set; }
        public string Monster1 { get; set; }
        public string Monster2 { get; set; }
        public string Monster3 { get; set; }
        public string Monster4 { get; set; }
        public string Monster5 { get; set; }
        public string Monster6 { get; set; }
        public string Monster7 { get; set; }
        public string Monster8 { get; set; }
        public string Leader { get; set; }

        public DecksRow(string place, List<string> monsters, string leader)
        {
            Place = place;
            Monster1 = monsters[0];
            Monster2 = monsters[1];
            Monster3 = monsters[2];
            Monster4 = monsters[3];
            Monster5 = monsters[4];
            Monster6 = monsters[5];
            Monster7 = monsters[6];
            Monster8 = monsters[7];
            Leader = leader;
        }
    }
}
