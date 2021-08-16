
namespace PmodLogger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_src = new System.Windows.Forms.TextBox();
            this.textBox_dst = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog_src = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_dst = new System.Windows.Forms.FolderBrowserDialog();
            this.button_start = new System.Windows.Forms.Button();
            this.listBox_src = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eep Folder:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dst Folder:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_src
            // 
            this.textBox_src.Location = new System.Drawing.Point(77, 12);
            this.textBox_src.Name = "textBox_src";
            this.textBox_src.Size = new System.Drawing.Size(340, 23);
            this.textBox_src.TabIndex = 2;
            // 
            // textBox_dst
            // 
            this.textBox_dst.Location = new System.Drawing.Point(77, 41);
            this.textBox_dst.Name = "textBox_dst";
            this.textBox_dst.Size = new System.Drawing.Size(340, 23);
            this.textBox_dst.TabIndex = 3;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(6, 73);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(67, 22);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // listBox_src
            // 
            this.listBox_src.FormattingEnabled = true;
            this.listBox_src.ItemHeight = 15;
            this.listBox_src.Location = new System.Drawing.Point(77, 73);
            this.listBox_src.Name = "listBox_src";
            this.listBox_src.Size = new System.Drawing.Size(340, 184);
            this.listBox_src.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(429, 269);
            this.Controls.Add(this.listBox_src);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_dst);
            this.Controls.Add(this.textBox_src);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PMod-Logger @ZL, 20210816";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_src;
        private System.Windows.Forms.TextBox textBox_dst;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_src;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_dst;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ListBox listBox_src;
    }
}

