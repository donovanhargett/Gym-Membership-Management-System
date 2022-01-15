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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Login Page

        private void button_Login_Click(object sender, EventArgs e)
        {
            if(textBox_UserName.Text == "admin" && TXTPASSWORD.Text == "1234")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect username or password, try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Application.Exit();
            //doesnt work
        }

        private void TXTPASSWORD_TextChanged(object sender, EventArgs e)
        {
            //don't worry abt
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //doesn
      
            TXTPASSWORD.Clear();
            textBox_UserName.Clear();   
            textBox_UserName.Focus();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TXTPASSWORD.Clear();
            textBox_UserName.Clear();
            textBox_UserName.Focus();

        }
    }
}
