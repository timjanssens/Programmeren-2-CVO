﻿#pragma checksum "..\..\ProductDetail.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6F02847232137357ED5F8E4EDB886D51B0590A363E4BB2110CDB060DCEE20339"
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
using _00_Multiple_forms_Classes;


namespace _00_Multiple_forms_Classes {
    
    
    /// <summary>
    /// ProductDetail
    /// </summary>
    public partial class ProductDetail : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCode;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrice;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
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
            System.Uri resourceLocater = new System.Uri("/00 Multiple forms Classes;component/productdetail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductDetail.xaml"
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
            this.txtCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\ProductDetail.xaml"
            this.txtCode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\ProductDetail.xaml"
            this.txtName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNaam_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\ProductDetail.xaml"
            this.txtDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtOmschrijving_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\ProductDetail.xaml"
            this.txtPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPrijs_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ProductDetail.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ProductDetail.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

