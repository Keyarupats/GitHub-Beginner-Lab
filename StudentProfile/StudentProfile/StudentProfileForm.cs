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

            if (string.IsNullOrEmpty(searchInput))
            {
                MessageBox.Show("Please enter a Student ID or Name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Search by Student ID
            int index = id.IndexOf(searchInput);

            // If not found by ID, search by Name (case-insensitive)
            if (index == -1)
            {
                for (int i = 0; i < name.Count; i++)
                {
                    if (name[i].ToString().Equals(searchInput, StringComparison.OrdinalIgnoreCase))
                    {
                        index = i;
                        break;
                    }
                }
            }

            // Display result based on search outcome
            if (index != -1)
            {
                MessageBox.Show($"Student Found:\n\nID: {id[index]}\nName: {name[index]}", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No matching student record found.", "Result Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
