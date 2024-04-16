// Register.cs
using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Register : Form
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-BU0UST2\\SQLEXPRESS;Database=VotingSystem;User ID=sa;Password=shree;");

        public Register()
        {
            InitializeComponent();
        }

        private void LoginL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lf = new Login();
            lf.Show();
            this.Hide();
        }

        private void RegisterB_Click(object sender, EventArgs e)
        {
            if (FullnameT.Text.Length > 0 && EmailT.Text.Length > 0)
            {
                try
                {
                    con.Open();

                    string userType = TeacherRb.Checked ? "Teacher" : "Voter";

                    SqlCommand com = new SqlCommand($"INSERT INTO {userType}(Fullname, Email) VALUES(@fullname, @email)",
                        con);
                    com.Parameters.AddWithValue("@fullname", FullnameT.Text);
                    com.Parameters.AddWithValue("@email", EmailT.Text);

                    try
                    {
                        com.ExecuteNonQuery();

                        MessageBox.Show("Success! You will be redirected to Login Page.");

                        SendEmail();

                        Login lf = new Login();
                        lf.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to register: {ex.Message}");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Failed to connect to database: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Full Name and Email are required!");
            }
        }

        private void SendEmail()
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("project9960@gmail.com");
                msg.To.Add(EmailT.Text);
                msg.Subject = "Welcome to Online Voting";
                msg.Body = "Hello " + FullnameT.Text +
                           "\n\n Welcome to GPM Online Voting System\n\nThank you!";

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "project9960@gmail.com";
                ntcd.Password = "Project@2124";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Check your email");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                MessageBox.Show("Fail to send email");
            }
        }
private void EmailT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FullnameT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
