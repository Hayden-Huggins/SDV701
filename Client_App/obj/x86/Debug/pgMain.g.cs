﻿#pragma checksum "C:\Users\User\Documents\AAUniversity\2018 - S1\SDV701\PROJECT\Client_App\pgMain.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F1AE442D035ACAD4F63E83F00DCB8D3D"
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
    partial class pgMain : 
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
            case 2: // pgMain.xaml line 11
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).Loaded += this.Grid_Loaded;
                }
                break;
            case 3: // pgMain.xaml line 12
                {
                    this.lstGenre = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 4: // pgMain.xaml line 13
                {
                    this.lblSelectCategory = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // pgMain.xaml line 14
                {
                    this.btnSelect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSelect).Click += this.btnSelect_Click;
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
