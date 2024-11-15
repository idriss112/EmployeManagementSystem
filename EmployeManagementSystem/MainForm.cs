using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeManagementSystem;
public partial class MainForm : Form
{
    public MainForm()
    {
        this.InitializeComponent();
    }

    private void X_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        DialogResult check = MessageBox.Show("Are you sure you want to log out?",
            "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (check == DialogResult.Yes)
        {
            Form1 loginForm = new();
            loginForm.Show();
            this.Hide();
        }
    }

    private void btnDashboard_Click(object sender, EventArgs e)
    {
        this.dashboard1.Visible = true;
        this.addEmployee1.Visible = false;
        this.salary1.Visible = false;
    }

    private void btnAddEmployee_Click(object sender, EventArgs e)
    {
        this.dashboard1.Visible = false;
        this.addEmployee1.Visible = true;
        this.salary1.Visible = false;
    }

    private void btnSalary_Click(object sender, EventArgs e)
    {
        this.dashboard1.Visible = false;
        this.addEmployee1.Visible = false;
        this.salary1.Visible = true;
    }
}
