using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class TeacherView : Form
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-BU0UST2\\SQLEXPRESS;Database=VotingSystem;User ID=sa;Password=shree;");
        private SqlDataAdapter da;
        private DataTable dt;

        public TeacherView(int userId)
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
