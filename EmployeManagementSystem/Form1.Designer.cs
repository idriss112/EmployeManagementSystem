namespace EmployeManagementSystem;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        this.panel1 = new Panel();
        this.pictureBox1 = new PictureBox();
        this.label6 = new Label();
        this.btnSignUp = new Button();
        this.label5 = new Label();
        this.exit = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.txtUserLogin = new TextBox();
        this.txtPassLogion = new TextBox();
        this.label4 = new Label();
        this.cbShowPass = new CheckBox();
        this.btnLogin = new Button();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.BackColor = Color.FromArgb(74, 9, 131);
        this.panel1.BorderStyle = BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.pictureBox1);
        this.panel1.Controls.Add(this.label6);
        this.panel1.Controls.Add(this.btnSignUp);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Dock = DockStyle.Left;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(277, 447);
        this.panel1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        this.pictureBox1.Location = new Point(73, 63);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new Size(114, 112);
        this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 12;
        this.pictureBox1.TabStop = false;
        this.pictureBox1.Click += this.pictureBox1_Click;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new Font("Tahoma", 10.6930695F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label6.ForeColor = Color.White;
        this.label6.Location = new Point(15, 199);
        this.label6.Name = "label6";
        this.label6.Size = new Size(256, 22);
        this.label6.TabIndex = 11;
        this.label6.Text = "Employee Management System";
        // 
        // btnSignUp
        // 
        this.btnSignUp.BackColor = Color.FromArgb(33, 11, 97);
        this.btnSignUp.Cursor = Cursors.Hand;
        this.btnSignUp.FlatAppearance.BorderSize = 0;
        this.btnSignUp.FlatAppearance.MouseDownBackColor = Color.Purple;
        this.btnSignUp.FlatAppearance.MouseOverBackColor = Color.Purple;
        this.btnSignUp.FlatStyle = FlatStyle.Flat;
        this.btnSignUp.Font = new Font("Arial Narrow", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.btnSignUp.ForeColor = Color.White;
        this.btnSignUp.Location = new Point(27, 401);
        this.btnSignUp.Name = "btnSignUp";
        this.btnSignUp.Size = new Size(213, 31);
        this.btnSignUp.TabIndex = 10;
        this.btnSignUp.Text = "Sign Up";
        this.btnSignUp.UseVisualStyleBackColor = false;
        this.btnSignUp.Click += this.btnSignUp_Click;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new Font("Tahoma", 9.267326F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label5.ForeColor = Color.White;
        this.label5.Location = new Point(55, 365);
        this.label5.Name = "label5";
        this.label5.Size = new Size(153, 18);
        this.label5.TabIndex = 9;
        this.label5.Text = "Register Your Account";
        // 
        // exit
        // 
        this.exit.AutoSize = true;
        this.exit.Cursor = Cursors.Hand;
        this.exit.Font = new Font("Tahoma", 10.6930695F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.exit.Location = new Point(625, 10);
        this.exit.Name = "exit";
        this.exit.Size = new Size(19, 22);
        this.exit.TabIndex = 1;
        this.exit.Text = "x";
        this.exit.Click += this.label1_Click;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new Font("Arial Rounded MT Bold", 14.2574253F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label2.Location = new Point(303, 64);
        this.label2.Name = "label2";
        this.label2.Size = new Size(175, 27);
        this.label2.TabIndex = 2;
        this.label2.Text = "Login Account";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new Font("Tahoma", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label3.Location = new Point(303, 131);
        this.label3.Name = "label3";
        this.label3.Size = new Size(91, 19);
        this.label3.TabIndex = 3;
        this.label3.Text = "Username :";
        // 
        // txtUserLogin
        // 
        this.txtUserLogin.Font = new Font("Tahoma", 10.6930695F);
        this.txtUserLogin.Location = new Point(303, 165);
        this.txtUserLogin.Multiline = true;
        this.txtUserLogin.Name = "txtUserLogin";
        this.txtUserLogin.Size = new Size(298, 33);
        this.txtUserLogin.TabIndex = 4;
        // 
        // txtPassLogion
        // 
        this.txtPassLogion.Font = new Font("Tahoma", 10.6930695F);
        this.txtPassLogion.Location = new Point(303, 263);
        this.txtPassLogion.Multiline = true;
        this.txtPassLogion.Name = "txtPassLogion";
        this.txtPassLogion.PasswordChar = '*';
        this.txtPassLogion.Size = new Size(298, 33);
        this.txtPassLogion.TabIndex = 6;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new Font("Tahoma", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label4.Location = new Point(303, 228);
        this.label4.Name = "label4";
        this.label4.Size = new Size(87, 19);
        this.label4.TabIndex = 5;
        this.label4.Text = "Password :";
        // 
        // cbShowPass
        // 
        this.cbShowPass.AutoSize = true;
        this.cbShowPass.Location = new Point(466, 303);
        this.cbShowPass.Name = "cbShowPass";
        this.cbShowPass.Size = new Size(129, 24);
        this.cbShowPass.TabIndex = 7;
        this.cbShowPass.Text = "Show Password";
        this.cbShowPass.UseVisualStyleBackColor = true;
        this.cbShowPass.CheckedChanged += this.cbShowPass_CheckedChanged;
        // 
        // btnLogin
        // 
        this.btnLogin.BackColor = Color.FromArgb(28, 6, 89);
        this.btnLogin.Cursor = Cursors.Hand;
        this.btnLogin.FlatAppearance.BorderSize = 0;
        this.btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnLogin.FlatStyle = FlatStyle.Flat;
        this.btnLogin.Font = new Font("Arial Rounded MT Bold", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.btnLogin.ForeColor = Color.White;
        this.btnLogin.Location = new Point(303, 341);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new Size(122, 37);
        this.btnLogin.TabIndex = 8;
        this.btnLogin.Text = "Login";
        this.btnLogin.UseVisualStyleBackColor = false;
        this.btnLogin.Click += this.btnLogin_Click;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new SizeF(8F, 19F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.ButtonHighlight;
        this.ClientSize = new Size(657, 447);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.cbShowPass);
        this.Controls.Add(this.txtPassLogion);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtUserLogin);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.exit);
        this.Controls.Add(this.panel1);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Name = "Form1";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Form1";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label exit;
    private Label label2;
    private Label label3;
    private TextBox txtUserLogin;
    private TextBox txtPassLogion;
    private Label label4;
    private CheckBox cbShowPass;
    private Button btnLogin;
    private Label label5;
    private Button btnSignUp;
    private PictureBox pictureBox1;
    private Label label6;
}
