using Student_Information_System.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            IDtextBox.ReadOnly = false;
            LastnametextBox.ReadOnly = false;
            FirstnametextBox.ReadOnly = false;
            MiddlenametextBox.ReadOnly = false;
            AgetextBox.ReadOnly = false;
            SextextBox.ReadOnly = false;
            AddresstextBox.ReadOnly = false;
            CollegetextBox.ReadOnly = false;
            CoursetextBox.ReadOnly = false;
            YearLeveltextBox.ReadOnly = false;
            SectiontextBox.ReadOnly = false;
            SemestertextBox.ReadOnly = false;
            ScholarshiptextBox.ReadOnly = false;

            Addbutton.Enabled = false;
            Savebutton.Enabled = true;
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            StudentInfo info = new StudentInfo()
            {
                ID = Int32.Parse(IDtextBox.Text),
                Lastname = LastnametextBox.Text,
                Firstname = FirstnametextBox.Text,
                Middlename = MiddlenametextBox.Text,
                Age = Int32.Parse(AgetextBox.Text),
                Sex = SextextBox.Text,
                Address = AddresstextBox.Text,
                College = CollegetextBox.Text,
                Course = CoursetextBox.Text,
                YearLevel = YearLeveltextBox.Text,
                Section = SectiontextBox.Text,
                Semester = SemestertextBox.Text,
                Scholarship = ScholarshiptextBox.Text
            };

            Istudent app = new Student();
            app.SaveData(info);
            MessageBox.Show("Successfully Save");

            Savebutton.Enabled = false;
            Addbutton.Enabled = true;
        }
    }
}
   