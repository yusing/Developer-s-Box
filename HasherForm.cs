using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace DeveloperBox
{
    public partial class HasherForm : BaseForm
    {
        public HasherForm()
        {
            InitializeComponent();
            algorithm.SelectedIndex = 0;
        }

        public string Output { get { return output.Text; } set { output.Text = Output; } }
        public string Algorithm { get { return algorithm.Text; } }

        private void Output_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(Output);
        }

        private void Hash_Click(object sender, EventArgs e)
        {
            using (var algorithm = HashAlgorithm.Create(Algorithm))
            {
                byte[] hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(text.Text));
                var sb = new StringBuilder();
                foreach(byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                output.Text = sb.ToString();
            }
        }
    }
}
