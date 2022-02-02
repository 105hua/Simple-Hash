using System.Text; // This library is required so that we can encode strings into byte arrays, making them compatible with the Cryptography library. This library will also play a role in decoding the byte arrays into the final hashed string.
using System.Security.Cryptography; // This library is required so that we can hash byte arrays.

namespace SimpleHash // Declare the namespace, named SimpleHash.
{ // Beginning of namespace.
    public partial class MainWindow : Form // Declare a public partial class for the Main Window of the program.
    { // Beginning of class.
        public MainWindow() // Declare a public function that will display the window.
        { // Beginning of MainWindow function.
            InitializeComponent(); // Call initializecomponent, which will display the window.
        } // Ending of MainWindow function.

        private void tbInputBox_TextChanged(object sender, EventArgs e) // Input Box Text Changed Event.
        { // Beginning of event code.

            if (tbInputBox.TextLength == 0) // If the length of the text inside of the input box is zero.
            { // Beginning of if statement.

                tbOutput.Text = String.Empty; // Set the output text box's text to an empty string.
                return; // Return, ending the execution of the event code.

            } // Ending of if statement.

            int selectedIndex = cbHashType.SelectedIndex; // Get the selected index from the Hash Types Combo Box.
            byte[] encodedBytes = Encoding.UTF8.GetBytes(tbInputBox.Text); // Encode the input text into a byte array.
            byte[] hashedBytes; // Declare a second byte array variable to hold the hashed byte array.
            StringBuilder sb = new StringBuilder(); // Declare a string builder so that we can convert the hashed byte array back to a string.

            if (selectedIndex == 0) // If the selected index is 0, then we know that the user has selected MD5.
            { // Beginning of if statement code.

                MD5 hasher = MD5.Create(); // Create a new MD5 variable which will be what hashes our byte array.
                hashedBytes = hasher.ComputeHash(encodedBytes); // Compute a hash from the encoded byte array and store the result in the hashedBytes variable.

                for (int i = 0; i < hashedBytes.Length; i++) { sb.Append(hashedBytes[i].ToString("X2")); }; // This is a for loop that will append each hashed byte converted to a string in X2 format to the String Builder.

            } else if (selectedIndex == 1) // If the selected index is 1, then we know that the user has selected SHA1.
            { // Beginning of else statement code.

                SHA1 hasher = SHA1.Create(); // Create a new SHA1 variable which will be what hashes our byte array.
                hashedBytes = hasher.ComputeHash(encodedBytes); // Compute a hash from the encoded byte array and store the result in the hashedBytes variable.
                for (int i = 0; i < hashedBytes.Length; i++) { sb.Append(hashedBytes[i].ToString("X2")); }; // This is a for loop that will append each hashed byte converted to a string in X2 format to the String Builder.

            } else if (selectedIndex == 2) // If the selected index is 2, then we know that the user has selected SHA256.
            { // Beginning of else statement code.

                SHA256 hasher = SHA256.Create(); // Create a new SHA256 variable which will be what hashes our byte array.
                hashedBytes = hasher.ComputeHash(encodedBytes); // Compute a hash from the encoded byte array and store the result in the hashedBytes variable.
                for (int i = 0; i < hashedBytes.Length; i++) { sb.Append(hashedBytes[i].ToString("X2")); }; // This is a for loop that will append each hashed byte converted to a string in X2 format to the String Builder.

            } else if (selectedIndex == 3) // If the selected index is 3, then we know that the user has selected SHA384.
            { // Beginning of else statement code.

                SHA384 hasher = SHA384.Create(); // Create a new SHA384 variable which will be what hashes our byte array.
                hashedBytes = hasher.ComputeHash(encodedBytes); // Compute a hash from the encoded byte array and store the result in the hashedBytes variable.
                for (int i = 0; i < hashedBytes.Length; i++) { sb.Append(hashedBytes[i].ToString("X2")); }; // This is a for loop that will append each hashed byte converted to a string in X2 format to the String Builder.

            } else if (selectedIndex == 4) // If the selected index is 4, then we know that the user has selected SHA512.
            { // Beginning of else statement code.

                SHA512 hasher = SHA512.Create(); // Create a new SHA512 variable which will be what hashes our byte array.
                hashedBytes = hasher.ComputeHash(encodedBytes); // Compute a hash from the encoded byte array and store the result in the hashedBytes variable.
                for (int i = 0; i < hashedBytes.Length; i++) { sb.Append(hashedBytes[i].ToString("X2")); }; // This is a for loop that will append each hashed byte converted to a string in X2 format to the String Builder.

            } else // In any other case.
            { // Beginning of else statement code.

                MessageBox.Show("Uh oh, it looks like hashing algorithm isn't selected."); // Show a message box that informs the user that a hashing algorithm is selected.

                // If this message box is shown then it is likely a bug in this case.

            } // Ending of if statement.

            tbOutput.Text = sb.ToString(); // Set the output text box's text to the final hash.
 
        } // End of event code.

        private void MainWindow_Load(object sender, EventArgs e) // Window Load Event.
        { // Beginning of event code.

            cbHashType.SelectedIndex = 0; // Set the selected hash type to MD5, which is in index 0.

        } // Ending of event code.

        private void cbHashType_SelectedIndexChanged(object sender, EventArgs e) // Hash Type Changed Event.
        { // Beginning of event code.

            tbInputBox.Text = "Input String"; // Set the input box text to default.
            tbOutput.Text = "Output"; // Set the output box text to default.

        } // Ending of event code.

    } // Ending of class.

} // Ending of namespace.