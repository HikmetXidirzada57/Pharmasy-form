using PharmacyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class User : Form
    {
        PharmasyDBT110Context pdb = new PharmasyDBT110Context();
        Admin admin;
        public User()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string[] Userinfo = new string[] { Username, Password };
            admin = pdb.Admins.FirstOrDefault(x => x.Fullname==Username);
            if (Utilities.IsEmpty(Userinfo))
            {
                if (admin.Fullname==Username &&(admin.Password==Password))
                {
                    Form1 fm = new();
                    fm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User name or password isn't true!");
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
