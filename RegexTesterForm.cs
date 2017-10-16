using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace DeveloperBox
{
    public partial class RegexTesterForm : BaseForm
    {
        GroupCollection groups;
        Thread t1;

        public void startThread(bool listmode)
        {
            Color RandomColor()
            {
                var ran = Enumerable.Range(0, 255)
                .OrderBy(x => Guid.NewGuid().GetHashCode())
                .Take(3).ToArray();
                return Color.FromArgb(ran[0],ran[1],ran[2]);
            }

            t1 = new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    result.ResetText();
                    try
                    {
                        groups = Regex.Match(source.Text, expression.Text).Groups;
                    } catch( Exception ex )
                    {
                        result.Text = ex.Message;
                    }
                    source.SelectAll();
                    source.SelectionBackColor = Color.White;
                    source.SelectionColor = Color.Black;
                }));
                if (listmode)
                {
                    int i = 0;
                    foreach (Group g in groups)
                    {
                        if(i == 0)
                        {
                            i++;
                            continue;
                        }
                        Invoke(new Action(() =>
                        {
                            result.Text += $"{++i} : {g.Value.Replace("\n","")}\r\n";
                        }));
                    }
                }
                else
                {
                    foreach (Group g in groups)
                    {
                        Invoke(new Action(() =>
                        {
                            source.Select(source.Text.IndexOf(g.Value), g.Value.Length);
                            source.SelectionBackColor = RandomColor();
                            source.SelectionColor = Color.White;
                        }));
                    }
                }
            });
            t1.Start();
        }

        public RegexTesterForm()
        {
            InitializeComponent();
        }

        private void listmode_CheckedChanged(object sender, EventArgs e)
        {
            startThread(listmode.Checked);
        }

        private void highlightmode_CheckedChanged(object sender, EventArgs e)
        {
            if (!listmode.Checked)
                startThread(false);
        }

        private void apply_Click(object sender, EventArgs e)
        {
            startThread(listmode.Checked);
        }
    }
}
