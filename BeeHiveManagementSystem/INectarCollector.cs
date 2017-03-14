using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    interface INectarCollector : IWorker
    {
        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}
