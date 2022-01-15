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


namespace GymMembershipVersion2._0
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //leave it be
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname = txtFname.Text;
            string lastname = txtLname.Text;
            string email = txtEmail.Text;
            string gender = "";
            bool isChecked = radioButton1.Checked;
            


            if (isChecked)
            {
                gender = radioButton1.Text;
                //yes to gender = male
            }
            else
            {
                gender = radioButton2.Text;
                //yes to gender = female
            }
            string dob = dateTimePickerDOB.Text;
            
            Int64 mobile = Int64.Parse(txtMobile.Text);
            
            string joindate = dateTimePickerJoinDate.Text;
            string state = txtState.Text;
            string city = txtCity.Text;



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-RK03OGC\\DESKTOPWINDOWS; database = gym2; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewStaff (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Statee,City) values ('" + firstname + "','" + lastname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + state + "','" + city + "')";
            //^^ make changes to newmember accordingly

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved!");


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //leave
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtFname.Clear();
            txtLname.Clear();   
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobile.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtEmail.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;

        }
    }
}



/*
 * create table NewStaff
(
SID int not null IDENTITY(1,1) primary key,
Fname varchar(150) Not null,
Lname varchar(150) Not null,
Gender varchar(20) Not null,
Dob varchar(100) Not null,
Mobile bigint not null,
Email varchar(150),
JoinDate varchar(100) Not null,
Statee varchar(100) Not null,
City varchar(100) Not null
);

select * from NewStaff;
*/
