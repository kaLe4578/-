#pragma checksum "..\..\..\Windows\EditJournalWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7430D65EEF3755A64EC564855C1C3CC7028AD6D45E1B9E1D55052A57AED4C6A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IkApp.Windows;
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


namespace IkApp.Windows {
    
    
    /// <summary>
    /// EditJournalWindow
    /// </summary>
    public partial class EditJournalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Windows\EditJournalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox F;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\EditJournalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox I;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Windows\EditJournalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox O;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Windows\EditJournalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdBook;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Windows\EditJournalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BookingStartData;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\EditJournalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BookingEndData;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\EditJournalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookingStatus;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\EditJournalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
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
            System.Uri resourceLocater = new System.Uri("/IkApp;component/windows/editjournalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EditJournalWindow.xaml"
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
            this.F = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.I = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.O = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.IdBook = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BookingStartData = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.BookingEndData = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.BookingStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Edit = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Windows\EditJournalWindow.xaml"
            this.Edit.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

