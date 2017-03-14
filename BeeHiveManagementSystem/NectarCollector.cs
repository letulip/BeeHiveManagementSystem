using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class NectarCollector : Worker, INectarCollector, IStingPatrol
    {
        public int Nectar { get; set; }
        public string Job { get; }
        public int ShiftsLength { get; }

        int IStingPatrol.AlertLevel
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        int IStingPatrol.StingerLength
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public NectarCollector(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
        {

        }

        public void FindFlowers()
        {

        }

        public void GatherNectar()
        {

        }

        public void ReturnToHive()
        {

        }

        public void DoTHisJob(string job, int shifts)
        {

        }

        public void WorkOneSHift()
        {

        }

        bool IStingPatrol.LookForEnemies()
        {
            throw new NotImplementedException();
        }

        bool IStingPatrol.SharpenStinger(int length)
        {
            throw new NotImplementedException();
        }
    }
}
