#pragma checksum "C:\Users\Ando\source\repos\DotNetExamTFT\DotNetExamTFT\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F379B5E660905DE9FF7600029F8B250D2D23ADB757312FEBCE4DDFAACCF271FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using WinRT;

namespace DotNetExamTFT.Views
{
    partial class MainPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 10
                {
                    this.ContentArea = target.As<Microsoft.UI.Xaml.Controls.Grid>();
                }
                break;
            case 3: // Views\MainPage.xaml line 22
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element3 = target.As<Microsoft.UI.Xaml.Controls.AppBarButton>();
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element3).Click += this.Button_Click_Crud_Page;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

