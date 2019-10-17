using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace StudentTV2
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            var students = new List <Student>();
            students.Add(new Student("Philipe Cuillard", "004rt", 23, "Informatique"));
            students.Add(new Student("Camilla Gagnon", "005rt", 31, "Informatique"));
            students.Add(new Student("Silvio Giron", "006rt", 43, "Contabilité"));
            students.Add(new Student("Louise Lacroix", "007rt", 25, "Informatique"));
            students.Add(new Student("Serge Lepont", "009rt", 28, "Contabilite"));
            students.Add(new Student("Martine Cuillard", "008rt", 23, "Anglais"));
            students.Add(new Student("Roger Federex", "004rgt", 33, "Anglais"));
            students.Add(new Student("Philipe Tremblant", "008prt", 21, "Contabilité"));

            foreach (Student s in students)//testing student getters
            {
                Console.WriteLine(s._fullName);
            }

            StudentTable.Source = new TableViewSource(students);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}