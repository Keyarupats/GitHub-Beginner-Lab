using System.Collections;

namespace StudentProfile
{
    public partial class StudentProfileForm : Form
    {

        ArrayList id, name;
        public StudentProfileForm()
        {
            InitializeComponent();

            id = new ArrayList();
            id.Add("02000399949");
            id.Add("02000399950");
            id.Add("02000399951");
            id.Add("02000399952");

            name = new ArrayList();
            name.Add("John Doe");
            name.Add("Jane Smith");
            name.Add("Bob Johnson");
            name.Add("Alice Williams");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchInput = txtSearch.Text.Trim();

            bool isFoundById = id.Contains(searchInput);
            bool isFoundByName = name.Contains(searchInput);

            string message = (isFoundById || isFoundByName)
                ? "Match Found: " + searchInput
                : "No match found for: " + searchInput;

            MessageBox.Show(message);
        }
    }
}
