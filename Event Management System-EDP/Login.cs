using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System_EDP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (textBox1.Text == "admin" && textBox2.Text == "admin") 
                {
                    Events eventForm = new Events();
                    eventForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
