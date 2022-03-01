﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tk = txtusername.Text;
            string mk = txtpassword.Text;
            if(tk.Equals("") || mk.Equals("")) {
                MessageBox.Show("Username or password is not allowed empty!", "Notification");
                if (tk.Equals("")){
                    txtusername.Focus();
                }
                else {
                    txtpassword.Focus();
                }
            }else if (tk.Equals("nhan") && mk.Equals("123123")) {
                MessageBox.Show("Login success!","Notification");
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else {
                MessageBox.Show("Username or password wrong!","Notification");
                txtusername.Focus();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
                this.Close();
            }
        }
    }
}
