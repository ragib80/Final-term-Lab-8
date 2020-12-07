﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void LoginClick(object sender, EventArgs e)
        {
            string userName = "";
            string password = "";
            string errMsg = "";
            bool hasError = false;

            if (textBoxName.Text.Equals(""))
            {
                errMsg = "\nUsername Required";
                hasError = true;
            }
            else
            {
                userName = textBoxName.Text;
            }
            if (textBoxName.Text.Equals(""))
            {
                errMsg += "\nPassword Required";
            }
            else
            {
                password = textBoxPass.Text;
            }
            if(!hasError)
            {
                if(userName.Equals("18-38278-2") && password.Equals("ragib"))
                {
                    User u = new User();
                    u.Name = userName;
                    u.Password = password;
                    new Dashboard(u).Show();
                    MessageBox.Show("Login Successful");
                }
                else 
                {
                    MessageBox.Show("Login failed, Invalid Username or Password");  
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }
    }
}
