using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace EmployeManagementSystem;
internal class EmployeeData
{

    public int ID { get; set; }
    public string EmployeeID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Contact { get; set; }
    public string position { get; set; }
    public string Image { get; set; }
    public int Salary {  get; set; }
    public string Status { get; set; }

    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Idriss La\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");

    public List<EmployeeData> EmployeeListData()
    {
        List<EmployeeData> listdata = new List<EmployeeData>();

        if(this.connect.State != ConnectionState.Open)
        {
            try
            {
                this.connect.Open();

                string selectData = "SELECT * FROM employee WHERE delete_date IS NULL";

                using(SqlCommand cmd = new SqlCommand(selectData,this.connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        EmployeeData ed = new EmployeeData();
                        ed.ID =(int)reader["ID"];
                        ed.EmployeeID = reader["employee_id"].ToString();
                        ed.Name = reader["full_name"].ToString();
                        ed.Gender = reader["gender"].ToString();
                        ed.Contact = reader["contact_number"].ToString();
                        ed.position = reader["position"].ToString();
                        ed.Image = reader["image"].ToString();
                        ed.Salary = (int)reader["salary"];
                        ed.Status = reader["status"].ToString();

                        listdata.Add(ed);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
                
            }
            finally
            {
                this.connect.Close();
            }

            
        }
        return listdata;
    }
}
