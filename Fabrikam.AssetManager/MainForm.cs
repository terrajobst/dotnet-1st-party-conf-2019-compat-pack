using Fabrikam.Logging;
using System;
using System.Windows.Forms;

namespace Fabrikam.AssetManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MyLogger.Instance.Logged += MyLogger_Logged;

            MyLogger.Instance.WriteLine("Application started");

            var settings = new
            {
                MainWindowSize = Size,
                MainWindowLocation = Location
            };

            MyLogger.Instance.WriteLine("Loading settings...");
            MyLogger.Instance.WriteLine(settings);
        }

        private void MyLogger_Logged(string message)
        {
            loggingListBox.Items.Add(message);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
