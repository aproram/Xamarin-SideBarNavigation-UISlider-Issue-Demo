// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SidebarNavIssueDemo
{
    [Register ("MenuViewController")]
    partial class MenuViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TableViewMain { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewMain != null) {
                TableViewMain.Dispose ();
                TableViewMain = null;
            }
        }
    }
}