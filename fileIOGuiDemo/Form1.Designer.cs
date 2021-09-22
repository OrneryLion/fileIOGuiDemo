
namespace fileIOGuiDemo
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
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_uRL = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_uRL = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_addToList = new System.Windows.Forms.Button();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.btn_readFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(51, 13);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(76, 16);
            this.lbl_firstName.TabIndex = 0;
            this.lbl_firstName.Text = "First Name:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(51, 55);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(76, 16);
            this.lbl_lastName.TabIndex = 1;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // lbl_uRL
            // 
            this.lbl_uRL.AutoSize = true;
            this.lbl_uRL.Location = new System.Drawing.Point(51, 95);
            this.lbl_uRL.Name = "lbl_uRL";
            this.lbl_uRL.Size = new System.Drawing.Size(38, 16);
            this.lbl_uRL.TabIndex = 2;
            this.lbl_uRL.Text = "URL:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(154, 12);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(178, 22);
            this.txt_firstName.TabIndex = 3;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(154, 52);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(178, 22);
            this.txt_lastName.TabIndex = 4;
            // 
            // txt_uRL
            // 
            this.txt_uRL.Location = new System.Drawing.Point(154, 95);
            this.txt_uRL.Name = "txt_uRL";
            this.txt_uRL.Size = new System.Drawing.Size(178, 22);
            this.txt_uRL.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(399, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(372, 404);
            this.listBox1.TabIndex = 6;
            // 
            // btn_addToList
            // 
            this.btn_addToList.Location = new System.Drawing.Point(231, 138);
            this.btn_addToList.Name = "btn_addToList";
            this.btn_addToList.Size = new System.Drawing.Size(101, 23);
            this.btn_addToList.TabIndex = 7;
            this.btn_addToList.Text = "Add to list -->";
            this.btn_addToList.UseVisualStyleBackColor = true;
            this.btn_addToList.Click += new System.EventHandler(this.btn_addToList_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Location = new System.Drawing.Point(135, 252);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(102, 23);
            this.btn_saveFile.TabIndex = 8;
            this.btn_saveFile.Text = "Save to file";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // btn_readFile
            // 
            this.btn_readFile.Location = new System.Drawing.Point(135, 313);
            this.btn_readFile.Name = "btn_readFile";
            this.btn_readFile.Size = new System.Drawing.Size(102, 23);
            this.btn_readFile.TabIndex = 9;
            this.btn_readFile.Text = "Read from file";
            this.btn_readFile.UseVisualStyleBackColor = true;
            this.btn_readFile.Click += new System.EventHandler(this.btn_readFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_readFile);
            this.Controls.Add(this.btn_saveFile);
            this.Controls.Add(this.btn_addToList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_uRL);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.lbl_uRL);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_firstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_uRL;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_uRL;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_addToList;
        private System.Windows.Forms.Button btn_saveFile;
        private System.Windows.Forms.Button btn_readFile;
    }
}

