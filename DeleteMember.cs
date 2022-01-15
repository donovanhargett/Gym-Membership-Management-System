using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymMembershipVersion2._0
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will delete your data. Confirm?",  "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-RK03OGC\\DESKTOPWINDOWS; database = gym2; integrated security = True";
                SqlCommand cmd = new SqlCommand(); //COMMAD Object
                cmd.Connection = con;
                cmd.CommandText = "delete from NewMember where MID  = " + textBox1.Text + ""; //initially had txtenterid
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
            }
            else
            {
             ////this works
                this.Activate();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-RK03OGC\\DESKTOPWINDOWS; database = gym2; integrated security = True";
                SqlCommand cmd = new SqlCommand(); //COMMAD Object
                cmd.Connection = con;
                cmd.CommandText = "select * from NewMember";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds); 
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-RK03OGC\\DESKTOPWINDOWS; database = gym2; integrated security = True";
            SqlCommand cmd = new SqlCommand(); //COMMAD Object
            cmd.Connection = con;
            cmd.CommandText = "select * from NewMember";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
