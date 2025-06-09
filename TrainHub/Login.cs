using System.Data;
using Microsoft.Data.SqlClient;

namespace TrainHub
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TrainHub;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            string email = emailTxt.Content;
            string password = passwordTxt.Content;

            try
            {
                // to avoid sql injection attacks I used parameterized queries
                String query = "SELECT * FROM users WHERE email = @Email AND password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    LoadCurrentUserInfo(email);

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTxt.ResetText();
                    passwordTxt.ResetText();

                    emailTxt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while trying to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void LoadCurrentUserInfo(string email)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CurrentUser.UserId = (int)reader["Id"];
                        CurrentUser.Username = reader["Username"].ToString();
                        CurrentUser.FirstName = reader["FirstName"].ToString();
                        CurrentUser.LastName = reader["LastName"].ToString();
                        CurrentUser.Email = reader["Email"].ToString();
                        CurrentUser.IsAdmin = reader["IsAdmin"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.Show();
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxt.PasswordChar)
            {
                passwordTxt.PasswordChar = false;
            }
            else
            {
                passwordTxt.PasswordChar = true;
            }
        }
    }
}
