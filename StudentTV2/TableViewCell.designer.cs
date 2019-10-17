// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace StudentTV2
{
    [Register ("TableViewCell")]
    partial class TableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _studentAge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _studentCourse { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _studentId { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _studentName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_studentAge != null) {
                _studentAge.Dispose ();
                _studentAge = null;
            }

            if (_studentCourse != null) {
                _studentCourse.Dispose ();
                _studentCourse = null;
            }

            if (_studentId != null) {
                _studentId.Dispose ();
                _studentId = null;
            }

            if (_studentName != null) {
                _studentName.Dispose ();
                _studentName = null;
            }
        }
    }
}