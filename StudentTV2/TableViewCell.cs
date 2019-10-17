using System;

using Foundation;
using UIKit;

namespace StudentTV2
{
    public partial class TableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("TableViewCell");
        public static readonly UINib Nib;

        static TableViewCell()
        {
            Nib = UINib.FromName("TableViewCell", NSBundle.MainBundle);
        }

        protected TableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        internal void UpdateCell(Student s)
        {
            _studentName.Text = s._fullName;
            _studentId.Text = s._id;
            _studentAge.Text = s._age.ToString();
            _studentCourse.Text = s._course;
        }
    }
}
