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
        this.button4 = new Button();
        this.button3 = new Button();
        this.button2 = new Button();
        this.button1 = new Button();
        this.label2 = new Label();
        this.pictureBox1 = new PictureBox();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
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
        this.panel2.Controls.Add(this.button4);
        this.panel2.Controls.Add(this.button3);
        this.panel2.Controls.Add(this.button2);
        this.panel2.Controls.Add(this.button1);
        this.panel2.Controls.Add(this.label2);
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
        // button4
        // 
        this.button4.Cursor = Cursors.Hand;
        this.button4.FlatAppearance.BorderSize = 0;
        this.button4.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.button4.FlatStyle = FlatStyle.Flat;
        this.button4.ForeColor = Color.White;
        this.button4.Image = (Image)resources.GetObject("button4.Image");
        this.button4.Location = new Point(14, 518);
        this.button4.Name = "button4";
        this.button4.Size = new Size(35, 35);
        this.button4.TabIndex = 7;
        this.button4.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        this.button3.BackColor = Color.FromArgb(33, 11, 97);
        this.button3.Cursor = Cursors.Hand;
        this.button3.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.button3.FlatStyle = FlatStyle.Flat;
        this.button3.Font = new Font("Arial Rounded MT Bold", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.button3.ForeColor = Color.WhiteSmoke;
        this.button3.Image = (Image)resources.GetObject("button3.Image");
        this.button3.ImageAlign = ContentAlignment.MiddleLeft;
        this.button3.Location = new Point(16, 361);
        this.button3.Name = "button3";
        this.button3.Size = new Size(226, 40);
        this.button3.TabIndex = 6;
        this.button3.Text = "SALARY";
        this.button3.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        this.button2.BackColor = Color.FromArgb(33, 11, 97);
        this.button2.Cursor = Cursors.Hand;
        this.button2.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.button2.FlatStyle = FlatStyle.Flat;
        this.button2.Font = new Font("Arial Rounded MT Bold", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.button2.ForeColor = Color.WhiteSmoke;
        this.button2.Image = (Image)resources.GetObject("button2.Image");
        this.button2.ImageAlign = ContentAlignment.MiddleLeft;
        this.button2.Location = new Point(14, 290);
        this.button2.Name = "button2";
        this.button2.Size = new Size(226, 40);
        this.button2.TabIndex = 5;
        this.button2.Text = "ADD EMPLOYEE";
        this.button2.UseVisualStyleBackColor = false;
        // 
        // button1
        // 
        this.button1.BackColor = Color.FromArgb(33, 11, 97);
        this.button1.Cursor = Cursors.Hand;
        this.button1.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.button1.FlatStyle = FlatStyle.Flat;
        this.button1.Font = new Font("Arial Rounded MT Bold", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.button1.ForeColor = Color.WhiteSmoke;
        this.button1.Image = (Image)resources.GetObject("button1.Image");
        this.button1.ImageAlign = ContentAlignment.MiddleLeft;
        this.button1.Location = new Point(15, 221);
        this.button1.Name = "button1";
        this.button1.Size = new Size(226, 40);
        this.button1.TabIndex = 4;
        this.button1.Text = "DASHBOARD";
        this.button1.UseVisualStyleBackColor = false;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new Font("Tahoma", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label2.ForeColor = Color.White;
        this.label2.Location = new Point(51, 166);
        this.label2.Name = "label2";
        this.label2.Size = new Size(145, 23);
        this.label2.TabIndex = 3;
        this.label2.Text = "Welecome, User";
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
        // MainForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 19F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.ButtonHighlight;
        this.ClientSize = new Size(1100, 600);
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
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Label X;
    private Panel panel2;
    private PictureBox pictureBox1;
    private Button button1;
    private Label label2;
    private Button button3;
    private Button button2;
    private Button button4;
    private Label label3;
}