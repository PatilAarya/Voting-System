namespace VotingSystem
{
    partial class Result
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
            this.ResultL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PartyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartyDataGridView
            // 
            this.PartyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartyDataGridView.Location = new System.Drawing.Point(400, 12);
            this.PartyDataGridView.Name = "PartyDataGridView";
            this.PartyDataGridView.Size = new System.Drawing.Size(388, 286);
            this.PartyDataGridView.TabIndex = 0;
            // 
            // ResultL
            // 
            this.ResultL.AutoSize = true;
            this.ResultL.Location = new System.Drawing.Point(31, 189);
            this.ResultL.Name = "ResultL";
            this.ResultL.Size = new System.Drawing.Size(35, 13);
            this.ResultL.TabIndex = 1;
            this.ResultL.Text = "label1";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultL);
            this.Controls.Add(this.PartyDataGridView);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartyDataGridView;
        private System.Windows.Forms.Label ResultL;
    }
}