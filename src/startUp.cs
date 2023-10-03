using PcInfoSerchProject;
using PcInfoSerchProject.PcStatus.Modules.Property;
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
            Thread t = new Thread(new ThreadStart(UpdateValueThread));
            t.Start();
        }
        /// <summary>
        ///  Cpuの情報をリアルタイムに取得する処理
        /// </summary>
        public static void UpdateValueThread() {
            for (; true;)
            {
                Cpu cpu = Session.Observ.getNowCpu();
                if (cpu != null && cpu.TotalCpuUsage != 0)
                {
                    lock (Session.Cpu) {
                        Session.Cpu = cpu;
                    }
                }

            }
        } 
    }
}
