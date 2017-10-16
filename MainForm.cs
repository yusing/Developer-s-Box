using System;

namespace DeveloperBox
{
    public partial class MainForm : BaseForm
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

        private void Hasher_Click(object sender, EventArgs e)
        {
            ShowForm(new HasherForm());
        }
    }
}
