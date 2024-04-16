using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Result : Form
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-BU0UST2\\SQLEXPRESS;Database=VotingSystem;User ID=sa;Password=shree;");
        private SqlDataAdapter da;
        private DataTable dt;
        public Result()
        {
            InitializeComponent();
            LoadPartyData();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            GetWinnerParty();

        }

        public string GetWinnerParty()
        {
            string query = "SELECT PartyId " +
                           "FROM Result " +
                           "GROUP BY PartyId " +
                           "HAVING COUNT(*) = (SELECT MAX(VoterId) FROM (SELECT COUNT(*) AS VoterID FROM Result GROUP BY PartyId) AS Counts)";

            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {

                        string query1 = "SELECT PartyName FROM Party WHERE PartyId = @PartyId";
                        SqlCommand command1 = new SqlCommand(query1, con);
                        command1.Parameters.AddWithValue("@PartyId", int.Parse(result.ToString()));
                        string res = command1.ExecuteScalar().ToString();
                        con.Close();
                         System.Console.WriteLine(res);
                         ResultL.Text = res;
                        return result.ToString();
                    }
                    else
                    {
                        return "No votes recorded yet.";
                    }
                }

            }
            catch (SqlException ex)
            {
                con.Close();
                Console.WriteLine("SQL Exception occurred: " + ex);
                return null;
            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine("Exception occurred: " + ex);
                return null;
            }
        }

        private void LoadPartyData()
        {
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Party", con))
                {
                    da = new SqlDataAdapter(command);
                    dt = new DataTable();
                    da.Fill(dt);
                    PartyDataGridView.DataSource = dt;
                    con.Close();
                    //System.Console.WriteLine(con.State);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Error loading party data: {ex}");
                System.Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            con.Close();
        }
    }
}
