using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    interface IWorker
    {
        string Job { get; }
        int ShiftsLength { get; }

        void DoTHisJob(string job, int shifts);
        void WorkOneSHift();
    }
}
