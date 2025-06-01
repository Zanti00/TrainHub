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
            String email, password;

            email = emailTxt.Content;
            password = passwordTxt.Content;

            try
            {
                // to avoid sql injection attacks I used parameterized queries
                String query = "SELECT * FROM admin WHERE email = @Email AND password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    email = emailTxt.Content;
                    password = passwordTxt.Content;

                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();
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
    }
}
