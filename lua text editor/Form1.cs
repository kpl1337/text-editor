using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Net;

namespace luatexteditor
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }
        string str;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void open_label_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Scripts (*.lua )|*.lua|All files (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                str = File.ReadAllText(dialog.FileName);
                if (str.Contains("") || str.Contains("") || str.Contains("") || str.Contains("") || str.Contains("") || str.Contains("") || str.Contains("") || str.Contains("�"))
                {
                    DialogResult result = MessageBox.Show("File contains foreign characters, it might be obfuscated, do you still want to open it?", "lua text editor", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        this.richTextBox1.Text = str;
                    else
                        this.richTextBox1.Text = "";
                }
                else
                {
                    this.richTextBox1.Text = str;
                }
               
                label1.Text = $"{Path.GetFileName(dialog.FileName)} ";
            }
        }

        private void save_label_Click(object sender, EventArgs e)
        {
            var savedialog = new SaveFileDialog();
            string file;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string filename = savedialog.FileName;
                // save the contents of the rich text box
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                file = Path.GetFileName(filename);    // get name of file
                MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
