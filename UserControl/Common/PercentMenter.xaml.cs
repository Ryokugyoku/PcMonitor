
using PcApp.src.Enum;
using PcInfoSerchProject;
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
        int value = 0;
        MainThread.BeginInvokeOnMainThread(() =>
        {
            switch (htype)
            {
                case HardwareType.Cpu:
                    ItemName.Text = GlobalObject.CpuName;
                    value = (int)Math.Round(GlobalObject.NowCpuData.TotalCpuUsage);
                    MeterPin.Value = value;
                    MeterValue.Text = value.ToString()+"%";
                   
                    break;

                case HardwareType.NvidiaGpu:
                    ItemName.Text = GlobalObject.GpuName;
                    value = (int)Math.Round(GlobalObject.NowGpuData.TotalGpuUsage);
                    MeterPin.Value = value;
                    MeterValue.Text = value.ToString() + "%";
                    break;

                case HardwareType.AmdGpu:

                    break;
            }
        });
    }

}