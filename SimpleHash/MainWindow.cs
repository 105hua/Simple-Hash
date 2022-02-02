using System.Text;
using System.Security.Cryptography;

namespace SimpleHash
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbInputBox_TextChanged(object sender, EventArgs e)
        {

            byte[] encodedInput = Encoding.UTF8.GetBytes(tbInputBox.Text);
            SHA256 hasher = SHA256.Create();
            byte[] hashedInput = hasher.ComputeHash(encodedInput);
            StringBuilder sb = new StringBuilder();

            foreach(byte b in hashedInput)
            {

                sb.Append(b.ToString("X2"));

            }

            tbOutput.Text = sb.ToString();

        }
    }
}