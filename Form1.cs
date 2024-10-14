using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace Alburan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Year();
        }
        public void Year()
        {
            for (int Y = 1990; Y < +2024; Y++)
            {
                cbYear.Items.Add(Y);
            }
        }
        private void LastN_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstN_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleN_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string LastName = LastN.Text;
            string FirstName = FirstN.Text;
            string MiddleName = MiddleN.Text;
            string gender = rbMale.Checked ? "Male" : "Female";
            string dateOfBirth = $"{cbDay.Text}/{cbMonth.Text}/{cbYear.Text}";
            string program = cbProgram.Text;

            if (string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(program))
            {
                MessageBox.Show("Please fill in all required fields", "Error");
                return;
            }

            DisplayStudentInfo(LastName, FirstName, MiddleName, gender, dateOfBirth, program);

        }

        private void DisplayStudentInfo(string lastName, string firstName, string middleName, string gender, string dateOfBirth, string program)
        {
            MessageBox.Show($"Student Name: {lastName}, {firstName} , {middleName}\n" +
                            $"Gender: {gender}\n" +
                            $"Date of Birth: {dateOfBirth}\n" +
                            $"Program: {program}", "Student Information");
        }

        private void DisplayStudentInfo(string lastName, string firstName)
        {
            MessageBox.Show($"Student Name: {lastName}, {firstName}", "Student Information");
        }
        private void DisplayStudentInfo(string lastName, string firstName, string middleName)
        {
            MessageBox.Show($"Student Name: {lastName}, {firstName} {middleName}", "Student Information");
        }


        private void DisplayStudentInfo(string lastName, string firstName, string middlename, string gender, string dateOfBirth, string program, string program1)
        {
            MessageBox.Show($"Student Name: {lastName}, {firstName}\n + {middlename}" +
                            $"Gender: {gender}\n" +
                            $"Date of Birth: {dateOfBirth}\n" +
                            $"Program: {program}", "Student Information");
        }

       
    }
}
