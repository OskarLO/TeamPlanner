using CommunityToolkit.Mvvm.DependencyInjection;
using DotNetExamTFT.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace DotNetExamTFT.Views
{

    public sealed partial class CrudPage : Page
    {
        public CrudViewModel ViewModel { get; }

        public CrudPage()
        {
            ViewModel = Ioc.Default.GetService<CrudViewModel>();
            InitializeComponent();
        }

        private void Button_Click_Main_Page(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_Get_Units(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.GetUnits();
        }
    }
}
