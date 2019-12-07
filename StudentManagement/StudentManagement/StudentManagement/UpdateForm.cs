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
    public partial class UpdateForm : Form
    {
        private int StudentId;
        private StudentManagement Business;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.StudentId = id;
            this.Business = new StudentManagement();
            this.Load += UpdateForm_Load;
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }
        void UpdateForm_Load(object sender, EventArgs e)
        {
            var student = this.Business.GetStudent(this.StudentId);
            this.cboClass.DataSource = this.Business.GetClasses();
            this.cboClass.DisplayMember = "Name";
            this.cboClass.ValueMember = "id";
            this.cboClass.SelectedValue = student.Class_id;

            this.cboSubject.DataSource = this.Business.getSubjects();
            this.cboSubject.DisplayMember = "Subject_Name";
            this.cboSubject.ValueMember = "Subject_ID";
            this.cboSubject.SelectedValue = student.Subject_ID;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtName.Text;
            var birthday = this.dtpBirthday.Value;
            var class_id = (int)this.cboClass.SelectedValue;
            var email = this.txtEmail.Text;
            var hometown = this.txtHometown.Text;
            var subject = (string)this.cboSubject.SelectedValue;
            this.Business.UpdateStudent(this.StudentId, code, name, birthday, class_id, email, hometown, subject);
            MessageBox.Show("Update successfully");
            this.Close();
        }
    }
}
