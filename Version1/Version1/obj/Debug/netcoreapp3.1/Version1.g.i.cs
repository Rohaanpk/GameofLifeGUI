// Updated by XamlIntelliSenseFileGenerator 6/05/2021 9:20:30 PM
#pragma checksum "..\..\..\Version1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DEA551E5CCF8DB4C59640F5967C95FEB98C1BF1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using VersionControl;


namespace Version1
{


    /// <summary>
    /// Version1
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 15 "..\..\..\Version1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;

#line default
#line hidden


#line 23 "..\..\..\Version1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button autoGenerator;

#line default
#line hidden


#line 24 "..\..\..\Version1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reset;

#line default
#line hidden


#line 25 "..\..\..\Version1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button generator;

#line default
#line hidden


#line 26 "..\..\..\Version1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VersionControl;V1.0.0.0;component/version1.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Version1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.MainGrid = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:
                    this.autoGenerator = ((System.Windows.Controls.Button)(target));

#line 23 "..\..\..\Version1.xaml"
                    this.autoGenerator.Click += new System.Windows.RoutedEventHandler(this.auto);

#line default
#line hidden
                    return;
                case 3:
                    this.Reset = ((System.Windows.Controls.Button)(target));

#line 24 "..\..\..\Version1.xaml"
                    this.Reset.Click += new System.Windows.RoutedEventHandler(this.reset);

#line default
#line hidden
                    return;
                case 4:
                    this.generator = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\..\Version1.xaml"
                    this.generator.Click += new System.Windows.RoutedEventHandler(this.generation);

#line default
#line hidden
                    return;
                case 5:
                    this.exitButton = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\..\Version1.xaml"
                    this.exitButton.Click += new System.Windows.RoutedEventHandler(this.closeWindow);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

