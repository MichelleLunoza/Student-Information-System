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

        
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Updatebutton.Enabled = false;
            Addbutton.Enabled = false;
            Deletebutton.Enabled = false;
            Editbutton.Enabled = false;
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

            IDtextBox.Clear();
            LastnametextBox.Clear();
            FirstnametextBox.Clear();
            MiddlenametextBox.Clear();
            AgetextBox.Clear();
            SextextBox.Clear();
            AddresstextBox.Clear();
            CollegetextBox.Clear();
            CoursetextBox.Clear();
            YearLeveltextBox.Clear();
            SectiontextBox.Clear();
            SemestertextBox.Clear();
            ScholarshiptextBox.Clear();

            IDtextBox.ReadOnly = true;
            LastnametextBox.ReadOnly = true;
            FirstnametextBox.ReadOnly = true;
            MiddlenametextBox.ReadOnly = true;
            AgetextBox.ReadOnly = true;
            SextextBox.ReadOnly = true;
            AddresstextBox.ReadOnly = true;
            CollegetextBox.ReadOnly = true;
            CoursetextBox.ReadOnly = true;
            YearLeveltextBox.ReadOnly = true;
            SectiontextBox.ReadOnly = true;
            SemestertextBox.ReadOnly = true;
            ScholarshiptextBox.ReadOnly = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDbDataSet.Student_Table' table. You can move, or remove it, as needed.
            this.student_TableTableAdapter.Fill(this.studentDbDataSet.Student_Table);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Editbutton_Click(object sender, EventArgs e)
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

            Editbutton.Enabled = false;
            Savebutton.Enabled = false;
            Addbutton.Enabled = false;
            Deletebutton.Enabled = false;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            LastnametextBox.Clear();
            FirstnametextBox.Clear();
            MiddlenametextBox.Clear();
            AgetextBox.Clear();
            SextextBox.Clear();
            AddresstextBox.Clear();
            CollegetextBox.Clear();
            CoursetextBox.Clear();
            YearLeveltextBox.Clear();
            SectiontextBox.Clear();
            SemestertextBox.Clear();
            ScholarshiptextBox.Clear();
        }
    }
}
 
   