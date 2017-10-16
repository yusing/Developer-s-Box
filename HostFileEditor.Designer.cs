namespace DeveloperBox
{
    partial class HostFileEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.host = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // host
            // 
            this.host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.host.Dock = System.Windows.Forms.DockStyle.Fill;
            this.host.Location = new System.Drawing.Point(0, 0);
            this.host.MaxLength = 2147483647;
            this.host.Multiline = true;
            this.host.Name = "host";
            this.host.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.host.Size = new System.Drawing.Size(684, 511);
            this.host.TabIndex = 0;
            // 
            // HostFileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.host);
            this.Name = "HostFileEditor";
            this.Text = "Host File Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HostFileEditor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox host;
    }
}