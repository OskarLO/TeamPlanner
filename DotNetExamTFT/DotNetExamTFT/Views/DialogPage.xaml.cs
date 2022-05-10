using DotNetExamTFT.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace DotNetExamTFT.Views
{
    public sealed partial class DialogPage : Page
    {
        public DialogViewModel ViewModel { get; }

        public DialogPage(DialogViewModel viewModel)
        {
            ViewModel = viewModel;
            this.InitializeComponent();
        }
    }
}
