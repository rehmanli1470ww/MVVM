using CommandMVVM.ViewModels.PageViewModels;
using System.Windows.Controls;
using System.Windows.Navigation;


namespace CommandMVVM.Views.Pages;

public partial class DashboardPage : Page
{

    public DashboardPage()
    {
        InitializeComponent();
        DataContext = new DashboardViewModel();
    }

    
}
