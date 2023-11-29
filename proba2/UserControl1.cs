using proba2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba2
{
    public partial class UserControl1 : UserControl
    {
        StudentContext context = new StudentContext();
        public UserControl1()
        {
            InitializeComponent();
            listBoxStudent.DisplayMember = "email";
            listBoxSubject.DisplayMember = "subjectname";
            GetStudents();
            GetSubjects();
        }
        private void GetSubjects()
        {
            listBoxSubject.DataSource = (from s in context.Subjects
                                         where s.SubjectName.Contains(textBoxSubject.Text)
                                         select s).ToList();
        }

        private void GetStudents()
        {
            listBoxStudent.DataSource = (from s in context.Students
                                         where s.Email.Contains(textStudent.Text)
                                         select s).ToList();
        }

        private void textStudent_TextChanged(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {
            GetSubjects();
        }

        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = ((Students)listBoxStudent.SelectedItem).StudentId;
            var enrollments = from x in context.Enrollments
                              where x.StudentId == id
                              select new
                              {
                                  Subjectid = x.SubjectId,
                                  SubjectName = x.Subject.SubjectName,
                                  Code = x.Subject.SubjectCode,
                                  Semester = x.Subject.Semester,
                              };
            dataGridView1.DataSource = enrollments.ToList();
        }

        private void buttonAddNewSubject_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Models.Subjects subject = new Models.Subjects();
                subject.SubjectId = int.Parse(form2.textBoxID.Text);
                subject.SubjectName = form2.textBoxName.Text;
                subject.SubjectDescription = form2.textBoxDescr.Text;
                subject.SubjectCode = form2.textBoxCode.Text;
                subject.Semester = (int)form2.numericUpDown1.Value;
                
                try
                {
                    context.Add(subject);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
                GetSubjects();
            }
        }
    }
}
