using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GymMembershipVersion2._0
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //leave
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearchBox.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-RK03OGC\\DESKTOPWINDOWS; database = gym2; integrated security = True";
                SqlCommand cmd = new SqlCommand(); //COMMAD Object
                cmd.Connection = con;
                cmd.CommandText = "select * from NewMember where MID = " + txtSearchBox.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
               
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter a valid ID", "Message",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }

        private void SearchMember_Load(object sender, EventArgs e)
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
