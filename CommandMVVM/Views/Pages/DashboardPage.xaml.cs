using CommandMVVM.ViewModels.PageViewModels;
using System.Windows.Controls;
using System.Windows.Navigation;


namespace CommandMVVM.Views.Pages;

public partial class DashboardPage : Page
{
    public void fuu() 
    {
        NavigationService.Navigate(new EditPage());
    }

    public DashboardPage()
    {
        InitializeComponent();
        DataContext = new DashboardViewModel();
    }

    
}
