using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class TeacherView : Form
    {
        public TeacherView()
        {
            InitializeComponent();
            
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            r.Show();
            this.Close();
        }

        private void PartiesBtn_Click(object sender, EventArgs e)
        {
            Parties pr = new Parties();
            pr.Show();
            this.Close();
        }
    }
}
