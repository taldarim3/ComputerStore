﻿#pragma checksum "..\..\..\StorePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "637AB81B3921BB6A4F7D1526EA21CD1CE2493A49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ComputerStorePresentation;
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


namespace ComputerStorePresentation {
    
    
    /// <summary>
    /// StorePage
    /// </summary>
    public partial class StorePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IdBlock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameBlock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PriceBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionBlock;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddNameBlock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddPriceBlock;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddDescriptionBock;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ItemsComboBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\StorePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SearchBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ComputerStorePresentation;component/storepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\StorePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FindButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\StorePage.xaml"
            this.FindButton.Click += new System.Windows.RoutedEventHandler(this.FindById_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IdTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\StorePage.xaml"
            this.IdTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textChangedEventHandler);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IdBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.NameBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PriceBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DescriptionBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 23 "..\..\..\StorePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddNameBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.AddPriceBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.AddDescriptionBock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 30 "..\..\..\StorePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveById_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ItemsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            
            #line 32 "..\..\..\StorePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewAllItems_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.SearchBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\StorePage.xaml"
            this.SearchBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
