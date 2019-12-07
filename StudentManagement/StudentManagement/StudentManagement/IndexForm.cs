using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.StudentManagement
{
    public partial class IndexForm : Form
    {
        private StudentManagement Business;
        public IndexForm()
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.Load += IndexForm_Load;
            this.btnCreate.Click += btnCreate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdStudent.DoubleClick += grdStudents_DoubleClick;
            this.btnStatistic.Click += BtnStatistic_Click;
        }
        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            new StatisticForm().ShowDialog();
            this.ShowAllStudent();
        }

        void grdStudents_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdStudent.SelectedRows.Count == 1)
            {
                var row = this.grdStudent.SelectedRows[0];
                var studentView = (StudentView)row.DataBoundItem;

                new UpdateForm(studentView.Id).ShowDialog();
            }
            this.ShowAllStudent();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdStudent.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this!!", "Comfirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @student = (StudentView)this.grdStudent.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteStudent(@student.Id);
                    MessageBox.Show("Delete class successfully!!");
                    this.ShowAllStudent();
                }
            }
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateForm().ShowDialog();
            this.ShowAllStudent();
        }

        private void ShowAllStudent()
        {
            // this.grdStudent.DataSource = this.Business.GetStudents();
            var students = this.Business.GetStudents();
            var studentViews = new StudentView[students.Length];
            for (int i = 0; i < students.Length; i++)
                studentViews[i] = new StudentView(students[i]);
            this.grdStudent.DataSource = studentViews;
            txtCount.Text = String.Format(students.Length.ToString());
        }
        void IndexForm_Load(object sender, EventArgs e)
        {
            this.ShowAllStudent();
        }


    }
}
