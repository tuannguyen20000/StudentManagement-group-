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
    public partial class CreateForm : Form
    {
        private StudentManagement Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.Load += CreateForm_Load;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtName.Text;
            var birthday = this.dtpBirthday.Value;
            var class_id = (int)this.cboClass.SelectedValue;
            var email = this.txtEmail.Text;
            var hometown = this.txtHometown.Text;
            var subject = (string)this.cboSubject.SelectedValue;
            this.Business.CreateStudent(code, name, birthday, class_id, email, hometown, subject);
            MessageBox.Show("Create student successfully");
            this.Close();
        }

        void CreateForm_Load(object sender, EventArgs e)
        {
            this.cboClass.DataSource = this.Business.GetClasses();
            this.cboClass.DisplayMember = "Name";
            this.cboClass.ValueMember = "id";

            this.cboSubject.DataSource = this.Business.getSubjects();
            this.cboSubject.DisplayMember = "Subject_Name";
            this.cboSubject.ValueMember = "Subject_ID";
        }
    }
}
