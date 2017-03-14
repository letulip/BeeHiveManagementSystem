using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobType, int shifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(jobType, shifts))
                    return true;

            return false;
        }

        public string WorkNextSHift()
        {
            double honeyConsumption = HoneyConsumptionRate();
            shiftNumber++;
            
            string report = "Report for the shift #" + shiftNumber + "\r\n";

            for(int i = 0; i < workers.Length; i++)
            {
                honeyConsumption += workers[i].HoneyConsumptionRate();

                if (workers[i].DidYouFinish())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " ain't doing a shit\r\n";
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
                    else
                        report += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob + "' after this shift\r\n ";
                }
            }

            report += "Total honey consumption fo the shift: " + honeyConsumption + " units\r\n";

            return report;
        }

        private void DefendTheHive(IStingPatrol patroller)
        {

        }
    }
}
