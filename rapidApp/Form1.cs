using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rapidApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string[] adminData = File.ReadAllLines("admin.csv");
            var admins = adminData.Select(x => x.Split('|')).ToList();
            string userName = txt_UserName.Text;
            string password = txt_Password.Text;

            bool isValidUser = admins.Any(a => a[0] == userName && a[1] == password);

            if (isValidUser)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_UserName.Text = "admin";
            txt_Password.Text = "1234";
        }
    }
}
