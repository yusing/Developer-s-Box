namespace DeveloperBox
{
    partial class HasherForm
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
            this.text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.algorithm = new System.Windows.Forms.ComboBox();
            this.Hash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text.Location = new System.Drawing.Point(12, 47);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text.Size = new System.Drawing.Size(660, 321);
            this.text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hashing Algorithm: ";
            // 
            // algorithm
            // 
            this.algorithm.FormattingEnabled = true;
            this.algorithm.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA-256",
            "SHA-384",
            "SHA-512",
            "RIPEMD160"});
            this.algorithm.Location = new System.Drawing.Point(156, 10);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(158, 26);
            this.algorithm.TabIndex = 3;
            // 
            // Hash
            // 
            this.Hash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hash.Location = new System.Drawing.Point(320, 8);
            this.Hash.Name = "Hash";
            this.Hash.Size = new System.Drawing.Size(93, 29);
            this.Hash.TabIndex = 4;
            this.Hash.Text = "Hash!";
            this.Hash.UseCompatibleTextRendering = true;
            this.Hash.UseVisualStyleBackColor = false;
            this.Hash.Click += new System.EventHandler(this.Hash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output: ";
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(12, 394);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(660, 58);
            this.output.TabIndex = 6;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.output.UseCompatibleTextRendering = true;
            this.output.DoubleClick += new System.EventHandler(this.Output_DoubleClick);
            // 
            // HasherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hash);
            this.Controls.Add(this.algorithm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Name = "HasherForm";
            this.Text = "HasherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox algorithm;
        private System.Windows.Forms.Button Hash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
    }
}