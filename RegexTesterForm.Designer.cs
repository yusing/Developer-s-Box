namespace DeveloperBox
{
    partial class RegexTesterForm
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
            this.container = new System.Windows.Forms.SplitContainer();
            this.listmode = new System.Windows.Forms.RadioButton();
            this.highlightmode = new System.Windows.Forms.RadioButton();
            this.expression = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.listmode);
            this.container.Panel1.Controls.Add(this.highlightmode);
            this.container.Panel1.Controls.Add(this.expression);
            this.container.Panel1.Controls.Add(this.label2);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.source);
            this.container.Panel2.Controls.Add(this.label1);
            this.container.Size = new System.Drawing.Size(481, 511);
            this.container.SplitterDistance = 227;
            this.container.TabIndex = 0;
            // 
            // listmode
            // 
            this.listmode.AutoSize = true;
            this.listmode.Checked = true;
            this.listmode.Location = new System.Drawing.Point(386, 6);
            this.listmode.Name = "listmode";
            this.listmode.Size = new System.Drawing.Size(85, 24);
            this.listmode.TabIndex = 4;
            this.listmode.TabStop = true;
            this.listmode.Text = "List Mode";
            this.listmode.UseCompatibleTextRendering = true;
            this.listmode.UseVisualStyleBackColor = true;
            this.listmode.CheckedChanged += new System.EventHandler(this.listmode_CheckedChanged);
            // 
            // highlightmode
            // 
            this.highlightmode.AutoSize = true;
            this.highlightmode.Location = new System.Drawing.Point(262, 6);
            this.highlightmode.Name = "highlightmode";
            this.highlightmode.Size = new System.Drawing.Size(121, 24);
            this.highlightmode.TabIndex = 3;
            this.highlightmode.Text = "Highlight Mode";
            this.highlightmode.UseCompatibleTextRendering = true;
            this.highlightmode.UseVisualStyleBackColor = true;
            this.highlightmode.CheckedChanged += new System.EventHandler(this.highlightmode_CheckedChanged);
            // 
            // expression
            // 
            this.expression.AutoWordSelection = true;
            this.expression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expression.DetectUrls = false;
            this.expression.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expression.Location = new System.Drawing.Point(12, 36);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(458, 188);
            this.expression.TabIndex = 2;
            this.expression.Text = "";
            this.expression.DoubleClick += new System.EventHandler(this.expression_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expression";
            // 
            // source
            // 
            this.source.AutoWordSelection = true;
            this.source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.source.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source.Location = new System.Drawing.Point(12, 21);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(458, 247);
            this.source.TabIndex = 5;
            this.source.Text = "";
            this.source.DoubleClick += new System.EventHandler(this.source_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(487, 36);
            this.result.Margin = new System.Windows.Forms.Padding(3);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(285, 350);
            this.result.TabIndex = 6;
            this.result.UseCompatibleTextRendering = true;
            // 
            // apply
            // 
            this.apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apply.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.Location = new System.Drawing.Point(487, 441);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(285, 58);
            this.apply.TabIndex = 7;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // RegexTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.container);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "RegexTesterForm";
            this.Text = "Regular Expression Tester";
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel1.PerformLayout();
            this.container.Panel2.ResumeLayout(false);
            this.container.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton listmode;
        private System.Windows.Forms.RadioButton highlightmode;
        private System.Windows.Forms.RichTextBox expression;
        private System.Windows.Forms.RichTextBox source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button apply;
    }
}