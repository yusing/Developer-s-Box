using System.Windows.Forms;

namespace DeveloperBox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.numericconverter = new DeveloperBox.ImageButton();
            this.base64converter = new DeveloperBox.ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Hasher = new DeveloperBox.ImageButton();
            this.hostedit = new DeveloperBox.ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.regextester = new DeveloperBox.ImageButton();
            this.urlencode = new DeveloperBox.ImageButton();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AutoScroll = true;
            this.table.AutoSize = true;
            this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Controls.Add(this.numericconverter, 0, 5);
            this.table.Controls.Add(this.base64converter, 0, 5);
            this.table.Controls.Add(this.label3, 0, 4);
            this.table.Controls.Add(this.Hasher, 0, 3);
            this.table.Controls.Add(this.hostedit, 0, 3);
            this.table.Controls.Add(this.label2, 0, 2);
            this.table.Controls.Add(this.regextester, 3, 3);
            this.table.Controls.Add(this.urlencode, 3, 5);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 6;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(684, 331);
            this.table.TabIndex = 0;
            // 
            // numericconverter
            // 
            this.numericconverter.Image = ((System.Drawing.Image)(resources.GetObject("numericconverter.Image")));
            this.numericconverter.Location = new System.Drawing.Point(109, 186);
            this.numericconverter.Name = "numericconverter";
            this.numericconverter.Size = new System.Drawing.Size(100, 139);
            this.numericconverter.TabIndex = 0;
            this.numericconverter.Text = "Numeric Converter";
            this.numericconverter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // base64converter
            // 
            this.base64converter.Image = ((System.Drawing.Image)(resources.GetObject("base64converter.Image")));
            this.base64converter.Location = new System.Drawing.Point(3, 186);
            this.base64converter.Name = "base64converter";
            this.base64converter.Size = new System.Drawing.Size(100, 139);
            this.base64converter.TabIndex = 1;
            this.base64converter.Text = "Base64 Converter";
            this.base64converter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Converter";
            // 
            // Hasher
            // 
            this.Hasher.Image = ((System.Drawing.Image)(resources.GetObject("Hasher.Image")));
            this.Hasher.Location = new System.Drawing.Point(109, 22);
            this.Hasher.Name = "Hasher";
            this.Hasher.Size = new System.Drawing.Size(100, 139);
            this.Hasher.TabIndex = 4;
            this.Hasher.Text = "Hasher";
            this.Hasher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Hasher.Click += new System.EventHandler(this.Hasher_Click);
            // 
            // hostedit
            // 
            this.hostedit.Image = ((System.Drawing.Image)(resources.GetObject("hostedit.Image")));
            this.hostedit.Location = new System.Drawing.Point(3, 22);
            this.hostedit.Name = "hostedit";
            this.hostedit.Size = new System.Drawing.Size(100, 139);
            this.hostedit.TabIndex = 6;
            this.hostedit.Text = "Host File Editor";
            this.hostedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hostedit.Click += new System.EventHandler(this.hostedit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Misc";
            // 
            // regextester
            // 
            this.regextester.Image = ((System.Drawing.Image)(resources.GetObject("regextester.Image")));
            this.regextester.Location = new System.Drawing.Point(215, 22);
            this.regextester.Name = "regextester";
            this.regextester.Size = new System.Drawing.Size(100, 139);
            this.regextester.TabIndex = 7;
            this.regextester.Text = "Regex Tester";
            this.regextester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.regextester.Click += new System.EventHandler(this.regextester_Click);
            // 
            // urlencode
            // 
            this.urlencode.Image = ((System.Drawing.Image)(resources.GetObject("urlencode.Image")));
            this.urlencode.Location = new System.Drawing.Point(215, 186);
            this.urlencode.Name = "urlencode";
            this.urlencode.Size = new System.Drawing.Size(100, 139);
            this.urlencode.TabIndex = 8;
            this.urlencode.Text = "Url Encode / Decode";
            this.urlencode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.table);
            this.MaximumSize = new System.Drawing.Size(700, 370);
            this.MinimumSize = new System.Drawing.Size(700, 370);
            this.Name = "MainForm";
            this.Text = "Developer\'s Box";
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel table;
        private Label label2;
        private Label label3;
        private ImageButton Hasher;
        private ImageButton hostedit;
        private ImageButton numericconverter;
        private ImageButton base64converter;
        private ImageButton regextester;
        private ImageButton urlencode;
    }
}

