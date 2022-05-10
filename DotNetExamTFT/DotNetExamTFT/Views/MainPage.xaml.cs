using CommunityToolkit.Mvvm.DependencyInjection;
using DotNetExamTFT.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace DotNetExamTFT.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; }

        public MainPage()
        {
            ViewModel = Ioc.Default.GetService<MainViewModel>();
            InitializeComponent();
        }

        private void Button_Click_Crud_Page(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CrudPage));
        }
    }
}
