using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;

namespace DeveloperBox
{

    public partial class HostFileEditor : BaseForm
    {
        private StreamReader reader;
        private StreamWriter writer;
        private string hostfileloc()
        {
            return 
                Environment.GetEnvironmentVariable("windir") +
                @"\System32\drivers\etc\hosts";
        }

        public HostFileEditor()
        {
            InitializeComponent();
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                if (MessageBox.Show(
                    "This feature needs administrator privilege.\nWould you like to restart in administrator mode?",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    using (var p = new Process())
                    {
                        p.StartInfo.FileName = Environment.CommandLine.Replace("\"", "");
                        p.StartInfo.UseShellExecute = true;
                        p.StartInfo.Verb = "runas";
                        p.Start();
                    }
                    Application.Exit();
                }
                else
                {
                    Text += " (Read-Only)";
                    host.ReadOnly = true;
                }
            }

            reader = new StreamReader(File.OpenRead(hostfileloc()));
            host.Text = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();
        }

        private void HostFileEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (host.ReadOnly)
                return;
            writer = new StreamWriter(File.OpenWrite(hostfileloc()));
            writer.Write(host.Text);
        }
    }
}
