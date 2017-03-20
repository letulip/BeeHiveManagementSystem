using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Bee : IStingPatrol
    {
        public const double HoneyUnitsConsumedPerMg = .25;

        public double WeightMg { get; private set; }

        public int AlertLevel { get; }

        public int StingerLength { get; set; }

        public string Job
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ShiftsLength
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        public virtual double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public bool SharpenStinger(int length)
        {
            throw new NotImplementedException();
        }

        public void DoTHisJob(string job, int shifts)
        {
            
        }

        public void WorkOneSHift()
        {
            
        }
    }
}
