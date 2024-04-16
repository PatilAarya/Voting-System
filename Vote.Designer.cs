namespace VotingSystem
{
    partial class Vote
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
            this.components = new System.ComponentModel.Container();
            this.RegisterB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PartyCb = new System.Windows.Forms.ComboBox();
            this.votingSystemDataSet = new VotingSystem.VotingSystemDataSet();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyTableAdapter = new VotingSystem.VotingSystemDataSetTableAdapters.PartyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterB
            // 
            this.RegisterB.Location = new System.Drawing.Point(119, 179);
            this.RegisterB.Name = "RegisterB";
            this.RegisterB.Size = new System.Drawing.Size(75, 23);
            this.RegisterB.TabIndex = 10;
            this.RegisterB.Text = "Logout";
            this.RegisterB.UseVisualStyleBackColor = true;
            this.RegisterB.Click += new System.EventHandler(this.RegisterB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Party";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Vote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PartyCb
            // 
            this.PartyCb.DataSource = this.partyBindingSource;
            this.PartyCb.DisplayMember = "PartyName";
            this.PartyCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartyCb.FormattingEnabled = true;
            this.PartyCb.Location = new System.Drawing.Point(133, 70);
            this.PartyCb.Name = "PartyCb";
            this.PartyCb.Size = new System.Drawing.Size(121, 21);
            this.PartyCb.TabIndex = 13;
            // 
            // votingSystemDataSet
            // 
            this.votingSystemDataSet.DataSetName = "VotingSystemDataSet";
            this.votingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataMember = "Party";
            this.partyBindingSource.DataSource = this.votingSystemDataSet;
            // 
            // partyTableAdapter
            // 
            this.partyTableAdapter.ClearBeforeFill = true;
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 312);
            this.Controls.Add(this.PartyCb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegisterB);
            this.Controls.Add(this.label1);
            this.Name = "Vote";
            this.Text = "Vote";
            this.Load += new System.EventHandler(this.Vote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RegisterB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox PartyCb;
        private VotingSystemDataSet votingSystemDataSet;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private VotingSystemDataSetTableAdapters.PartyTableAdapter partyTableAdapter;
    }
}