﻿#pragma checksum "C:\Users\User\Documents\AAUniversity\2018 - S1\SDV701\PROJECT\Client_App\pgBook.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D8F3945922027A435797F9AF5F80ACCA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_App
{
    partial class pgBook : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // pgBook.xaml line 12
                {
                    this.lblFormat = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // pgBook.xaml line 13
                {
                    this.lblISBN = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // pgBook.xaml line 14
                {
                    this.lblName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // pgBook.xaml line 15
                {
                    this.lblGenre = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // pgBook.xaml line 16
                {
                    this.btnOrder = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOrder).Click += this.btnOrder_Click;
                }
                break;
            case 7: // pgBook.xaml line 17
                {
                    this.btnBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBack).Click += this.Button_Click;
                }
                break;
            case 8: // pgBook.xaml line 18
                {
                    this.ctcBookSpecs = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                }
                break;
            case 9: // pgBook.xaml line 19
                {
                    this.lblPrice = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // pgBook.xaml line 20
                {
                    this.lblOrderNow = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // pgBook.xaml line 21
                {
                    this.lblEnterDetails = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // pgBook.xaml line 22
                {
                    this.lblQuantity = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // pgBook.xaml line 23
                {
                    this.tbxQuantity = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // pgBook.xaml line 24
                {
                    this.lblCustName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // pgBook.xaml line 25
                {
                    this.lblCustEmailAddress = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // pgBook.xaml line 26
                {
                    this.tbxCustName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17: // pgBook.xaml line 27
                {
                    this.tbxCustEmailAddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
