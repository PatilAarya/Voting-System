// Login.cs
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Login : Form
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-BU0UST2\\SQLEXPRESS;Database=VotingSystem;User ID=sa;Password=shree;");

        public Login()
        {
            InitializeComponent();
        }

        private void RegisterL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rf = new Register();
            rf.Show();
            this.Hide();
        }

        private int GetLoggedInUserIdFromDatabase(string fullname, string email, string table)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand($"SELECT {table}id FROM {table} WHERE Fullname = @fullname AND Email = @email",
                    con);
                com.Parameters.AddWithValue("@fullname", fullname);
                com.Parameters.AddWithValue("@email", email);
                object result = com.ExecuteScalar();
                con.Close();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show($"Error: {table} ID not found for the logged-in user!");
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving {table} ID from database: {ex.Message}");
                return -1;
            }
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            if (FullnameT.Text.Length > 0 && EmailT.Text.Length > 0)
            {
                con.Open();
                string username = FullnameT.Text;
                string email = EmailT.Text;
                try
                {
                    SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Voter WHERE Fullname = @fullname AND Email = @email",
                        con);
                    com.Parameters.AddWithValue("@fullname", username);
                    com.Parameters.AddWithValue("@email", email);

                    int userCount = (int)com.ExecuteScalar();
                    
                    if (userCount > 0)
                    {
                        con.Close();
                        MessageBox.Show("Login successful!");
                        int loggedInUserId = GetLoggedInUserIdFromDatabase(username, email, "Voter");
                        VotingPage votingPage = new VotingPage(loggedInUserId);
                        votingPage.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        com = new SqlCommand("SELECT COUNT(*) FROM Teacher WHERE Fullname = @fullname AND Email = @email",
                            con);
                        com.Parameters.AddWithValue("@fullname", username);
                        com.Parameters.AddWithValue("@email", email);

                        userCount = (int)com.ExecuteScalar();
                        con.Close();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful!");
                            int loggedInUserId = GetLoggedInUserIdFromDatabase(username, email, "Teacher");
                            TeacherView teacherView = new TeacherView(loggedInUserId);
                            teacherView.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Fullname or Email!");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fullname and email are required.");
            }
        }
    }
}
