﻿#pragma checksum "..\..\EditWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A214FF44E9B4933D0F24F8B7E54A7326A129F96664FC3885FB433E69598CC4A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Car_Inspection;
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


namespace Car_Inspection {
    
    
    /// <summary>
    /// EditWindow
    /// </summary>
    public partial class EditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CarComboBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OfficerComboBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResultTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddData;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToInspection;
        
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
            System.Uri resourceLocater = new System.Uri("/Car_Inspection;component/editwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditWindow.xaml"
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
            this.CarComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\EditWindow.xaml"
            this.CarComboBox.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.OnComboboxTextChanged1));
            
            #line default
            #line hidden
            return;
            case 2:
            this.OfficerComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\EditWindow.xaml"
            this.OfficerComboBox.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.OnComboboxTextChanged2));
            
            #line default
            #line hidden
            return;
            case 3:
            this.ResultTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DateText = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.AddData = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\EditWindow.xaml"
            this.AddData.Click += new System.Windows.RoutedEventHandler(this.AddData_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BackToInspection = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\EditWindow.xaml"
            this.BackToInspection.Click += new System.Windows.RoutedEventHandler(this.BackToInspection_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

