using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public NectarStinger(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
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
        
    }
}
