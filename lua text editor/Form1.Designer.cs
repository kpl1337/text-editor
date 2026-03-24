namespace luatexteditor
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.exit_label = new System.Windows.Forms.Label();
            this.open_label = new System.Windows.Forms.Label();
            this.save_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.richTextBox1.Location = new System.Drawing.Point(15, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 538);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "no file selected";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Verdana", 13.25F);
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(197, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(105, 22);
            this.title.TabIndex = 5;
            this.title.Text = "text editor";
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.BackColor = System.Drawing.Color.Transparent;
            this.exit_label.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.exit_label.ForeColor = System.Drawing.Color.White;
            this.exit_label.Location = new System.Drawing.Point(480, 9);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(17, 17);
            this.exit_label.TabIndex = 8;
            this.exit_label.Text = "x";
            this.exit_label.Click += new System.EventHandler(this.exit_label_Click);
            // 
            // open_label
            // 
            this.open_label.AutoSize = true;
            this.open_label.BackColor = System.Drawing.Color.Transparent;
            this.open_label.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.open_label.ForeColor = System.Drawing.Color.White;
            this.open_label.Location = new System.Drawing.Point(12, 15);
            this.open_label.Name = "open_label";
            this.open_label.Size = new System.Drawing.Size(39, 16);
            this.open_label.TabIndex = 9;
            this.open_label.Text = "open";
            this.open_label.Click += new System.EventHandler(this.open_label_Click);
            // 
            // save_label
            // 
            this.save_label.AutoSize = true;
            this.save_label.BackColor = System.Drawing.Color.Transparent;
            this.save_label.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.save_label.ForeColor = System.Drawing.Color.White;
            this.save_label.Location = new System.Drawing.Point(58, 15);
            this.save_label.Name = "save_label";
            this.save_label.Size = new System.Drawing.Size(38, 16);
            this.save_label.TabIndex = 10;
            this.save_label.Text = "save";
            this.save_label.Click += new System.EventHandler(this.save_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 600);
            this.Controls.Add(this.save_label);
            this.Controls.Add(this.open_label);
            this.Controls.Add(this.exit_label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label exit_label;
        private System.Windows.Forms.Label open_label;
        private System.Windows.Forms.Label save_label;
    }
}

