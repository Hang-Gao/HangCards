﻿#pragma checksum "..\..\StartGame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8AD1A9E6D6D73605B189F386CB24948B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace HangCards_GUI {
    
    
    /// <summary>
    /// StartGame
    /// </summary>
    public partial class StartGame : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox playerNamesListBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newPlayerTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addNewPlayerButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancleButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HangCards GUI;component/startgame.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StartGame.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.playerNamesListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 22 "..\..\StartGame.xaml"
            this.playerNamesListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.playerNamesListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.newPlayerTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.addNewPlayerButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\StartGame.xaml"
            this.addNewPlayerButton.Click += new System.Windows.RoutedEventHandler(this.addNewPlayerButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cancleButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\StartGame.xaml"
            this.cancleButton.Click += new System.Windows.RoutedEventHandler(this.cancleButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.okButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

