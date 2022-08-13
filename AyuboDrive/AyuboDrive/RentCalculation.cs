using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AyuboDrive
{
    public partial class RentCalculationForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RODO9FP\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;

        int x, y, z,a;
        string f;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mm = new MainMenuForm();
            mm.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                f = "Yes";
            }
            else if (radioButton2.Checked == true)
            {
                f = "No";
            }

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Rent_Calculation set Vehicle_Type = '" + txtVehicleType.Text + "', Rented_Date = '" + txtRentedDate.Text + "',Return_Date = '" + txtReturnDate.Text + "', With_Driver = '" + f + "', Total_Rent_Value = '" + txtTotalRentValue.Text + "' where Record_ID = '" + txtRecordID.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Rent_Calculation where Record_ID = '" + txtRecordID.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("Select * from Rent_Calculation", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public RentCalculationForm()
        {

            InitializeComponent();

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                f = "Yes";
            }
            else if (radioButton2.Checked == true)
            {
                f = "No";
            }
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Rent_Calculation values ('" + txtRecordID.Text + "','" + txtVehicleType.Text + "','" + txtRentedDate.Text + "','" + txtReturnDate.Text + "','"+ f +"','" + txtTotalRentValue.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Inserted Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txtReturnDate.Text);
            y = Convert.ToInt32(txtRentedDate.Text);
            z = x-y;
            if (radioButton1.Checked == true)
            {
                if (txtVehicleType.Text == "Small Car")
                {
                    //100 is vehicle rent and 50 is driver rent and z is the days of hiring
                    a = 5000 + 500 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Sedan Car")
                {
                    a = 7500 + 500 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "SVUs")
                {
                    a = 10000 + 500 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Jeep WD")
                {
                    a = 12500 + 500 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if( txtVehicleType.Text == "7 Seeter Van")
                {
                    a = 15000 + 500 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Commuter Van")
                {
                    a = 18000 + 500 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
            }
            else
            {
                if (txtVehicleType.Text == "Small Car")
                {
                    a = 5000 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Sedan Car")
                {
                    a = 7500 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "SVUs")
                {
                    a = 10000 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Jeep WD")
                {
                    a = 12500 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "7 Seeter Van")
                {
                    a = 15000 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Commuter Van")
                {
                    a = 18000 + z;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
            }
            
        }
    }
}
