namespace StudentProfile
{
    public partial class StudentProfileForm : Form
    {
        public StudentProfileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, John Patrick C. Malapitan", "Student Profile");
        }
    }
}
