using PcInfoSerchProject;
using PcInfoSerchProject.PcStatus.Modules.Property;
using System.Linq.Expressions;
using System.Threading;

namespace PcApp.src
{
    public static class startUp
    {
        /// <summary>
        ///     スタートアップ時に実行される処理
        /// </summary>
        public static void run() {
            StartObserv obServ = new StartObserv();
            Session.Observ = obServ;
        }
    }
}
