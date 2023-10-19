using PcApp.src.Enum;
using PcInfoSerchProject;
using System.Diagnostics.Metrics;
using System.Timers;

namespace PcApp.UserControl.Common;

/// <summary>
///     各種使用率
/// </summary>
public partial class PercentMenter : ContentView
{
    System.Timers.Timer timer;

    private HardwareType htype;

    /// <summary>
    ///     各種使用率を表示する
    /// </summary>
    private PercentMenter()
	{
		InitializeComponent();
        timer = new System.Timers.Timer(500);
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    public PercentMenter(HardwareType type) : this()
    {
        htype = type;
    }

    private void SfRadialGauge_SizeChanged(object sender, EventArgs e)
    {

    }

    /// <summary>
    ///     1秒感覚で実行される。
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            switch (htype)
            {
                case HardwareType.Cpu:
                    MeterValue.Text = GlobalObject.NowCpuData.TotalCpuUsage.ToString();
                    MeterPin.Value = GlobalObject.NowCpuData.TotalCpuUsage;
                    break;

                case HardwareType.NvidiaGpu:

                    break;

                case HardwareType.AmdGpu:

                    break;
            }
        });
    }
}