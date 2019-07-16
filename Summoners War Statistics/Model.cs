using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class Model
    {
        public string DimHoleCalculateTime(ushort energyNeeded, short energy, DateTime energyGainStart, bool listView)
        {
            string date;

            if (listView) { date = "You have enough dimensional energy to 2A this unit."; }
            else { date = "Your dimensional energy has reached out the limit. You are wasting potential dimensional energy!"; }

            short energyToGet = (short)(energyNeeded - energy);
            if (energyToGet > 0)
            {
                DateTime energyGain = energyGainStart;
                energyGain = energyGain.AddHours(2*energyToGet);

                if (listView) { date = energyGain.ToString("dddd, dd-MMMM-yyyy HH:mm:ss"); }
                else { date = $"{energyGain.ToString("dddd, dd-MMMM-yyyy HH:mm:ss")} you'll have {energyNeeded} dimensional energy if you don't use any."; }
            }

            return date;
        }
    }
}
