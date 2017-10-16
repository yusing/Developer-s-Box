using System;
using System.Windows.Forms;

namespace DeveloperBox
{
    public partial class MainForm : Form
    {
        public void ShowForm(BaseForm form)
        {
            form.Show();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void hostedit_Click(object sender, EventArgs e)
        {
            ShowForm(new HostFileEditor());
        }

        private void regextester_Click(object sender, EventArgs e)
        {
            ShowForm(new RegexTesterForm());
        }
    }
}
