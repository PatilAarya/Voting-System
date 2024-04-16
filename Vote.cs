using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VotingSystem
{
     
    public partial class Vote : Form
    {
        public int LoggedInVoterId { get; }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BU0UST2\\SQLEXPRESS;Database=VotingSystem;User ID=sa;Password=shree;");
        public Vote(int loggedInVoterId)
        {
            InitializeComponent();
            LoggedInVoterId = loggedInVoterId;
        }
        private int GetLoggedInVoterId()
        {
            return LoggedInVoterId;
        }


        private void RegisterB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lf = new Login();
            lf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedPartyId = -1;
            System.Console.WriteLine(PartyCb.SelectedValue);
            if (PartyCb.SelectedItem != null)
            {
                
                selectedPartyId = Convert.ToInt32(PartyCb.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a party to vote for!");
            }


            // Get the voter ID from somewhere (e.g., from the login information)
            int voterId = GetLoggedInVoterId();

            if (voterId == -1)
            {
                MessageBox.Show("Error: Voter ID not found!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Votes (VoterID, PartyID) VALUES (@VoterID, @PartyID)", con);
                com.Parameters.AddWithValue("@VoterID", voterId);
                com.Parameters.AddWithValue("@PartyID", selectedPartyId);
                com.ExecuteNonQuery();

                MessageBox.Show("Vote cast successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error casting vote: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Vote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingSystemDataSet.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.votingSystemDataSet.Party);

        }
    }
}
