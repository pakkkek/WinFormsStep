using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetNotificationBio(object sender, EventArgs e)
        {
            string title = "Bio";
            string message = "My name is Alexander Kalinin. \n" +
                "I`m 15 y.o. \n" +
                "I`m Software Engineer.";
            var resultDialog = MessageBox.Show(message, title, MessageBoxButtons.OK);
            if (resultDialog == DialogResult.OK)
            {
                string title2 = "Knowledge";
                string message2 = "I know programming languages: C#, C++, C. \n" +
                    "I have a project in C#, \"Dictionary\".";
                var resultDialog2 = MessageBox.Show(message2, title2, MessageBoxButtons.OK);
                if (resultDialog2 == DialogResult.OK)
                {
                    string message3 = "That`s all!";
                    int symbolCount = (message.Length + message2.Length + message3.Length) / 3;
                    MessageBox.Show(message3, "" + symbolCount + "");
                }
            }
        }
    }
}