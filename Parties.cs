using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VotingSystem
{
    public partial class Parties : Form
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-BU0UST2\\SQLEXPRESS;Database=VotingSystem;User ID=sa;Password=shree;");
        private SqlDataAdapter da;
        private DataTable dt;
        public Parties()
        {
            InitializeComponent();
            LoadPartyData();
        }

        private void Parties_Load(object sender, EventArgs e)
        {

        }
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Result", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            PartyDataGridView.DataSource = dt;
            PartyDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            PartyDataGridView.DefaultCellStyle.Font = new Font("Ariel", 12, FontStyle.Regular);
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
                    foreach (DataGridViewColumn column in PartyDataGridView.Columns)
                    {
                        column.ReadOnly = true;
                    }
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

        private void InsertB_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Party VALUES(@PartyName)", con);

            cmd2.Parameters.AddWithValue("PartyName",PartyNameTb.Text);
            
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            // bind_data();
            LoadPartyData();
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (PartyDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected PartyId from the first selected row
                int partyId = Convert.ToInt32(PartyDataGridView.SelectedRows[0].Cells["PartyId"].Value);

                // Get the new PartyName from the PartyNameTb TextBox
                string newPartyName = PartyNameTb.Text;

                // Check if the PartyName TextBox is not empty
                if (!string.IsNullOrWhiteSpace(newPartyName))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd3 = new SqlCommand("UPDATE Party SET PartyName = @PartyName WHERE PartyId = @PartyId", con);
                        cmd3.Parameters.AddWithValue("@PartyName", newPartyName);
                        cmd3.Parameters.AddWithValue("@PartyId", partyId);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Party updated successfully!");
                        LoadPartyData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating party: {ex.Message}");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a party name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a party to update.");
            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (PartyDataGridView.SelectedRows.Count > 0)
            {
                int partyId = Convert.ToInt32(PartyDataGridView.SelectedRows[0].Cells["PartyId"].Value);

                try
                    {
                        con.Open();
                        SqlCommand cmd3 = new SqlCommand("DELETE Party WHERE PartyId = @PartyId", con);
                        cmd3.Parameters.AddWithValue("@PartyId", partyId);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Party deleted successfully!");
                        LoadPartyData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting party: {ex.Message}");
                    }
                    finally
                    {
                        con.Close();
                    }
            }
            else
            {
                MessageBox.Show("Please select a party to update.");
            }
        }
    }
}
