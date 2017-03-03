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
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobType, int shifts)
        {
            return true;
        }

        public void WorkNextSHift()
        {

        }
    }
}
