using Microsoft.Maui.Controls.PlatformConfiguration;
using PcInfoSerchProject;
using PcInfoSerchProject.PcStatus.Modules.Property;
using System.Diagnostics.Metrics;
using System.Timers;

namespace PcApp;
public partial class MainPage : ContentPage
{
    System.Timers.Timer timer;
    int count = 0;

	public MainPage()
	{
		InitializeComponent();
        timer = new System.Timers.Timer(1000); // 1秒間隔で設定
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            CpuTotalUsage.Text = Session.Cpu.TotalCpuUsage.ToString();
            CpuPackageTemp.Text = Session.Cpu.PackageTemp.ToString();
        });
    }
}

