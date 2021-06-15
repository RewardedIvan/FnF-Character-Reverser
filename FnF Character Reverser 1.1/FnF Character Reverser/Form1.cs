using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FnF_Character_Reverser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList DataReverted = new ArrayList();
        ArrayList DataHistory = new ArrayList();
        string CurSFN = "Unknowen";

        void revert(string src, string SafeFileName)
        {
            toolStripComboBox2.Items.Add(SafeFileName);
            DataReverted.Add(src);
            
            src = src.Replace(",0,", ",bfZE,");
            src = src.Replace(",1,", ",bfON,");
            src = src.Replace(",2,", ",bfTW,");
            src = src.Replace(",3,", ",bfTH,");
            src = src.Replace(",4,", ",momFO,");
            src = src.Replace(",5,", ",momFI,");
            src = src.Replace(",6,", ",momSI,");
            src = src.Replace(",7,", ",momSE,");

            src = src.Replace(",momFO,", ",0,");
            src = src.Replace(",momFI,", ",1,");
            src = src.Replace(",momSI,", ",2,");
            src = src.Replace(",momSE,", ",3,");
            src = src.Replace(",bfZE,", ",4,");
            src = src.Replace(",bfON,", ",5,");
            src = src.Replace(",bfTW,", ",6,");
            src = src.Replace(",bfTH,", ",7,");

            /*src = src.Replace("\"mustHitSection\":false", "\"mustHitSection\":REMARKABLE2");
            src = src.Replace("\"mustHitSection\":true", "\"mustHitSection\":REMARKABLE1");
            src = src.Replace("\"mustHitSection\":REMARKABLE1", "\"mustHitSection\":false");
            src = src.Replace("\"mustHitSection\":REMARKABLE2", "\"mustHitSection\":true");*/
            richTextBox1.Text = src;
           
            toolStripComboBox1.Items.Add(SafeFileName);
            DataHistory.Add(src);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "chart|*.json";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string src = sr.ReadToEnd();
                    richTextBox1.Text = src;
                    CurSFN = openFileDialog1.SafeFileName;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("You either opened an empty chart or haven't opened anything.", "Error saving.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            saveFileDialog1.Filter = "chart|*.json";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("You either opened an empty chart or haven't opened anything.", "Error clearing.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            richTextBox1.Clear();
        }

        private void openFromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() == "")
            {
                MessageBox.Show("You either opened an empty chart or haven't opened anything.", "Error opening.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            revert(Clipboard.GetText(), "Clipboard");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void revertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataReverted.Count == 0)
            {
                MessageBox.Show("You have no history.", "Error reverting.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            richTextBox1.Text = DataReverted.ToArray()[toolStripComboBox2.SelectedIndex].ToString();
        }

        private void goToRevertedChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataHistory.Count == 0)
            {
                MessageBox.Show("You have no history.", "Error reverting.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            richTextBox1.Text = DataHistory.ToArray()[toolStripComboBox1.SelectedIndex].ToString();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("You either opened an empty chart or haven't opened anything.", "Error saving.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }



        private void saveToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("You either opened an empty chart or haven't opened anything.", "Error balancing.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form2 f2 = new Form2();
            f2.src = richTextBox1.Text;
            f2.ShowDialog();
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("You either opened an empty chart or haven't opened anything.", "Error reversing.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            revert(richTextBox1.Text, CurSFN);
        }
    }
}
