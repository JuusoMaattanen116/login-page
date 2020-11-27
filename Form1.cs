using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class Form1 : Form
    { Double count = 0;
        public Form1()


        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
     

            private void btnUlos_Click(object sender, EventArgs e)
        {

        }

        private void txtSalasana_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKäyttäjä_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string käyttäjä, salasana;
            käyttäjä = "pasi";
            salasana = "salasana";

            if ((txtUser.Text == käyttäjä) && (txtPass.Text == salasana))
            {
                MessageBox.Show("Welcome User");
            }
            else
            {

                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong user name or password" + "\t" + remain + "" + "tries left");
                txtPass.Clear();
                txtUser.Clear();
                txtUser.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded.");
                    Application.Exit();
                }
            }


        }
    }
}
