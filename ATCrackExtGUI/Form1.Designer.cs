namespace ATCrackExtGUI
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
            this.licenseBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.optifineBox = new System.Windows.Forms.TextBox();
            this.hypixelBox = new System.Windows.Forms.TextBox();
            this.usernamesBtn = new System.Windows.Forms.Button();
            this.optifineBtn = new System.Windows.Forms.Button();
            this.hypixelBtn = new System.Windows.Forms.Button();
            this.launchBtn = new System.Windows.Forms.Button();
            this.openUsernames = new System.Windows.Forms.OpenFileDialog();
            this.saveOptifine = new System.Windows.Forms.SaveFileDialog();
            this.saveHypixel = new System.Windows.Forms.SaveFileDialog();
            this.jpPleaseCommit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // licenseBox
            // 
            this.licenseBox.Location = new System.Drawing.Point(49, 145);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.Size = new System.Drawing.Size(153, 20);
            this.licenseBox.TabIndex = 0;
            this.licenseBox.Text = "License";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 12);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ReadOnly = true;
            this.usernameBox.Size = new System.Drawing.Size(115, 20);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.Text = "usernames.txt";
            // 
            // optifineBox
            // 
            this.optifineBox.Location = new System.Drawing.Point(14, 49);
            this.optifineBox.Name = "optifineBox";
            this.optifineBox.ReadOnly = true;
            this.optifineBox.Size = new System.Drawing.Size(115, 20);
            this.optifineBox.TabIndex = 2;
            this.optifineBox.Text = "optifine.txt";
            // 
            // hypixelBox
            // 
            this.hypixelBox.Location = new System.Drawing.Point(15, 91);
            this.hypixelBox.Name = "hypixelBox";
            this.hypixelBox.ReadOnly = true;
            this.hypixelBox.Size = new System.Drawing.Size(114, 20);
            this.hypixelBox.TabIndex = 3;
            this.hypixelBox.Text = "hypixel.txt";
            // 
            // usernamesBtn
            // 
            this.usernamesBtn.Location = new System.Drawing.Point(135, 12);
            this.usernamesBtn.Name = "usernamesBtn";
            this.usernamesBtn.Size = new System.Drawing.Size(101, 23);
            this.usernamesBtn.TabIndex = 4;
            this.usernamesBtn.Text = "Select Usernames";
            this.usernamesBtn.UseVisualStyleBackColor = true;
            this.usernamesBtn.Click += new System.EventHandler(this.usernamesBtn_Click);
            // 
            // optifineBtn
            // 
            this.optifineBtn.Location = new System.Drawing.Point(135, 41);
            this.optifineBtn.Name = "optifineBtn";
            this.optifineBtn.Size = new System.Drawing.Size(101, 35);
            this.optifineBtn.TabIndex = 5;
            this.optifineBtn.Text = "Optifine Save Locaiton";
            this.optifineBtn.UseVisualStyleBackColor = true;
            this.optifineBtn.Click += new System.EventHandler(this.optifineBtn_Click);
            // 
            // hypixelBtn
            // 
            this.hypixelBtn.Location = new System.Drawing.Point(135, 82);
            this.hypixelBtn.Name = "hypixelBtn";
            this.hypixelBtn.Size = new System.Drawing.Size(101, 36);
            this.hypixelBtn.TabIndex = 6;
            this.hypixelBtn.Text = "Hypixel Save Location";
            this.hypixelBtn.UseVisualStyleBackColor = true;
            this.hypixelBtn.Click += new System.EventHandler(this.hypixelBtn_Click);
            // 
            // launchBtn
            // 
            this.launchBtn.Location = new System.Drawing.Point(15, 180);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(221, 55);
            this.launchBtn.TabIndex = 7;
            this.launchBtn.Text = "Launch ATCrack External!";
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // jpPleaseCommit
            // 
            this.jpPleaseCommit.AutoSize = true;
            this.jpPleaseCommit.Location = new System.Drawing.Point(15, 117);
            this.jpPleaseCommit.Name = "jpPleaseCommit";
            this.jpPleaseCommit.Size = new System.Drawing.Size(56, 17);
            this.jpPleaseCommit.TabIndex = 8;
            this.jpPleaseCommit.Text = "Export";
            this.jpPleaseCommit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 249);
            this.Controls.Add(this.jpPleaseCommit);
            this.Controls.Add(this.launchBtn);
            this.Controls.Add(this.hypixelBtn);
            this.Controls.Add(this.optifineBtn);
            this.Controls.Add(this.usernamesBtn);
            this.Controls.Add(this.hypixelBox);
            this.Controls.Add(this.optifineBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.licenseBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ATCrack External GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox licenseBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox optifineBox;
        private System.Windows.Forms.TextBox hypixelBox;
        private System.Windows.Forms.Button usernamesBtn;
        private System.Windows.Forms.Button optifineBtn;
        private System.Windows.Forms.Button hypixelBtn;
        private System.Windows.Forms.Button launchBtn;
        private System.Windows.Forms.OpenFileDialog openUsernames;
        private System.Windows.Forms.SaveFileDialog saveOptifine;
        private System.Windows.Forms.SaveFileDialog saveHypixel;
        private System.Windows.Forms.CheckBox jpPleaseCommit;
    }
}

