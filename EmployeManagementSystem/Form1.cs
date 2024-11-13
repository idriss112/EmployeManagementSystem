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

public partial class Form1 : Form
{
    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Idriss La\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");
    public Form1()
    {
        this.InitializeComponent();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    //button exit
    private void label1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }


    //hide register form and show log in form
    private void btnSignUp_Click(object sender, EventArgs e)
    {
        RegisterForm signupForm = new RegisterForm();
        signupForm.Show();
        this.Hide();
    }


    //show and hide password
    private void cbShowPass_CheckedChanged(object sender, EventArgs e)
    {
        this.txtPassLogion.PasswordChar = this.cbShowPass.Checked ? '\0' : '*';
    }


    //log in button
    private void btnLogin_Click(object sender, EventArgs e)
    {
        if(this.txtUserLogin.Text =="" || this.txtPassLogion.Text == "")
        {
            MessageBox.Show("Please fill all blank fiels", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (this.connect.State == ConnectionState.Closed) 
            {
                try
                {
                    this.connect.Open();

                    string selectData = "SELECT * FROM users WHERE username = @username " +
                        "AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectData, this.connect)) 
                    {
                        cmd.Parameters.AddWithValue("@username", this.txtUserLogin.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", this.txtPassLogion.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login successfully!",
                                    "Information Meessage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm mainForm = new();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password",
                                   "Error Meessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
