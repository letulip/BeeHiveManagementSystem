using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Worker
    {
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo;
        private string currentJob = "";
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int numOfShifts)
        {
            if (!string.IsNullOrEmpty(currentJob))
                return false;
            for(int i = 0; i < jobsICanDo.Length; i++)
                if(jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;

            shiftsWorked++;
            if(shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
    }
}
