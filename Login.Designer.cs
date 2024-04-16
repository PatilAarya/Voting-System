namespace VotingSystem
{
    partial class Login
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
            this.RegisterL = new System.Windows.Forms.LinkLabel();
            this.LoginB = new System.Windows.Forms.Button();
            this.EmailT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullnameT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterL
            // 
            this.RegisterL.AutoSize = true;
            this.RegisterL.Location = new System.Drawing.Point(125, 247);
            this.RegisterL.Name = "RegisterL";
            this.RegisterL.Size = new System.Drawing.Size(46, 13);
            this.RegisterL.TabIndex = 11;
            this.RegisterL.TabStop = true;
            this.RegisterL.Text = "Register";
            this.RegisterL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterL_LinkClicked);
            // 
            // LoginB
            // 
            this.LoginB.Location = new System.Drawing.Point(102, 197);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(75, 23);
            this.LoginB.TabIndex = 10;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // EmailT
            // 
            this.EmailT.Location = new System.Drawing.Point(128, 131);
            this.EmailT.Name = "EmailT";
            this.EmailT.Size = new System.Drawing.Size(210, 20);
            this.EmailT.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // FullnameT
            // 
            this.FullnameT.Location = new System.Drawing.Point(128, 88);
            this.FullnameT.Name = "FullnameT";
            this.FullnameT.Size = new System.Drawing.Size(143, 20);
            this.FullnameT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Full Name";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 349);
            this.Controls.Add(this.RegisterL);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.EmailT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullnameT);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel RegisterL;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.TextBox EmailT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullnameT;
        private System.Windows.Forms.Label label1;
    }
}

