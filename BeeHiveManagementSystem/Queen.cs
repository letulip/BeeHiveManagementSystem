using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobType, int shifts)
        {
            foreach (Worker w in workers)
                if (w.DoThisJob(jobType, shifts))
                    return true;

            return false;
        }

        public string WorkNextSHift()
        {
            shiftNumber++;
            string report = "Report for the shift #" + shiftNumber + "\r\n";

            for(int i = 1; i < workers.Length + 1; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Worker #" + i + " finished the job\r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + i + " ain't doing a shit\r\n";
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + i + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft + "more shifts\r\n";
                    else
                        report += "Worker #" + i + " will be done with '" + workers[i].CurrentJob + "' after this shift\r\n ";
                }
            }

            return report;
        }
    }
}
