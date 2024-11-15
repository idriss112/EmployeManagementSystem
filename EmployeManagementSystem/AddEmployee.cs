using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;

namespace EmployeManagementSystem;
public partial class AddEmployee : UserControl
{
    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Idriss La\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");
    public AddEmployee()
    {
        this.InitializeComponent();
        this.displayEmployeeData();
    }

    public void displayEmployeeData()
    {
        EmployeeData ed = new EmployeeData();
        List<EmployeeData> listData = ed.EmployeeListData();

        this.dgvEmpData.DataSource = listData;
    }
    private void btnAddEmp_Click(object sender, EventArgs e)
    {
        if (this.tbAddEmpployeeId.Text == ""
            || this.tbAddEmpployeeFullName.Text == ""
            || this.cbAddEmpployeeGender.Text == ""
            || this.tbAddEmpployeePhone.Text == ""
            || this.cbAddEmpployeePos.Text == ""
            || this.cbAddEmpployeeStats.Text == ""
            || this.AddEmpployeePic.Image == null
            )
        {
            MessageBox.Show("Please fill all blank fiels",
                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (this.connect.State == ConnectionState.Closed)
            {
                try
                {
                    this.connect.Open();
                    string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID";

                    using (SqlCommand checkEm = new SqlCommand(checkEmID, this.connect))
                    {
                        checkEm.Parameters.AddWithValue("@emID", this.tbAddEmpployeeId.Text.Trim());
                        int count = (int)checkEm.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show(this.tbAddEmpployeeId.Text.Trim() + "is already taken",
                            "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DateTime today = DateTime.Today;
                            string insertData = "INSERT INTO employees" +
                                "(employee_id, full_name, gender, contact_number" +
                                ", position, image,salary,  insert_date, status)" +
                                "VALUES(@employeeID, @fullName, @gender, @contactNum" +
                                ",@position, @image,@salary, @insertDate, @status)";

                            string path = Path.Combine(@"C:\Users\Idriss La\source\repos\EmployeManagementSystem\EmployeManagementSystem\Directory\" + this.tbAddEmpployeeId.Text + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(this.AddEmpployeePic.ImageLocation, path, true);
                            using (SqlCommand cmd = new SqlCommand(insertData, this.connect))
                            {
                                cmd.Parameters.AddWithValue("@employeeID", this.tbAddEmpployeeId.Text.Trim());
                                cmd.Parameters.AddWithValue("@fullName", this.tbAddEmpployeeFullName.Text.Trim());
                                cmd.Parameters.AddWithValue("@gender", this.cbAddEmpployeeGender.Text.Trim());
                                cmd.Parameters.AddWithValue("@contactNum", this.tbAddEmpployeePhone.Text.Trim());
                                cmd.Parameters.AddWithValue("@position", this.cbAddEmpployeePos.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", path);
                                cmd.Parameters.AddWithValue("@salary", 0);
                                cmd.Parameters.AddWithValue("@insertDate", today);
                                cmd.Parameters.AddWithValue("@status", this.cbAddEmpployeeStats.Text.Trim());

                                cmd.ExecuteNonQuery();

                                this.displayEmployeeData();

                                MessageBox.Show("Added succesfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.connect.Close();
                }
            }
        }

    }

    private void btnImport_Click(object sender, EventArgs e)
    {
        try
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*jpg; *.png)|*.jpg;*.png";
            string imagePath = "";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                this.AddEmpployeePic.ImageLocation = imagePath;
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error: " + ex.Message, "Error Message"
               , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void AddEmployee_Load(object sender, EventArgs e)
    {
        
    }
}
