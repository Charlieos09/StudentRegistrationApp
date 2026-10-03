namespace StudentRegistrationApp
{
    public partial class frmStudentRegistrationApp : Form
    {
        public frmStudentRegistrationApp()
        {
            InitializeComponent();
            DateCombo();
           
            browseButton.Click += BrowseButton_Click;
        }
        private void frmStudentRegistrationApp_Load(object sender, EventArgs e)
        {
            
        }
        private void DateCombo()
        {

            dayCombo.Items.Clear();
            for (int d = 1; d <= 31; d++)
            {
                dayCombo.Items.Add(d.ToString("D2"));
            }

            monthCombo.Items.Clear();
            for (int m = 1; m <= 12; m++)
            {
                monthCombo.Items.Add(m.ToString("D2"));
            }

            yearCombo.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int y = currentYear; y >= 1900; y--)
            {
                yearCombo.Items.Add(y.ToString());
            }


            courseCombo.Items.Clear();
            courseCombo.Items.AddRange(new object[] { "Bachelor of Science in Computer Engineering", "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology" });
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {

            string firstName = fnBox.Text;
            string middleName = mnBox.Text;
            string lastName = lnBox.Text;
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(middleName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gender;
            if (maleRad.Checked)
            {
                gender = "Male";
            }
            else if (femaleRad.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please Select a Gender");
                return;
            }
            string dob = $"{dayCombo.SelectedItem}/{monthCombo.SelectedItem}/{yearCombo.SelectedItem}";
            string course = courseCombo.SelectedItem != null ? courseCombo.SelectedItem.ToString() : courseCombo.Text;
            if (string.IsNullOrWhiteSpace(course) || course == "-Select Program-")
            {
                MessageBox.Show("Please select a program to apply.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = $"Student Registration Successful!\n\nName: {firstName} {middleName} {lastName}\nDate of Birth: {dob}\nGender: {gender}\nProgram: {course}";
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // allow common image file types
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Select a profile image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    imagebox.Image = img;
                    imagebox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to load image: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
