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
    

    public partial class VotingPage : Form
    {
        class PartyItem
        {
            public int Id { get; }
            public string Name { get; }

            public PartyItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }
        public int LoggedInVoterId { get; }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BU0UST2\\SQLEXPRESS;Database=VotingSystem;User ID=sa;Password=shree;");
        public VotingPage(int loggedInVoterId)
        {
            InitializeComponent();
            LoggedInVoterId = loggedInVoterId;
            PopulatePartyComboBox();
        }
        private void PopulatePartyComboBox()
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT PartyID, PartyName FROM Party", con);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    int partyId = reader.GetInt32(0);
                    string partyName = reader.GetString(1);
                    PartyCb.Items.Add(new PartyItem(partyId, partyName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parties: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void VotingPage_Load(object sender, EventArgs e)
        {

        }

        private void VoteB_Click(object sender, EventArgs e)
        {
            int selectedPartyId = -1;
            if (PartyCb.SelectedItem != null)
            {
                PartyItem selectedParty = (PartyItem)PartyCb.SelectedItem;
                selectedPartyId = selectedParty.Id;
            }
            else
            {
                MessageBox.Show("Please select a party to vote for!");
                return;
            }

            int voterId = GetLoggedInVoterId();

            if (voterId == -1)
            {
                MessageBox.Show("Error: Voter ID not found!");
                return;
            }

            if (IsVoterAlreadyVoted(voterId))
            {
                MessageBox.Show("You have already cast your vote!");
                return;
            }

            if (IsVoterAlreadyVotedForParty(voterId))
            {
                MessageBox.Show("You have already voted for a party!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Result (VoterID, PartyID) VALUES (@VoterID, @PartyID)", con);
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

        private bool IsVoterAlreadyVotedForParty(int voterId)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Result WHERE VoterID = @VoterID", con);
                com.Parameters.AddWithValue("@VoterID", voterId);
                int count = Convert.ToInt32(com.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking if voter already voted for a party: " + ex.Message);
                return true;
            }
            finally
            {
                con.Close();
            }
        }


        private bool IsVoterAlreadyVoted(int voterId)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Result WHERE VoterID = @VoterID", con);
                com.Parameters.AddWithValue("@VoterID", voterId);
                int count = Convert.ToInt32(com.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking if voter already voted: " + ex.Message);
                return true;
            }
            finally
            {
                con.Close();
            }
        }




        private int GetLoggedInVoterId()
           {
               return LoggedInVoterId;
           }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lf = new Login();
            lf.Show();
        }
    }
}
