using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpicetifyInstaller
{
    public partial class SpicetifyInstaller : Form
    {
        public SpicetifyInstaller()
        {
            InitializeComponent();
            Install.Font = new Font("Arial", 12, FontStyle.Bold);
            Install2.Font = new Font("Arial", 12, FontStyle.Bold);

            // Hide scrollbars (for both textboxes):
            outputTextBox.ScrollBars = ScrollBars.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Install_Click(object sender, EventArgs e)
        {
            ExecutePowerShellCommand("powershell.exe", "-Command \"iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-cli/master/install.ps1 | iex\"", outputTextBox);
        }

        private void Install2_Click(object sender, EventArgs e)
        {
            ExecutePowerShellCommand("powershell.exe", "-Command \"iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-marketplace/main/resources/install.ps1 | iex\"", outputTextBox);
        }

        private void ExecutePowerShellCommand(string command, string arguments, TextBox outputTextBox)
        {
            Process process = new Process();
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            // Changes for Hidden Execution:
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Hide the window
            process.StartInfo.CreateNoWindow = true;                // Prevent even a momentarily visible window

            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.Start();
            process.BeginOutputReadLine();

        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                this.Invoke((MethodInvoker)delegate  // For cross-thread safety
                {
                    outputTextBox.AppendText(outLine.Data + Environment.NewLine);
                });
            }
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}