using PcInfoSerchProject;
using PcInfoSerchProject.PcStatus.Modules.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcApp
{
    static internal class Session
    {
        private static StartObserv obServ;
        public static StartObserv Observ { get { return obServ; } set { obServ = value; } }
      
        private static Cpu nowCpu = new();

        public static Cpu Cpu { get {  return nowCpu; } set {  nowCpu = value; } } 
    }
}
