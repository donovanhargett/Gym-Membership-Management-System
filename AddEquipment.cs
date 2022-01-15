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
    public partial class AddEquipment : Form
    {
        public AddEquipment()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //dont touch
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string EquipName = txtEquipmentName.Text;
            string Description = txtDescription.Text;
            string MUsed = txtMusclesUsed.Text;
            string DDate = dateTimePickerDateDelivered.Text;
            Int64 cost = Int64.Parse(txtCost.Text);

            //sql connnection


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-RK03OGC\\DESKTOPWINDOWS; database = gym2; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipment (EquipName,EDescription,MUSed,DDate,Cost) values ('" + EquipName + "','" + Description + "','" + MUsed + "','" + DDate + "'," + cost + ")";
            //^^ make changes to newmember accordingly

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtCost.Clear();
            txtDescription.Clear();
            txtEquipmentName.Clear();
            txtMusclesUsed.Clear();
            dateTimePickerDateDelivered.Value = DateTime.Now;

        }

        private void btn_View_Equipment_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
