using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknoSatis.Models;
using TeknoSatis.Services.Concretes;

namespace TeknoSatis
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        MainMenu frm = new MainMenu();
        private void button1_Click(object sender, EventArgs e)
        {
            if(Services.Concretes.LogInControl.AutControl(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Log In Succesful");
                frm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Log In Failed.Please Try Again");
            }


        }

        public string GetUsername()
        {


            return txtUserName.Text;

        }
        public string GetPassword()
        {
            return txtPassword.Text;
        }
    }
}
