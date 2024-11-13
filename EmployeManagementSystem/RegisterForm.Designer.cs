namespace EmployeManagementSystem;

partial class RegisterForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
        this.btnsignup = new Button();
        this.cbShowPass = new CheckBox();
        this.txtPassSignUp = new TextBox();
        this.label4 = new Label();
        this.txtUserSignUp = new TextBox();
        this.label3 = new Label();
        this.label2 = new Label();
        this.exit = new Label();
        this.panel1 = new Panel();
        this.pictureBox1 = new PictureBox();
        this.label6 = new Label();
        this.btnSignIn = new Button();
        this.label5 = new Label();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
        this.SuspendLayout();
        // 
        // btnsignup
        // 
        this.btnsignup.BackColor = Color.FromArgb(28, 6, 89);
        this.btnsignup.Cursor = Cursors.Hand;
        this.btnsignup.FlatAppearance.BorderSize = 0;
        this.btnsignup.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnsignup.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnsignup.FlatStyle = FlatStyle.Flat;
        this.btnsignup.Font = new Font("Arial Rounded MT Bold", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.btnsignup.ForeColor = Color.White;
        this.btnsignup.Location = new Point(302, 341);
        this.btnsignup.Name = "btnsignup";
        this.btnsignup.Size = new Size(122, 37);
        this.btnsignup.TabIndex = 17;
        this.btnsignup.Text = "Sign Up";
        this.btnsignup.UseVisualStyleBackColor = false;
        this.btnsignup.Click += this.btnLogin_Click;
        // 
        // cbShowPass
        // 
        this.cbShowPass.AutoSize = true;
        this.cbShowPass.Location = new Point(465, 303);
        this.cbShowPass.Name = "cbShowPass";
        this.cbShowPass.Size = new Size(129, 24);
        this.cbShowPass.TabIndex = 16;
        this.cbShowPass.Text = "Show Password";
        this.cbShowPass.UseVisualStyleBackColor = true;
        this.cbShowPass.CheckedChanged += this.cbShowPass_CheckedChanged;
        // 
        // txtPassSignUp
        // 
        this.txtPassSignUp.Font = new Font("Tahoma", 10.6930695F);
        this.txtPassSignUp.Location = new Point(299, 263);
        this.txtPassSignUp.Multiline = true;
        this.txtPassSignUp.Name = "txtPassSignUp";
        this.txtPassSignUp.PasswordChar = '*';
        this.txtPassSignUp.Size = new Size(298, 33);
        this.txtPassSignUp.TabIndex = 15;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new Font("Tahoma", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label4.Location = new Point(302, 228);
        this.label4.Name = "label4";
        this.label4.Size = new Size(87, 19);
        this.label4.TabIndex = 14;
        this.label4.Text = "Password :";
        // 
        // txtUserSignUp
        // 
        this.txtUserSignUp.Font = new Font("Tahoma", 10.6930695F);
        this.txtUserSignUp.Location = new Point(302, 165);
        this.txtUserSignUp.Multiline = true;
        this.txtUserSignUp.Name = "txtUserSignUp";
        this.txtUserSignUp.Size = new Size(298, 33);
        this.txtUserSignUp.TabIndex = 13;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new Font("Tahoma", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label3.Location = new Point(302, 131);
        this.label3.Name = "label3";
        this.label3.Size = new Size(91, 19);
        this.label3.TabIndex = 12;
        this.label3.Text = "Username :";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new Font("Arial Rounded MT Bold", 14.2574253F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label2.Location = new Point(302, 64);
        this.label2.Name = "label2";
        this.label2.Size = new Size(208, 27);
        this.label2.TabIndex = 11;
        this.label2.Text = "Register Account";
        // 
        // exit
        // 
        this.exit.AutoSize = true;
        this.exit.Cursor = Cursors.Hand;
        this.exit.Font = new Font("Tahoma", 10.6930695F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.exit.Location = new Point(632, 10);
        this.exit.Name = "exit";
        this.exit.Size = new Size(19, 22);
        this.exit.TabIndex = 10;
        this.exit.Text = "x";
        this.exit.Click += this.exit_Click;
        // 
        // panel1
        // 
        this.panel1.BackColor = Color.FromArgb(74, 9, 131);
        this.panel1.BorderStyle = BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.pictureBox1);
        this.panel1.Controls.Add(this.label6);
        this.panel1.Controls.Add(this.btnSignIn);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Dock = DockStyle.Left;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(277, 447);
        this.panel1.TabIndex = 9;
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
        // btnSignIn
        // 
        this.btnSignIn.BackColor = Color.FromArgb(33, 11, 97);
        this.btnSignIn.Cursor = Cursors.Hand;
        this.btnSignIn.FlatAppearance.BorderSize = 0;
        this.btnSignIn.FlatAppearance.MouseDownBackColor = Color.Purple;
        this.btnSignIn.FlatAppearance.MouseOverBackColor = Color.Purple;
        this.btnSignIn.FlatStyle = FlatStyle.Flat;
        this.btnSignIn.Font = new Font("Arial Narrow", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.btnSignIn.ForeColor = Color.White;
        this.btnSignIn.Location = new Point(27, 401);
        this.btnSignIn.Name = "btnSignIn";
        this.btnSignIn.Size = new Size(213, 31);
        this.btnSignIn.TabIndex = 10;
        this.btnSignIn.Text = "Sign In";
        this.btnSignIn.UseVisualStyleBackColor = false;
        this.btnSignIn.Click += this.btnSignIn_Click;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new Font("Tahoma", 9.267326F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label5.ForeColor = Color.White;
        this.label5.Location = new Point(55, 365);
        this.label5.Name = "label5";
        this.label5.Size = new Size(156, 18);
        this.label5.TabIndex = 9;
        this.label5.Text = "Log Into Your Account";
        // 
        // RegisterForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 19F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.ButtonHighlight;
        this.ClientSize = new Size(657, 447);
        this.Controls.Add(this.btnsignup);
        this.Controls.Add(this.cbShowPass);
        this.Controls.Add(this.txtPassSignUp);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtUserSignUp);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.exit);
        this.Controls.Add(this.panel1);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Name = "RegisterForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "RegisterForm";
        this.Load += this.RegisterForm_Load;
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Button btnsignup;
    private CheckBox cbShowPass;
    private TextBox txtPassSignUp;
    private Label label4;
    private TextBox txtUserSignUp;
    private Label label3;
    private Label label2;
    private Label exit;
    private Panel panel1;
    private PictureBox pictureBox1;
    private Label label6;
    private Button btnSignIn;
    private Label label5;
}