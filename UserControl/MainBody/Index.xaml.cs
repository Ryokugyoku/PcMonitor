using PcApp.UserControl.Common;
using PcInfoSerchProject;
using System.Timers;

namespace PcApp.UserControl.MainBody;

public partial class Index : ContentView
{

    public Index()
	{
		InitializeComponent();

        Meter.Add(new PercentMenter(src.Enum.HardwareType.Cpu));
        GpuMeter.Add(new PercentMenter(src.Enum.HardwareType.NvidiaGpu));
    }
}