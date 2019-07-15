using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class Model
    {
        public string DimHoleCalculateTimeNeededFor2A(ushort energyNeeded, short energy, DateTime energyGainStart)
        {
            string dateWhen2A = "You have enough dimensional energy to 2A this unit.";
            short energyToGet = (short)(energyNeeded - energy);
            if (energyToGet > 0)
            {
                byte tempEnergy = (byte)(energyToGet);
                DateTime energyGain = energyGainStart;
                while (tempEnergy != 0)
                {
                    energyGain = energyGain.AddHours(2);
                    tempEnergy--;
                }
                dateWhen2A = energyGain.ToString("dddd, dd-MMMM-yyyy HH:mm:ss");
            }

            return dateWhen2A;
        }
    }
}
