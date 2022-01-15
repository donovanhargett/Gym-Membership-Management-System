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
    public partial class AddNewMemberScreen : Form
    {
        public AddNewMemberScreen()
        {
            InitializeComponent();
        }

        //might need to comment these 2 out
        //LEAVE THEM IN!!!!!!!!
        //called click events


        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Fname = txtFirstName.Text;
            string Lname = txtLastName.Text;
            string gender = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string email = textEmail.Text;
            string joindate = dateTimePickerJoinDate.Text;
            string gymTime = comboBoxGymTime.Text;
            string address = txtAddress.Text;
            string membership = comboBoxMembership.Text;
            //create connection to database


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-RK03OGC\\DESKTOPWINDOWS; database = gym2; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,GymTime,Maddress,MembershipTime) values ('" + Fname + "','" + Lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + gymTime + "','" + address + "','" + membership + "')";
           //^^ make changes to newmember accordingly

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
   
            MessageBox.Show("Data saved!");



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clears all text boxesw
            txtFirstName.Clear();
            txtLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobile.Clear();
            textEmail.Clear();
            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();
            txtAddress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;


        }
    }
}



/*
 * create table NewMember
(
MID int NOT NULL IDENTITY(1,1) primary key,
Fname varchar(150) Not null,
Lname varchar(150) Not null,
Gender varchar(20) Not null,
Dob varchar(100) Not null,
Mobile bigint not null,
Email varchar(150),
JoinDate varchar(100) Not null,
Gymtime varchar(120) Not null,
Maddress varchar(250) Not null,
MembershipTime varchar(120) Not null
);

select * from NewMember;
*/
