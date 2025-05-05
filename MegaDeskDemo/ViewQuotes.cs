using System;
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
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
        }
        private void ReturnToMain()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }



        private void ViewQuotes_Load(object sender, EventArgs e)
        { }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            ReturnToMain();
        }
    }
}
