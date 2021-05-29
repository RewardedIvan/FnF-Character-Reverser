
namespace FnF_Character_Reverser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertChartToNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.goToRevertedChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note: The voices and the instrumental I can\'t change you have to do that yourself" +
    ", also camera is broken idk why.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.CausesValidation = false;
            this.richTextBox1.Location = new System.Drawing.Point(16, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(755, 363);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Reverted chart goes here you can copy or click the save button once you opened th" +
    "e chart.";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // openFromClipboardToolStripMenuItem
            // 
            this.openFromClipboardToolStripMenuItem.Name = "openFromClipboardToolStripMenuItem";
            this.openFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.openFromClipboardToolStripMenuItem.Text = "Open from clipboard";
            this.openFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.openFromClipboardToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.saveToolStripMenuItem.Text = "Save as";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(290, 34);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // revertChartToNormalToolStripMenuItem
            // 
            this.revertChartToNormalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2,
            this.revertToolStripMenuItem});
            this.revertChartToNormalToolStripMenuItem.Name = "revertChartToNormalToolStripMenuItem";
            this.revertChartToNormalToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.revertChartToNormalToolStripMenuItem.Text = "Revert chart to normal";
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.revertToolStripMenuItem.Text = "Revert";
            this.revertToolStripMenuItem.Click += new System.EventHandler(this.revertToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFromClipboardToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.revertChartToNormalToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox2.Text = "Revert from";
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.goToRevertedChartToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox1.Text = "Chart";
            // 
            // goToRevertedChartToolStripMenuItem
            // 
            this.goToRevertedChartToolStripMenuItem.Name = "goToRevertedChartToolStripMenuItem";
            this.goToRevertedChartToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.goToRevertedChartToolStripMenuItem.Text = "Go to reverted chart";
            this.goToRevertedChartToolStripMenuItem.Click += new System.EventHandler(this.goToRevertedChartToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FnF Character Reverser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertChartToNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem goToRevertedChartToolStripMenuItem;
    }
}

