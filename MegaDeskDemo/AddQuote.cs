﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskDemo
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }
        
        private void ReturnToMain()
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GoBack(object sender, EventArgs e)
        {
            ReturnToMain();
        }
    }
}
