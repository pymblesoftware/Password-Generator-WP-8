﻿#pragma checksum "C:\Users\Regan\documents\visual studio 2012\Projects\Password Generator\Password Generator\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3EBF7DE4A9841C124AE1B3E1FC58B49E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Inneractive.Ad;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Windows.Controls;


namespace Password_Generator {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Telerik.Windows.Controls.RadToggleSwitch uppercaseToggle;
        
        internal Telerik.Windows.Controls.RadNumericUpDown NumCharsUpDown;
        
        internal Telerik.Windows.Controls.RadToggleSwitch NumbersToggle;
        
        internal Telerik.Windows.Controls.RadToggleSwitch PunctToggle;
        
        internal System.Windows.Controls.Button GenerateButton;
        
        internal System.Windows.Controls.Grid BottomContentPanel;
        
        internal Inneractive.Ad.InneractiveAd InneractiveXamlAd1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Password%20Generator;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.uppercaseToggle = ((Telerik.Windows.Controls.RadToggleSwitch)(this.FindName("uppercaseToggle")));
            this.NumCharsUpDown = ((Telerik.Windows.Controls.RadNumericUpDown)(this.FindName("NumCharsUpDown")));
            this.NumbersToggle = ((Telerik.Windows.Controls.RadToggleSwitch)(this.FindName("NumbersToggle")));
            this.PunctToggle = ((Telerik.Windows.Controls.RadToggleSwitch)(this.FindName("PunctToggle")));
            this.GenerateButton = ((System.Windows.Controls.Button)(this.FindName("GenerateButton")));
            this.BottomContentPanel = ((System.Windows.Controls.Grid)(this.FindName("BottomContentPanel")));
            this.InneractiveXamlAd1 = ((Inneractive.Ad.InneractiveAd)(this.FindName("InneractiveXamlAd1")));
        }
    }
}

