// Updated by XamlIntelliSenseFileGenerator 17.09.2023 22:10:12
#pragma checksum "..\..\..\Pages\PagePR2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A177328B64016D33908ACF9715EC54BC4DDE040AA8310904BFA780A392538631"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstAppMiusova.Pages;
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


namespace FirstAppMiusova.Pages
{


    /// <summary>
    /// PagePR2
    /// </summary>
    public partial class PagePR2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 31 "..\..\..\Pages\PagePR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPR2X;

#line default
#line hidden


#line 44 "..\..\..\Pages\PagePR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPR2Y;

#line default
#line hidden


#line 57 "..\..\..\Pages\PagePR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPR2Z;

#line default
#line hidden


#line 70 "..\..\..\Pages\PagePR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LstResultPR2;

#line default
#line hidden


#line 77 "..\..\..\Pages\PagePR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSolvePR2;

#line default
#line hidden


#line 82 "..\..\..\Pages\PagePR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClearPR2;

#line default
#line hidden


#line 90 "..\..\..\Pages\PagePR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBackPR2;

#line default
#line hidden


#line 95 "..\..\..\Pages\PagePR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNextPR2;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FirstAppMiusova;component/pages/pagepr2.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Pages\PagePR2.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.TxtPR2X = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.RbtSinPR2 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 3:
                    this.TxtPR2Y = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.RbtCosPR2 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 5:
                    this.TxtPR2Z = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.RbtExpPR2 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 7:
                    this.LstResultPR2 = ((System.Windows.Controls.ListBox)(target));

#line 73 "..\..\..\Pages\PagePR2.xaml"
                    this.LstResultPR2.AddHandler(System.Windows.Controls.Primitives.ScrollBar.ScrollEvent, new System.Windows.Controls.Primitives.ScrollEventHandler(this.LstResultPR2_Scroll));

#line default
#line hidden
                    return;
                case 8:
                    this.BtnSolvePR2 = ((System.Windows.Controls.Button)(target));

#line 81 "..\..\..\Pages\PagePR2.xaml"
                    this.BtnSolvePR2.Click += new System.Windows.RoutedEventHandler(this.BtnSolvePR2_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.BtnClearPR2 = ((System.Windows.Controls.Button)(target));

#line 86 "..\..\..\Pages\PagePR2.xaml"
                    this.BtnClearPR2.Click += new System.Windows.RoutedEventHandler(this.BtnClearPR2_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.BtnBackPR2 = ((System.Windows.Controls.Button)(target));

#line 94 "..\..\..\Pages\PagePR2.xaml"
                    this.BtnBackPR2.Click += new System.Windows.RoutedEventHandler(this.BtnBackPR2_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.BtnNextPR2 = ((System.Windows.Controls.Button)(target));

#line 99 "..\..\..\Pages\PagePR2.xaml"
                    this.BtnNextPR2.Click += new System.Windows.RoutedEventHandler(this.BtnNextPR2_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.RadioButton RbtShxPR2;
        internal System.Windows.Controls.RadioButton RbtX2PR2;
        internal System.Windows.Controls.RadioButton RbtExPR2;
    }
}

