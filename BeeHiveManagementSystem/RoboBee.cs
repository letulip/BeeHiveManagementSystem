using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class RoboBee : Robot, IWorker
    {
        private int shiftsToWork;
        private int shiftsWorked;

        public string Job { get; private set; }

        public int ShiftsLength
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public void DoTHisJob(string job, int shifts)
        {
            
        }

        public void WorkOneSHift()
        {
            
        }
    }
}
