using PcApp.src.Struct;

namespace PcApp.UserControl.Common;

public partial class SideBar : ContentView
{
	public SideBar()
	{
		InitializeComponent();

		List<SideMenuCollection> items = new List<SideMenuCollection> { 
			new SideMenuCollection{ Title = "Coding Droplets", Description = "Welcome to Coding Droplets"},
            new SideMenuCollection{ Title = "Title1", Description = "Description 1"},
            new SideMenuCollection{ Title = "Title2", Description = "Description 2"},
            new SideMenuCollection{ Title = "Title3", Description = "Description 3"},
        };
		ListView.ItemsSource = items;
	}
}