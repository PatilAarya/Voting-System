namespace VotingSystem
{
    partial class Parties
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
            this.PartyDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteB = new System.Windows.Forms.Button();
            this.UpdateB = new System.Windows.Forms.Button();
            this.InsertB = new System.Windows.Forms.Button();
            this.PartyNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PartyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartyDataGridView
            // 
            this.PartyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartyDataGridView.Location = new System.Drawing.Point(400, 12);
            this.PartyDataGridView.Name = "PartyDataGridView";
            this.PartyDataGridView.Size = new System.Drawing.Size(388, 286);
            this.PartyDataGridView.TabIndex = 1;
            // 
            // DeleteB
            // 
            this.DeleteB.BackColor = System.Drawing.Color.Red;
            this.DeleteB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteB.Location = new System.Drawing.Point(97, 198);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(107, 39);
            this.DeleteB.TabIndex = 27;
            this.DeleteB.Text = "Delete";
            this.DeleteB.UseVisualStyleBackColor = false;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // UpdateB
            // 
            this.UpdateB.BackColor = System.Drawing.Color.Khaki;
            this.UpdateB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateB.Location = new System.Drawing.Point(176, 129);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(107, 39);
            this.UpdateB.TabIndex = 26;
            this.UpdateB.Text = "Update";
            this.UpdateB.UseVisualStyleBackColor = false;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // InsertB
            // 
            this.InsertB.BackColor = System.Drawing.Color.Khaki;
            this.InsertB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertB.Location = new System.Drawing.Point(12, 129);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(107, 39);
            this.InsertB.TabIndex = 25;
            this.InsertB.Text = "Insert";
            this.InsertB.UseVisualStyleBackColor = false;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // PartyNameTb
            // 
            this.PartyNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyNameTb.Location = new System.Drawing.Point(149, 67);
            this.PartyNameTb.Name = "PartyNameTb";
            this.PartyNameTb.Size = new System.Drawing.Size(161, 26);
            this.PartyNameTb.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name Of Party";
            // 
            // Parties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.InsertB);
            this.Controls.Add(this.PartyNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartyDataGridView);
            this.Name = "Parties";
            this.Text = "Parties";
            this.Load += new System.EventHandler(this.Parties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartyDataGridView;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button InsertB;
        private System.Windows.Forms.TextBox PartyNameTb;
        private System.Windows.Forms.Label label1;
    }
}