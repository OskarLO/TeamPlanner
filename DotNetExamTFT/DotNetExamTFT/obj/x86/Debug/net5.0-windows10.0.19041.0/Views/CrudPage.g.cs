#pragma checksum "C:\Users\Ando\source\repos\DotNetExamTFT\DotNetExamTFT\Views\CrudPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0EF8D8D09B947F596506539EB684CD6973319D18EA4A90B963E12A8343EBBC2"
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
    partial class CrudPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_Primitives_Selector_SelectedItem(global::Microsoft.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(global::Microsoft.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.CommandParameter = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Microsoft.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CrudPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ICrudPage_Bindings
        {
            private global::DotNetExamTFT.Views.CrudPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ListView obj3;
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj6;
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj7;
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3SelectedItemDisabled = false;
            private static bool isobj3ItemsSourceDisabled = false;
            private static bool isobj6CommandDisabled = false;
            private static bool isobj7CommandDisabled = false;
            private static bool isobj7CommandParameterDisabled = false;
            private static bool isobj8CommandDisabled = false;
            private static bool isobj8CommandParameterDisabled = false;

            private CrudPage_obj1_BindingsTracking bindingsTracking;

            public CrudPage_obj1_Bindings()
            {
                this.bindingsTracking = new CrudPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 36 && columnNumber == 37)
                {
                    isobj3SelectedItemDisabled = true;
                }
                else if (lineNumber == 36 && columnNumber == 93)
                {
                    isobj3ItemsSourceDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 50)
                {
                    isobj6CommandDisabled = true;
                }
                else if (lineNumber == 31 && columnNumber == 52)
                {
                    isobj7CommandDisabled = true;
                }
                else if (lineNumber == 31 && columnNumber == 95)
                {
                    isobj7CommandParameterDisabled = true;
                }
                else if (lineNumber == 32 && columnNumber == 56)
                {
                    isobj8CommandDisabled = true;
                }
                else if (lineNumber == 32 && columnNumber == 99)
                {
                    isobj8CommandParameterDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Views\CrudPage.xaml line 36
                        this.obj3 = target.As<Microsoft.UI.Xaml.Controls.ListView>();
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    case 6: // Views\CrudPage.xaml line 30
                        this.obj6 = target.As<Microsoft.UI.Xaml.Controls.AppBarButton>();
                        break;
                    case 7: // Views\CrudPage.xaml line 31
                        this.obj7 = target.As<Microsoft.UI.Xaml.Controls.AppBarButton>();
                        break;
                    case 8: // Views\CrudPage.xaml line 32
                        this.obj8 = target.As<Microsoft.UI.Xaml.Controls.AppBarButton>();
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ICrudPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = newDataRoot.As<DotNetExamTFT.Views.CrudPage>();
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DotNetExamTFT.Views.CrudPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::DotNetExamTFT.ViewModels.CrudViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Selected(obj.Selected, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Units(obj.Units, phase);
                        this.Update_ViewModel_AddCommand(obj.AddCommand, phase);
                        this.Update_ViewModel_UpdateCommand(obj.UpdateCommand, phase);
                        this.Update_ViewModel_DeleteCommand(obj.DeleteCommand, phase);
                    }
                }
            }
            private void Update_ViewModel_Selected(global::DotNetExamTFT.ViewModels.DialogViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Selected(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CrudPage.xaml line 36
                    if (!isobj3SelectedItemDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj3, obj, null);
                    }
                    // Views\CrudPage.xaml line 31
                    if (!isobj7CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj7, obj, null);
                    }
                    // Views\CrudPage.xaml line 32
                    if (!isobj8CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj8, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Units(global::System.Collections.ObjectModel.ObservableCollection<global::DotNetExamTFT.ViewModels.DialogViewModel> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CrudPage.xaml line 36
                    if (!isobj3ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                    }
                }
            }
            private void Update_ViewModel_AddCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CrudPage.xaml line 30
                    if (!isobj6CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                    }
                }
            }
            private void Update_ViewModel_UpdateCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CrudPage.xaml line 31
                    if (!isobj7CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ViewModel_DeleteCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CrudPage.xaml line 32
                    if (!isobj8CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj8, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_3_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.Selected = (global::DotNetExamTFT.ViewModels.DialogViewModel)this.obj3.SelectedItem;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CrudPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<CrudPage_obj1_Bindings> weakRefToBindingObj; 

                public CrudPage_obj1_BindingsTracking(CrudPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CrudPage_obj1_Bindings>(obj);
                }

                public CrudPage_obj1_Bindings TryGetBindingObject()
                {
                    CrudPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_Selected(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CrudPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::DotNetExamTFT.ViewModels.CrudViewModel obj = sender as global::DotNetExamTFT.ViewModels.CrudViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Selected":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::DotNetExamTFT.ViewModels.CrudViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::DotNetExamTFT.ViewModels.CrudViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Selected(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CrudPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::DotNetExamTFT.ViewModels.DialogViewModel obj = sender as global::DotNetExamTFT.ViewModels.DialogViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::DotNetExamTFT.ViewModels.DialogViewModel cache_ViewModel_Selected = null;
                public void UpdateChildListeners_ViewModel_Selected(global::DotNetExamTFT.ViewModels.DialogViewModel obj)
                {
                    if (obj != cache_ViewModel_Selected)
                    {
                        if (cache_ViewModel_Selected != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Selected).PropertyChanged -= PropertyChanged_ViewModel_Selected;
                            cache_ViewModel_Selected = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Selected = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Selected;
                        }
                    }
                }
                public void RegisterTwoWayListener_3(global::Microsoft.UI.Xaml.Controls.ListView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_SelectedItem();
                        }
                    });
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\CrudPage.xaml line 10
                {
                    this.ContentArea = target.As<Microsoft.UI.Xaml.Controls.Grid>();
                }
                break;
            case 3: // Views\CrudPage.xaml line 36
                {
                    this.Unit = target.As<Microsoft.UI.Xaml.Controls.ListView>();
                }
                break;
            case 5: // Views\CrudPage.xaml line 29
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element5 = target.As<Microsoft.UI.Xaml.Controls.AppBarButton>();
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element5).Click += this.Button_Click_Get_Units;
                }
                break;
            case 9: // Views\CrudPage.xaml line 23
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element9 = target.As<Microsoft.UI.Xaml.Controls.AppBarButton>();
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element9).Click += this.Button_Click_Main_Page;
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
            switch(connectionId)
            {
            case 1: // Views\CrudPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    CrudPage_obj1_Bindings bindings = new CrudPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

