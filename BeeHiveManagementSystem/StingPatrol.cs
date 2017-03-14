using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class StingPatrol : Worker, IStingPatrol
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public string Job { get; }
        public int ShiftsLength { get; }

        public StingPatrol(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
        {

        }

        public bool SharpenStinger(int Length)
        {

        }

        public bool LookForEnemies()
        {

        }

        public void Sting(string Enemy)
        {

        }

        public void DoTHisJob(string job, int shifts)
        {

        }

        public void WorkOneSHift()
        {

        }

    }
}
