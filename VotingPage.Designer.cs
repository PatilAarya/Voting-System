namespace VotingSystem
{
    partial class VotingPage
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
            this.PartyCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.VoteB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartyCb
            // 
            this.PartyCb.FormattingEnabled = true;
            this.PartyCb.Location = new System.Drawing.Point(184, 90);
            this.PartyCb.Name = "PartyCb";
            this.PartyCb.Size = new System.Drawing.Size(121, 21);
            this.PartyCb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parties";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(97, 209);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // VoteB
            // 
            this.VoteB.Location = new System.Drawing.Point(260, 209);
            this.VoteB.Name = "VoteB";
            this.VoteB.Size = new System.Drawing.Size(75, 23);
            this.VoteB.TabIndex = 3;
            this.VoteB.Text = "Vote";
            this.VoteB.UseVisualStyleBackColor = true;
            this.VoteB.Click += new System.EventHandler(this.VoteB_Click);
            // 
            // VotingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 331);
            this.Controls.Add(this.VoteB);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartyCb);
            this.Name = "VotingPage";
            this.Text = "VotingPage";
            this.Load += new System.EventHandler(this.VotingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PartyCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button VoteB;
    }
}