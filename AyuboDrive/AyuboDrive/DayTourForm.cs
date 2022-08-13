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
    public partial class DayTourForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RODO9FP\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        int z,d,g,a,k,l,i,o,p,u,s,j,y,t;

        private void btnShow_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("Select * from Day_Tour", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mmf = new MainMenuForm();
            mmf.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Day_Tour where Record_ID = '" + txtRecordID.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Day_Tour set Vehicle_Type = '" + txtVehicleType.Text + "', Package_Type = '" + txtPackageType.Text + "',Start_Time = '" + txtStartTime.Text + "', End_Time = '" + txtEndTime.Text + "', Start_Km_Reading = '" + txtStartKMreading.Text + "', End_Km_Reading = '" + txtEndKMreading.Text + "', Hire_Charge = '" + txtTotalRentValue.Text + "', Waiting_Charge = '" + txtWaitedForTime.Text + "' , Extra_Km_Charge = '" + txtExtraKMCharge.Text + "'    where Record_ID = '" + txtRecordID.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DayTourForm()
        {
            
            InitializeComponent();

        }

        private void DayTourForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Day_Tour values ('" + txtRecordID.Text + "','" + txtVehicleType.Text + "','" + txtPackageType.Text + "','" + txtStartTime.Text + "','" + txtEndTime.Text + "','" + txtStartKMreading.Text + "','" + txtEndKMreading.Text + "','" + txtTotalRentValue.Text + "','" + txtWaitedForTime.Text + "','" + txtExtraKMCharge.Text + "')";
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
            s = Convert.ToInt32(txtStartTime.Text);
            j = Convert.ToInt32(txtEndTime.Text);
            y = j - i;
            t = y /2;

            d = Convert.ToInt32(txtStartKMreading.Text);
            g = Convert.ToInt32(txtEndKMreading.Text);
            z = g-d;
            
            l = Convert.ToInt32(txtPackageType.Text);
            if (l == 100)
            {
                if (txtVehicleType.Text == "Small Car")
                {
                    //100 is vehicle rent and 50 is driver rent and z is the days of hiring
                    a = (500 * t) + (z * 10) + 500;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Sedan Car")
                {
                    a = (750 * t) + (z * 10) + 500;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "SVUs")
                {
                    a = a = (1000 * t) + (z * 10) + 500;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Jeep WD")
                {
                    a = (1250 * t) + (z * 10) + 500;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "7 Seeter Van")
                {
                    a = (1500 * t) + (z * 10) + 500;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Commuter Van")
                {
                    a = (1800 * t) + (z * 10) + 500;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
            }
            else if(l == 200)
                {
                if (txtVehicleType.Text == "Small Car")
                {
                    //100 is vehicle rent and 50 is driver rent and z is the days of hiring
                    a = (500 * t) + (z * 10) + 1000;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Sedan Car")
                {
                    a = (750 * t) + (z * 10) + 1000;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "SVUs")
                {
                    a = (1000 * t) + (z * 10) + 1000;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Jeep WD")
                {
                    a = (1250 * t) + (z * 10) + 1000;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "7 Seeter Van")
                {
                    a = (1500 * t) + (z * 10) + 1000;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
                else if (txtVehicleType.Text == "Commuter Van")
                {
                    a = (2000 * t) + (z * 10) + 1000;
                    txtTotalRentValue.Text = Convert.ToString(a);
                }
            }

            //For extra waiting Time
            i = Convert.ToInt32(txtWaitedForTime.Text);
            o = i * 100;
            txtTotalwaitingCharge.Text = Convert.ToString(o);
            //for extra KM
            if (z>l)
            {
                p = z - l;
                u = 100 * p;
                txtExtraKMCharge.Text = Convert.ToString(u);
            }
            if(z<l)
            {
                u = 0;
                txtExtraKMCharge.Text = Convert.ToString(u);
            }
            }
        }
    }

