using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.StudentManagement
{
    class SubjectView
    {
        public string Subject_ID { get; set; }
        public string Subject_Name { get; set; }
        public string Student { get; set; }
        public SubjectView(Subject monhoc)
        {
            this.Subject_ID = monhoc.Subject_ID;
            this.Subject_Name = monhoc.Subject_Name;
            this.Student = String.Format(monhoc.Students.Count.ToString());
        }
    }
}
