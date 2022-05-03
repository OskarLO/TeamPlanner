using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TeamPlannerTFT.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace TeamPlannerTFT.Views
{

    public sealed partial class CrudPage : Page
    {

        public CrudViewModel ViewModel { get; }

        public CrudPage()
        {
            ViewModel = Ioc.Default.GetService<CrudViewModel>();
            this.InitializeComponent();
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
