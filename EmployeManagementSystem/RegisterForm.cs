using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;


namespace EmployeManagementSystem;
public partial class RegisterForm : Form
{
    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Idriss La\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");
    private void RegisterForm_Load(object sender, EventArgs e)
    {


    }


    public RegisterForm()
    {
        this.InitializeComponent();
    }

    //button exit
    private void exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }


    //hide login form and show register form
    private void btnSignIn_Click(object sender, EventArgs e)
    {
        Form1 loginForm = new Form1();
        loginForm.Show();
        this.Hide();
    }


    //show and hide password
    private void cbShowPass_CheckedChanged(object sender, EventArgs e)
    {
        this.txtPassSignUp.PasswordChar = this.cbShowPass.Checked ? '\0' : '*';
    }

    // sign up button 
    private void btnLogin_Click(object sender, EventArgs e)
    {

        if (this.txtUserSignUp.Text == "" || this.txtPassSignUp.Text == "")
        {
            MessageBox.Show("Please fill all blank fiels", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (this.connect.State != ConnectionState.Open)
            {
                try
                {
                    this.connect.Open();


                    //TO CHECK IF USER IS EXISTING ALREADY 
                    String selectUsername = "SELECT COUNT (id) FROM users WHERE username = @user";

                    using (SqlCommand checkUser = new SqlCommand(selectUsername, this.connect))
                    {
                        checkUser.Parameters.AddWithValue("@user", this.txtUserSignUp.Text.Trim());
                        int count = (int)checkUser.ExecuteScalar();

                        if (count >= 1)
                        {
                            
                            MessageBox.Show(this.txtUserSignUp.Text.Trim() +"is already taken" 
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DateTime today = DateTime.Today;

                            string insertData = "INSERT INTO users " +
                                "(username, password, date_register)" +
                                "VALUES(@username,@password,@dateReg)";

                            using (SqlCommand cmd = new SqlCommand(insertData, this.connect))
                            {
                                cmd.Parameters.AddWithValue("@username", this.txtUserSignUp.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", this.txtPassSignUp.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateReg", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered successfully!",
                                    "Information Meessage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginForm = new();
                                loginForm.Show();
                                this.Hide();
                            }
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message
                  , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    this.connect.Close();
                }
            }
        }
    }
}
