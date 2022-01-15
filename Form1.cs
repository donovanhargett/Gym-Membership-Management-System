using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembershipVersion2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //double click so sideback does sideways
            if(b==true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\Donovan Hargett\Documents\img\img2.jpg");

            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\Donovan Hargett\Documents\img\img2.jpg");
            }
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when you click on new member 
            AddNewMemberScreen nm = new AddNewMemberScreen();
            nm.Show();
        }

        private void newStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();

        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipment eq = new AddEquipment();
            eq.Show();  
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();


        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will close the application. Are you sure?", "Close", MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logout page
            if(MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.Close();
                Login loginf = new Login(); 
                loginf.Show();

            }
        }
    }
}
