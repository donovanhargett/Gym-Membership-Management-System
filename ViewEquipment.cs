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
    public partial class ViewEquipment : Form
    {
        public ViewEquipment()
        {
            InitializeComponent();
        }

        private void ViewEquipment_Load(object sender, EventArgs e)
        {
            //form load event
            //load sql int
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-RK03OGC\\DESKTOPWINDOWS; database = gym2; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Equipment";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); //fills the table with the data
            dataGridView1.DataSource = ds.Tables[0];//adds table, makes it viewable

            

           



            //^^ SQL, pulls all data from database


        }
    }
}
