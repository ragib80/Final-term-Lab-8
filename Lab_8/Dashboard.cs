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
    public partial class Dashboard : Form
    {
        public Dashboard(User a)
        {
            InitializeComponent();
        }

        private void AddUserClick(object sender, EventArgs e)
        {
            new UserInfo().Show();
    }
    }
}
