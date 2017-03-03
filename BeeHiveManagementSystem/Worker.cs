using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Worker
    {
        public string CurrentJob { get; }
        public int ShiftsLeft { get; }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(bool IsFree)
        {
            if (IsFree)
                return true;
            else
                return false;
        }

        public bool DidYouFinish(bool IsDone)
        {
            if (IsDone)
                return true;
            else
                return false;
        }
    }
}
