namespace VotingSystem
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.FullnameT = new System.Windows.Forms.TextBox();
            this.EmailT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterB = new System.Windows.Forms.Button();
            this.LoginL = new System.Windows.Forms.LinkLabel();
            this.TeacherRb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FullnameT
            // 
            this.FullnameT.Location = new System.Drawing.Point(109, 45);
            this.FullnameT.Name = "FullnameT";
            this.FullnameT.Size = new System.Drawing.Size(143, 20);
            this.FullnameT.TabIndex = 1;
            this.FullnameT.TextChanged += new System.EventHandler(this.FullnameT_TextChanged);
            // 
            // EmailT
            // 
            this.EmailT.Location = new System.Drawing.Point(109, 88);
            this.EmailT.Name = "EmailT";
            this.EmailT.Size = new System.Drawing.Size(210, 20);
            this.EmailT.TabIndex = 3;
            this.EmailT.TextChanged += new System.EventHandler(this.EmailT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterB
            // 
            this.RegisterB.Location = new System.Drawing.Point(83, 154);
            this.RegisterB.Name = "RegisterB";
            this.RegisterB.Size = new System.Drawing.Size(75, 23);
            this.RegisterB.TabIndex = 4;
            this.RegisterB.Text = "Register";
            this.RegisterB.UseVisualStyleBackColor = true;
            this.RegisterB.Click += new System.EventHandler(this.RegisterB_Click);
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Location = new System.Drawing.Point(106, 204);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(33, 13);
            this.LoginL.TabIndex = 5;
            this.LoginL.TabStop = true;
            this.LoginL.Text = "Login";
            this.LoginL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginL_LinkClicked);
            // 
            // TeacherRb
            // 
            this.TeacherRb.AutoSize = true;
            this.TeacherRb.Location = new System.Drawing.Point(37, 131);
            this.TeacherRb.Name = "TeacherRb";
            this.TeacherRb.Size = new System.Drawing.Size(65, 17);
            this.TeacherRb.TabIndex = 6;
            this.TeacherRb.TabStop = true;
            this.TeacherRb.Text = "Teacher";
            this.TeacherRb.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 278);
            this.Controls.Add(this.TeacherRb);
            this.Controls.Add(this.LoginL);
            this.Controls.Add(this.RegisterB);
            this.Controls.Add(this.EmailT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullnameT);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
//            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullnameT;
        private System.Windows.Forms.TextBox EmailT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegisterB;
        private System.Windows.Forms.LinkLabel LoginL;
        private System.Windows.Forms.RadioButton TeacherRb;
    }
}