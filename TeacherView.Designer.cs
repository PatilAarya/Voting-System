namespace VotingSystem
{
    partial class TeacherView
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
            this.ResultBtn = new System.Windows.Forms.Button();
            this.PartiesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME";
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(45, 133);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(141, 23);
            this.ResultBtn.TabIndex = 5;
            this.ResultBtn.Text = "Check Result";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // PartiesBtn
            // 
            this.PartiesBtn.Location = new System.Drawing.Point(232, 133);
            this.PartiesBtn.Name = "PartiesBtn";
            this.PartiesBtn.Size = new System.Drawing.Size(141, 23);
            this.PartiesBtn.TabIndex = 6;
            this.PartiesBtn.Text = "Check Parties";
            this.PartiesBtn.UseVisualStyleBackColor = true;
            this.PartiesBtn.Click += new System.EventHandler(this.PartiesBtn_Click);
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 279);
            this.Controls.Add(this.PartiesBtn);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.label1);
            this.Name = "TeacherView";
            this.Text = "TeacherView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.Button PartiesBtn;
    }
}