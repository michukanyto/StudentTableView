// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StudentTV2
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView StudentTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (StudentTable != null) {
                StudentTable.Dispose ();
                StudentTable = null;
            }
        }
    }
}