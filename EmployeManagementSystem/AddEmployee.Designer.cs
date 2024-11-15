namespace EmployeManagementSystem;

partial class AddEmployee
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.panel1 = new Panel();
        this.dgvEmpData = new DataGridView();
        this.label1 = new Label();
        this.panel2 = new Panel();
        this.cbAddEmpployeeStats = new ComboBox();
        this.label7 = new Label();
        this.cbAddEmpployeePos = new ComboBox();
        this.label6 = new Label();
        this.btnClearEmp = new Button();
        this.btnDeleteEmp = new Button();
        this.btnUpdateEmp = new Button();
        this.btnAddEmp = new Button();
        this.btnImport = new Button();
        this.AddEmpployeePic = new PictureBox();
        this.tbAddEmpployeePhone = new TextBox();
        this.label5 = new Label();
        this.cbAddEmpployeeGender = new ComboBox();
        this.label4 = new Label();
        this.tbAddEmpployeeFullName = new TextBox();
        this.label3 = new Label();
        this.tbAddEmpployeeId = new TextBox();
        this.label2 = new Label();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.dgvEmpData).BeginInit();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.AddEmpployeePic).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.BackColor = SystemColors.ButtonHighlight;
        this.panel1.BorderStyle = BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.dgvEmpData);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Location = new Point(17, 20);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(810, 274);
        this.panel1.TabIndex = 0;
        this.panel1.Paint += this.panel1_Paint;
        // 
        // dgvEmpData
        // 
        this.dgvEmpData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvEmpData.Location = new Point(22, 57);
        this.dgvEmpData.Name = "dgvEmpData";
        this.dgvEmpData.RowHeadersWidth = 49;
        this.dgvEmpData.Size = new Size(771, 189);
        this.dgvEmpData.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new Font("Tahoma", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label1.Location = new Point(25, 15);
        this.label1.Name = "label1";
        this.label1.Size = new Size(162, 27);
        this.label1.TabIndex = 0;
        this.label1.Text = "Emloyee's Data";
        // 
        // panel2
        // 
        this.panel2.BackColor = SystemColors.ButtonHighlight;
        this.panel2.BorderStyle = BorderStyle.FixedSingle;
        this.panel2.Controls.Add(this.cbAddEmpployeeStats);
        this.panel2.Controls.Add(this.label7);
        this.panel2.Controls.Add(this.cbAddEmpployeePos);
        this.panel2.Controls.Add(this.label6);
        this.panel2.Controls.Add(this.btnClearEmp);
        this.panel2.Controls.Add(this.btnDeleteEmp);
        this.panel2.Controls.Add(this.btnUpdateEmp);
        this.panel2.Controls.Add(this.btnAddEmp);
        this.panel2.Controls.Add(this.btnImport);
        this.panel2.Controls.Add(this.AddEmpployeePic);
        this.panel2.Controls.Add(this.tbAddEmpployeePhone);
        this.panel2.Controls.Add(this.label5);
        this.panel2.Controls.Add(this.cbAddEmpployeeGender);
        this.panel2.Controls.Add(this.label4);
        this.panel2.Controls.Add(this.tbAddEmpployeeFullName);
        this.panel2.Controls.Add(this.label3);
        this.panel2.Controls.Add(this.tbAddEmpployeeId);
        this.panel2.Controls.Add(this.label2);
        this.panel2.Location = new Point(17, 319);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(810, 219);
        this.panel2.TabIndex = 1;
        // 
        // cbAddEmpployeeStats
        // 
        this.cbAddEmpployeeStats.FormattingEnabled = true;
        this.cbAddEmpployeeStats.Items.AddRange(new object[] { "Active", "Inactive" });
        this.cbAddEmpployeeStats.Location = new Point(452, 124);
        this.cbAddEmpployeeStats.Name = "cbAddEmpployeeStats";
        this.cbAddEmpployeeStats.Size = new Size(168, 27);
        this.cbAddEmpployeeStats.TabIndex = 16;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new Point(386, 127);
        this.label7.Name = "label7";
        this.label7.Size = new Size(60, 20);
        this.label7.TabIndex = 15;
        this.label7.Text = "Status : ";
        // 
        // cbAddEmpployeePos
        // 
        this.cbAddEmpployeePos.FormattingEnabled = true;
        this.cbAddEmpployeePos.Items.AddRange(new object[] { "Business Management", "Front-End Developer", "Back-End Developer", "Data Adminstrator", "Software Enginer" });
        this.cbAddEmpployeePos.Location = new Point(452, 81);
        this.cbAddEmpployeePos.Name = "cbAddEmpployeePos";
        this.cbAddEmpployeePos.Size = new Size(168, 27);
        this.cbAddEmpployeePos.TabIndex = 14;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(374, 81);
        this.label6.Name = "label6";
        this.label6.Size = new Size(72, 20);
        this.label6.TabIndex = 13;
        this.label6.Text = "Position : ";
        // 
        // btnClearEmp
        // 
        this.btnClearEmp.BackColor = Color.FromArgb(33, 11, 97);
        this.btnClearEmp.Cursor = Cursors.Hand;
        this.btnClearEmp.FlatAppearance.BorderSize = 0;
        this.btnClearEmp.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.btnClearEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnClearEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnClearEmp.FlatStyle = FlatStyle.Flat;
        this.btnClearEmp.Font = new Font("Arial Rounded MT Bold", 10.0173912F);
        this.btnClearEmp.ForeColor = Color.White;
        this.btnClearEmp.Location = new Point(512, 173);
        this.btnClearEmp.Name = "btnClearEmp";
        this.btnClearEmp.Size = new Size(101, 34);
        this.btnClearEmp.TabIndex = 11;
        this.btnClearEmp.Text = "Clear";
        this.btnClearEmp.UseVisualStyleBackColor = false;
        // 
        // btnDeleteEmp
        // 
        this.btnDeleteEmp.BackColor = Color.FromArgb(33, 11, 97);
        this.btnDeleteEmp.Cursor = Cursors.Hand;
        this.btnDeleteEmp.FlatAppearance.BorderSize = 0;
        this.btnDeleteEmp.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.btnDeleteEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnDeleteEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnDeleteEmp.FlatStyle = FlatStyle.Flat;
        this.btnDeleteEmp.Font = new Font("Arial Rounded MT Bold", 10.0173912F);
        this.btnDeleteEmp.ForeColor = Color.White;
        this.btnDeleteEmp.Location = new Point(394, 173);
        this.btnDeleteEmp.Name = "btnDeleteEmp";
        this.btnDeleteEmp.Size = new Size(101, 34);
        this.btnDeleteEmp.TabIndex = 12;
        this.btnDeleteEmp.Text = "Delete";
        this.btnDeleteEmp.UseVisualStyleBackColor = false;
        // 
        // btnUpdateEmp
        // 
        this.btnUpdateEmp.BackColor = Color.FromArgb(33, 11, 97);
        this.btnUpdateEmp.Cursor = Cursors.Hand;
        this.btnUpdateEmp.FlatAppearance.BorderSize = 0;
        this.btnUpdateEmp.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.btnUpdateEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnUpdateEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnUpdateEmp.FlatStyle = FlatStyle.Flat;
        this.btnUpdateEmp.Font = new Font("Arial Rounded MT Bold", 10.0173912F);
        this.btnUpdateEmp.ForeColor = Color.White;
        this.btnUpdateEmp.Location = new Point(278, 173);
        this.btnUpdateEmp.Name = "btnUpdateEmp";
        this.btnUpdateEmp.Size = new Size(101, 34);
        this.btnUpdateEmp.TabIndex = 10;
        this.btnUpdateEmp.Text = "Update";
        this.btnUpdateEmp.UseVisualStyleBackColor = false;
        // 
        // btnAddEmp
        // 
        this.btnAddEmp.BackColor = Color.FromArgb(33, 11, 97);
        this.btnAddEmp.Cursor = Cursors.Hand;
        this.btnAddEmp.FlatAppearance.BorderSize = 0;
        this.btnAddEmp.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
        this.btnAddEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnAddEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnAddEmp.FlatStyle = FlatStyle.Flat;
        this.btnAddEmp.Font = new Font("Arial Rounded MT Bold", 10.0173912F);
        this.btnAddEmp.ForeColor = Color.White;
        this.btnAddEmp.Location = new Point(160, 173);
        this.btnAddEmp.Name = "btnAddEmp";
        this.btnAddEmp.Size = new Size(101, 34);
        this.btnAddEmp.TabIndex = 10;
        this.btnAddEmp.Text = "Add";
        this.btnAddEmp.UseVisualStyleBackColor = false;
        this.btnAddEmp.Click += this.btnAddEmp_Click;
        // 
        // btnImport
        // 
        this.btnImport.BackColor = Color.FromArgb(33, 11, 97);
        this.btnImport.Cursor = Cursors.Hand;
        this.btnImport.FlatAppearance.BorderSize = 0;
        this.btnImport.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
        this.btnImport.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
        this.btnImport.FlatStyle = FlatStyle.Flat;
        this.btnImport.Font = new Font("Tahoma", 8.765218F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.btnImport.ForeColor = Color.White;
        this.btnImport.Location = new Point(711, 133);
        this.btnImport.Name = "btnImport";
        this.btnImport.Size = new Size(82, 28);
        this.btnImport.TabIndex = 9;
        this.btnImport.Text = "Import";
        this.btnImport.UseVisualStyleBackColor = false;
        this.btnImport.Click += this.btnImport_Click;
        // 
        // AddEmpployeePic
        // 
        this.AddEmpployeePic.BackColor = SystemColors.ControlDarkDark;
        this.AddEmpployeePic.Location = new Point(711, 31);
        this.AddEmpployeePic.Name = "AddEmpployeePic";
        this.AddEmpployeePic.Size = new Size(82, 92);
        this.AddEmpployeePic.SizeMode = PictureBoxSizeMode.StretchImage;
        this.AddEmpployeePic.TabIndex = 8;
        this.AddEmpployeePic.TabStop = false;
        // 
        // tbAddEmpployeePhone
        // 
        this.tbAddEmpployeePhone.Location = new Point(452, 31);
        this.tbAddEmpployeePhone.Name = "tbAddEmpployeePhone";
        this.tbAddEmpployeePhone.Size = new Size(168, 26);
        this.tbAddEmpployeePhone.TabIndex = 7;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(327, 34);
        this.label5.Name = "label5";
        this.label5.Size = new Size(119, 20);
        this.label5.TabIndex = 6;
        this.label5.Text = "Phone Number : ";
        // 
        // cbAddEmpployeeGender
        // 
        this.cbAddEmpployeeGender.FormattingEnabled = true;
        this.cbAddEmpployeeGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
        this.cbAddEmpployeeGender.Location = new Point(133, 124);
        this.cbAddEmpployeeGender.Name = "cbAddEmpployeeGender";
        this.cbAddEmpployeeGender.Size = new Size(168, 27);
        this.cbAddEmpployeeGender.TabIndex = 5;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(49, 127);
        this.label4.Name = "label4";
        this.label4.Size = new Size(68, 20);
        this.label4.TabIndex = 4;
        this.label4.Text = "Gender : ";
        // 
        // tbAddEmpployeeFullName
        // 
        this.tbAddEmpployeeFullName.Location = new Point(132, 78);
        this.tbAddEmpployeeFullName.Name = "tbAddEmpployeeFullName";
        this.tbAddEmpployeeFullName.Size = new Size(168, 26);
        this.tbAddEmpployeeFullName.TabIndex = 3;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(37, 81);
        this.label3.Name = "label3";
        this.label3.Size = new Size(87, 20);
        this.label3.TabIndex = 2;
        this.label3.Text = "Full Name : ";
        // 
        // tbAddEmpployeeId
        // 
        this.tbAddEmpployeeId.Location = new Point(133, 31);
        this.tbAddEmpployeeId.Name = "tbAddEmpployeeId";
        this.tbAddEmpployeeId.Size = new Size(168, 26);
        this.tbAddEmpployeeId.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(22, 33);
        this.label2.Name = "label2";
        this.label2.Size = new Size(105, 20);
        this.label2.TabIndex = 0;
        this.label2.Text = "Employee ID : ";
        // 
        // AddEmployee
        // 
        this.AutoScaleDimensions = new SizeF(8F, 19F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Name = "AddEmployee";
        this.Size = new Size(848, 565);
        this.Load += this.AddEmployee_Load;
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.dgvEmpData).EndInit();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.AddEmpployeePic).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Panel panel2;
    private DataGridView dgvEmpData;
    private TextBox tbAddEmpployeePhone;
    private Label label5;
    private ComboBox cbAddEmpployeeGender;
    private Label label4;
    private TextBox tbAddEmpployeeFullName;
    private Label label3;
    private TextBox tbAddEmpployeeId;
    private Label label2;
    private Button btnClearEmp;
    private Button btnDeleteEmp;
    private Button btnUpdateEmp;
    private Button btnAddEmp;
    private Button btnImport;
    private PictureBox AddEmpployeePic;
    private ComboBox cbAddEmpployeePos;
    private Label label6;
    private ComboBox cbAddEmpployeeStats;
    private Label label7;
}
