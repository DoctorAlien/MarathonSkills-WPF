﻿#pragma checksum "..\..\EventRegister.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D1C05B4AB7F3B0ADD94FF07D049C2DC1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Marathon;
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


namespace Marathon {
    
    
    /// <summary>
    /// EventRegister
    /// </summary>
    public partial class EventRegister : Marathon.Master, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\EventRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFullMarathon;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\EventRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbHalfMarathon;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\EventRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFunRun;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\EventRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTotal;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\EventRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModal;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\EventRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxRaceKitOption;
        
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
            System.Uri resourceLocater = new System.Uri("/Marathon;component/eventregister.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EventRegister.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.cbFullMarathon = ((System.Windows.Controls.CheckBox)(target));
            
            #line 25 "..\..\EventRegister.xaml"
            this.cbFullMarathon.Click += new System.Windows.RoutedEventHandler(this.cbFullMarathon_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbHalfMarathon = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\EventRegister.xaml"
            this.cbHalfMarathon.Click += new System.Windows.RoutedEventHandler(this.cbHalfMarathon_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbFunRun = ((System.Windows.Controls.CheckBox)(target));
            
            #line 27 "..\..\EventRegister.xaml"
            this.cbFunRun.Click += new System.Windows.RoutedEventHandler(this.cbFunRun_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnModal = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\EventRegister.xaml"
            this.btnModal.Click += new System.Windows.RoutedEventHandler(this.btnModal_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbxRaceKitOption = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 43 "..\..\EventRegister.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

