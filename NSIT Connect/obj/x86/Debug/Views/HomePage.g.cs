﻿#pragma checksum "C:\Users\AGGARWAL'S\Documents\Visual Studio 2015\Projects\NSIT Connect\NSIT Connect\Views\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "38F5CEDA4DB3676E06892CF23BCFC2D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NSIT_Connect.Views
{
    partial class HomePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Template10_Controls_MasterDetailsView_Details(global::Template10.Controls.MasterDetailsView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Details = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Template10_Controls_MasterDetailsView_IsDetailsLoading(global::Template10.Controls.MasterDetailsView obj, global::System.Boolean value)
            {
                obj.IsDetailsLoading = value;
            }
            public static void Set_Template10_Controls_MasterDetailsView_IsMasterLoading(global::Template10.Controls.MasterDetailsView obj, global::System.Boolean value)
            {
                obj.IsMasterLoading = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        private class HomePage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHomePage_Bindings
        {
            private global::NSIT_Connect.Views.HomePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Template10.Controls.MasterDetailsView obj9;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj10;

            private HomePage_obj1_BindingsTracking bindingsTracking;

            public HomePage_obj1_Bindings()
            {
                this.bindingsTracking = new HomePage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9:
                        this.obj9 = (global::Template10.Controls.MasterDetailsView)target;
                        (this.obj9).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedItemProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.Selected = (this.obj9).SelectedItem;
                                }
                            });
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    default:
                        break;
                }
            }

            // IHomePage_Bindings

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

            // HomePage_obj1_Bindings

            public void SetDataRoot(global::NSIT_Connect.Views.HomePage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::NSIT_Connect.Views.HomePage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::NSIT_Connect.ViewModels.HomePageViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Selected(obj.Selected, phase);
                        this.Update_ViewModel_IsDetailsLoading(obj.IsDetailsLoading, phase);
                        this.Update_ViewModel_IsMasterLoading(obj.IsMasterLoading, phase);
                        this.Update_ViewModel_HomeFeed(obj.HomeFeed, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_RefreshCommand(obj.RefreshCommand, phase);
                    }
                }
            }
            private void Update_ViewModel_Selected(global::System.Object obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Template10_Controls_MasterDetailsView_Details(this.obj9, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj9, obj, null);
                }
            }
            private void Update_ViewModel_IsDetailsLoading(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Template10_Controls_MasterDetailsView_IsDetailsLoading(this.obj9, obj);
                }
            }
            private void Update_ViewModel_IsMasterLoading(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Template10_Controls_MasterDetailsView_IsMasterLoading(this.obj9, obj);
                }
            }
            private void Update_ViewModel_HomeFeed(global::System.Collections.ObjectModel.ObservableCollection<global::NSIT_Connect.Models.Feed> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj9, obj, null);
                }
            }
            private void Update_ViewModel_RefreshCommand(global::Template10.Mvvm.DelegateCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj10, obj, null);
                }
            }

            private class HomePage_obj1_BindingsTracking
            {
                global::System.WeakReference<HomePage_obj1_Bindings> WeakRefToBindingObj; 

                public HomePage_obj1_BindingsTracking(HomePage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<HomePage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::NSIT_Connect.ViewModels.HomePageViewModel obj = sender as global::NSIT_Connect.ViewModels.HomePageViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                                    bindings.Update_ViewModel_IsDetailsLoading(obj.IsDetailsLoading, DATA_CHANGED);
                                    bindings.Update_ViewModel_IsMasterLoading(obj.IsMasterLoading, DATA_CHANGED);
                                    bindings.Update_ViewModel_HomeFeed(obj.HomeFeed, DATA_CHANGED);
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
                                case "IsDetailsLoading":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsDetailsLoading(obj.IsDetailsLoading, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsMasterLoading":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsMasterLoading(obj.IsMasterLoading, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "HomeFeed":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_HomeFeed(obj.HomeFeed, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::NSIT_Connect.ViewModels.HomePageViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::NSIT_Connect.ViewModels.HomePageViewModel obj)
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
                public void PropertyChanged_ViewModel_HomeFeed(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::NSIT_Connect.Models.Feed> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::NSIT_Connect.Models.Feed>;
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
                public void CollectionChanged_ViewModel_HomeFeed(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::NSIT_Connect.Models.Feed> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::NSIT_Connect.Models.Feed>;
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ThisPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.ViewModel = (global::NSIT_Connect.ViewModels.HomePageViewModel)(target);
                }
                break;
            case 3:
                {
                    this.MessageListItemTemplate = (global::Windows.UI.Xaml.DataTemplate)(target);
                }
                break;
            case 4:
                {
                    this.MessageDetailTemplate = (global::Windows.UI.Xaml.DataTemplate)(target);
                }
                break;
            case 5:
                {
                    this.MessageListViewStyle = (global::Windows.UI.Xaml.Style)(target);
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.ScrollViewer element6 = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                    #line 308 "..\..\..\Views\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)element6).ViewChanged += this.ScrollViewer_ViewChanged;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.VisualStateGroup element7 = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                    #line 335 "..\..\..\Views\HomePage.xaml"
                    ((global::Windows.UI.Xaml.VisualStateGroup)element7).CurrentStateChanged += this.NarrowVisualStateGroup_CurrentStateChanged;
                    #line default
                }
                break;
            case 8:
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.MailList = (global::Template10.Controls.MasterDetailsView)(target);
                    #line 405 "..\..\..\Views\HomePage.xaml"
                    ((global::Template10.Controls.MasterDetailsView)this.MailList).ItemClick += this.MailList_ItemClick;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 463 "..\..\..\Views\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element11).Click += this.AppBarButton_Click_1;
                    #line default
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element12 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 468 "..\..\..\Views\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element12).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    HomePage_obj1_Bindings bindings = new HomePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

