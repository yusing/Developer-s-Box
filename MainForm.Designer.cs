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
            this.numericconverter = new System.Windows.Forms.Button();
            this.base64converter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hostedit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.regextester = new System.Windows.Forms.Button();
            this.urlencode = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AutoScroll = true;
            this.table.AutoSize = true;
            this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.BackColor = System.Drawing.Color.White;
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Controls.Add(this.numericconverter, 0, 5);
            this.table.Controls.Add(this.base64converter, 0, 5);
            this.table.Controls.Add(this.label3, 0, 4);
            this.table.Controls.Add(this.button1, 0, 3);
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
            this.table.Size = new System.Drawing.Size(584, 331);
            this.table.TabIndex = 0;
            // 
            // numericconverter
            // 
            this.numericconverter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.numericconverter.BackColor = System.Drawing.Color.White;
            this.numericconverter.FlatAppearance.BorderSize = 0;
            this.numericconverter.Image = ((System.Drawing.Image)(resources.GetObject("numericconverter.Image")));
            this.numericconverter.Location = new System.Drawing.Point(109, 184);
            this.numericconverter.Name = "numericconverter";
            this.numericconverter.Size = new System.Drawing.Size(100, 139);
            this.numericconverter.TabIndex = 8;
            this.numericconverter.Text = "Numeric Converter";
            this.numericconverter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.numericconverter.UseVisualStyleBackColor = false;
            // 
            // base64converter
            // 
            this.base64converter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.base64converter.BackColor = System.Drawing.Color.White;
            this.base64converter.FlatAppearance.BorderSize = 0;
            this.base64converter.Image = ((System.Drawing.Image)(resources.GetObject("base64converter.Image")));
            this.base64converter.Location = new System.Drawing.Point(3, 184);
            this.base64converter.Name = "base64converter";
            this.base64converter.Size = new System.Drawing.Size(100, 139);
            this.base64converter.TabIndex = 7;
            this.base64converter.Text = "Base64 Converter";
            this.base64converter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.base64converter.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Converter";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(109, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 139);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hasher";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // hostedit
            // 
            this.hostedit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hostedit.BackColor = System.Drawing.Color.White;
            this.hostedit.FlatAppearance.BorderSize = 0;
            this.hostedit.Image = ((System.Drawing.Image)(resources.GetObject("hostedit.Image")));
            this.hostedit.Location = new System.Drawing.Point(3, 21);
            this.hostedit.Name = "hostedit";
            this.hostedit.Size = new System.Drawing.Size(100, 139);
            this.hostedit.TabIndex = 3;
            this.hostedit.Text = "Host File Editor";
            this.hostedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hostedit.UseVisualStyleBackColor = false;
            this.hostedit.Click += new System.EventHandler(this.hostedit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Misc";
            // 
            // regextester
            // 
            this.regextester.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regextester.BackColor = System.Drawing.Color.White;
            this.regextester.FlatAppearance.BorderSize = 0;
            this.regextester.Image = ((System.Drawing.Image)(resources.GetObject("regextester.Image")));
            this.regextester.Location = new System.Drawing.Point(215, 21);
            this.regextester.Name = "regextester";
            this.regextester.Size = new System.Drawing.Size(100, 139);
            this.regextester.TabIndex = 6;
            this.regextester.Text = "Regex Tester";
            this.regextester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.regextester.UseVisualStyleBackColor = false;
            this.regextester.Click += new System.EventHandler(this.regextester_Click);
            // 
            // urlencode
            // 
            this.urlencode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlencode.BackColor = System.Drawing.Color.White;
            this.urlencode.FlatAppearance.BorderSize = 0;
            this.urlencode.Image = ((System.Drawing.Image)(resources.GetObject("urlencode.Image")));
            this.urlencode.Location = new System.Drawing.Point(215, 184);
            this.urlencode.Name = "urlencode";
            this.urlencode.Size = new System.Drawing.Size(100, 139);
            this.urlencode.TabIndex = 1;
            this.urlencode.Text = "Url Encode / Decode";
            this.urlencode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.urlencode.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 331);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 370);
            this.MinimumSize = new System.Drawing.Size(600, 370);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Developer\'s Box";
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button hostedit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button numericconverter;
        private System.Windows.Forms.Button base64converter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button regextester;
        private System.Windows.Forms.Button urlencode;
    }
}

