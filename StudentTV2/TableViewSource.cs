using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace StudentTV2
{
    public class TableViewSource : UITableViewSource
    {
        private List<Student> students;

        public TableViewSource(List<Student> students)
        {
            this.students = students;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (TableViewCell)tableView.DequeueReusableCell("cell_id", indexPath);
            Student s = students[indexPath.Row];
            cell.UpdateCell(s);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return students.Count;
        }

        //public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        //{
        //    UIAlertController okAlertController = UIAlertController.Create("Row Selected", students[indexPath.Row]._fullName, UIAlertControllerStyle.Alert);
        //    okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));


        //    tableView.DeselectRow(indexPath, true);
        //}

        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
        {
            //base.CommitEditingStyle(tableView, editingStyle, indexPath);
            switch (editingStyle)
            {
                case UITableViewCellEditingStyle.Delete:
                    // remove the item from the underlying data source
                    students.RemoveAt(indexPath.Row);
                    // delete the row from the table
                    tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
                    break;
                case UITableViewCellEditingStyle.None:
                    Console.WriteLine("CommitEditingStyle:None called");
                    break;
            }
        }


        public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
        {
            return true; // return false if you wish to disable editing for a specific indexPath or for all rows
        }

        public override string TitleForDeleteConfirmation(UITableView tableView, NSIndexPath indexPath)
        {   // Optional - default text is 'Delete'
            return "Delete  (" + students[indexPath.Row]._id + ")";
        }
        
    }
    
}
