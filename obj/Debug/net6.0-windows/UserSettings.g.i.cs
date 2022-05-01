﻿#pragma checksum "..\..\..\UserSettings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04465370E703F0807FFD89B9794AB6CB4C08A0A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace LightMisBank {
    
    
    /// <summary>
    /// UserSettings
    /// </summary>
    public partial class UserSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UserSettings_General;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PopupBox SystemAbout;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SystemAboutButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Menu;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelMain;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid StackPanelSQLOptions;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SQLOptions_SQLPath;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SQLOptions_SQLitePath;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LightMisBank;V1.0.0.0;component/usersettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserSettings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserSettings_General = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.SystemAbout = ((MaterialDesignThemes.Wpf.PopupBox)(target));
            return;
            case 3:
            this.SystemAboutButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\UserSettings.xaml"
            this.SystemAboutButton.Click += new System.Windows.RoutedEventHandler(this.SystemAboutButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Menu = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.StackPanelMain = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.StackPanelSQLOptions = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.SQLOptions_SQLPath = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.SQLOptions_SQLitePath = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
