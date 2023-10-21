using us = PcApp.UserControl ;
namespace PcApp;
public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        us.MainBody.Index index = new();
		us.Common.SideBar sidebar = new();
        Content.Add(index);
		//SideBar.Add(sidebar);
    }   
}

