using PcInfoSerchProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcApp
{
    static internal class GlobalObject
    {
        private static StartObserv obServ;
        public static StartObserv Observ { get { return obServ; } set { obServ = value; } }
    }
}
