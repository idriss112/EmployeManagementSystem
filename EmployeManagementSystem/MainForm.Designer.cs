namespace EmployeManagementSystem;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.panel1 = new Panel();
        this.label1 = new Label();
        this.X = new Label();
        this.panel2 = new Panel();
        this.label3 = new Label();
        this.btnLogout = new Button();
        this.btnSalary = new Button();
        this.btnAddEmployee = new Button();
        this.btnDashboard = new Button();
        this.greet_user = new Label();
        this.pictureBox1 = new PictureBox();
        this.panel3 = new Panel();
        this.dashboard1 = new Dashboard();
        this.addEmployee1 = new AddEmployee();
        this.salary1 = new Salary();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
        this.panel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.BackColor = Color.FromArgb(33, 11, 97);
        this.panel1.BorderStyle = BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.X);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(1100, 35);
        this.panel1.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new Font("Tahoma", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label1.ForeColor = Color.White;
        this.label1.Location = new Point(11, 7);
        this.label1.Name = "label1";
        this.label1.Size = new Size(221, 19);
        this.label1.TabIndex = 2;
        this.label1.Text = "Employee Managment System";
        // 
        // X
        // 
        this.X.AutoSize = true;
        this.X.Cursor = Cursors.Hand;
        this.X.Font = new Font("Tahoma", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.X.ForeColor = Color.White;
        this.X.Location = new Point(1076, 5);
        this.X.Name = "X";
        this.X.Size = new Size(18, 19);
        this.X.TabIndex = 1;
        this.X.Text = "X";
        this.X.Click += this.X_Click;
        // 
        // panel2
        // 
        this.panel2.BackColor = Color.FromArgb(33, 11, 97);
        this.panel2.Controls.Add(this.label3);
        this.panel2.Controls.Add(this.btnLogout);
        this.panel2.Controls.Add(this.btnSalary);
        this.panel2.Controls.Add(this.btnAddEmployee);
        this.panel2.Controls.Add(this.btnDashboard);
        this.panel2.Controls.Add(this.greet_user);
        this.panel2.Controls.Add(this.pictureBox1);
        this.panel2.Dock = DockStyle.Left;
        this.panel2.Location = new Point(0, 35);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(252, 565);
        this.panel2.TabIndex = 1;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new Font("Tahoma", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label3.ForeColor = Color.White;
        this.label3.Location = new Point(51, 525);
        this.label3.Name = "label3";
        this.label3.Size = new Size(71, 19);
        this.label3.TabIndex = 8;
        this.label3.Text = "Sign Out";
        // 
        // btnLogout
        // 
        this.btnLogout.Cursor = Cursors.Hand;
        this.btnLogout.FlatAppearance.BorderSize = 0;
        this.btnLogout.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnLogout.FlatStyle = FlatStyle.Flat;
        this.btnLogout.ForeColor = Color.White;
        this.btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
        this.btnLogout.Location = new Point(14, 518);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new Size(35, 35);
        this.btnLogout.TabIndex = 7;
        this.btnLogout.UseVisualStyleBackColor = true;
        this.btnLogout.Click += this.btnLogout_Click;
        // 
        // btnSalary
        // 
        this.btnSalary.BackColor = Color.FromArgb(33, 11, 97);
        this.btnSalary.Cursor = Cursors.Hand;
        this.btnSalary.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.btnSalary.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnSalary.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnSalary.FlatStyle = FlatStyle.Flat;
        this.btnSalary.Font = new Font("Arial Rounded MT Bold", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.btnSalary.ForeColor = Color.WhiteSmoke;
        this.btnSalary.Image = (Image)resources.GetObject("btnSalary.Image");
        this.btnSalary.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnSalary.Location = new Point(16, 361);
        this.btnSalary.Name = "btnSalary";
        this.btnSalary.Size = new Size(226, 40);
        this.btnSalary.TabIndex = 6;
        this.btnSalary.Text = "SALARY";
        this.btnSalary.UseVisualStyleBackColor = false;
        this.btnSalary.Click += this.btnSalary_Click;
        // 
        // btnAddEmployee
        // 
        this.btnAddEmployee.BackColor = Color.FromArgb(33, 11, 97);
        this.btnAddEmployee.Cursor = Cursors.Hand;
        this.btnAddEmployee.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.btnAddEmployee.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnAddEmployee.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnAddEmployee.FlatStyle = FlatStyle.Flat;
        this.btnAddEmployee.Font = new Font("Arial Rounded MT Bold", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.btnAddEmployee.ForeColor = Color.WhiteSmoke;
        this.btnAddEmployee.Image = (Image)resources.GetObject("btnAddEmployee.Image");
        this.btnAddEmployee.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnAddEmployee.Location = new Point(14, 290);
        this.btnAddEmployee.Name = "btnAddEmployee";
        this.btnAddEmployee.Size = new Size(226, 40);
        this.btnAddEmployee.TabIndex = 5;
        this.btnAddEmployee.Text = "ADD EMPLOYEE";
        this.btnAddEmployee.UseVisualStyleBackColor = false;
        this.btnAddEmployee.Click += this.btnAddEmployee_Click;
        // 
        // btnDashboard
        // 
        this.btnDashboard.BackColor = Color.FromArgb(33, 11, 97);
        this.btnDashboard.Cursor = Cursors.Hand;
        this.btnDashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnDashboard.FlatStyle = FlatStyle.Flat;
        this.btnDashboard.Font = new Font("Arial Rounded MT Bold", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.btnDashboard.ForeColor = Color.WhiteSmoke;
        this.btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
        this.btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnDashboard.Location = new Point(15, 221);
        this.btnDashboard.Name = "btnDashboard";
        this.btnDashboard.Size = new Size(226, 40);
        this.btnDashboard.TabIndex = 4;
        this.btnDashboard.Text = "DASHBOARD";
        this.btnDashboard.UseVisualStyleBackColor = false;
        this.btnDashboard.Click += this.btnDashboard_Click;
        // 
        // greet_user
        // 
        this.greet_user.AutoSize = true;
        this.greet_user.Font = new Font("Tahoma", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.greet_user.ForeColor = Color.White;
        this.greet_user.Location = new Point(51, 166);
        this.greet_user.Name = "greet_user";
        this.greet_user.Size = new Size(145, 23);
        this.greet_user.TabIndex = 3;
        this.greet_user.Text = "Welecome, User";
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = Properties.Resources.manager;
        this.pictureBox1.Location = new Point(70, 44);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new Size(100, 100);
        this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 2;
        this.pictureBox1.TabStop = false;
        // 
        // panel3
        // 
        this.panel3.BackColor = SystemColors.ButtonFace;
        this.panel3.Controls.Add(this.dashboard1);
        this.panel3.Controls.Add(this.addEmployee1);
        this.panel3.Controls.Add(this.salary1);
        this.panel3.Dock = DockStyle.Fill;
        this.panel3.Location = new Point(252, 35);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(848, 565);
        this.panel3.TabIndex = 2;
        // 
        // dashboard1
        // 
        this.dashboard1.Location = new Point(3, 0);
        this.dashboard1.Name = "dashboard1";
        this.dashboard1.Size = new Size(1016, 677);
        this.dashboard1.TabIndex = 2;
        // 
        // addEmployee1
        // 
        this.addEmployee1.Location = new Point(-4, 3);
        this.addEmployee1.Name = "addEmployee1";
        this.addEmployee1.Size = new Size(1016, 677);
        this.addEmployee1.TabIndex = 1;
        // 
        // salary1
        // 
        this.salary1.Location = new Point(0, -7);
        this.salary1.Name = "salary1";
        this.salary1.Size = new Size(1016, 677);
        this.salary1.TabIndex = 0;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 19F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.ButtonHighlight;
        this.ClientSize = new Size(1100, 600);
        this.Controls.Add(this.panel3);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Name = "MainForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "MainForm";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
        this.panel3.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Label X;
    private Panel panel2;
    private PictureBox pictureBox1;
    private Button btnDashboard;
    private Label greet_user;
    private Button btnSalary;
    private Button btnAddEmployee;
    private Button btnLogout;
    private Label label3;
    private Panel panel3;
    private Salary salary1;
    private Dashboard dashboard1;
    private AddEmployee addEmployee1;
}