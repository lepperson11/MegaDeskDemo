using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskDemo
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote DeskQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            DeskQuote = deskQuote;
            InitializeComponent();
        }

        private void ReturnToMain()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            ReturnToMain();
        }
    

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            CustomerName.Text = DeskQuote.customerName;
            QuoteDate.Text = DeskQuote.orderDate;
            string width = Convert.ToString(DeskQuote.desk.Width);
            string depth = Convert.ToString(DeskQuote.desk.Depth);
            string drawers = Convert.ToString(DeskQuote.desk.DrawerNumber);
            string shippingDays = Convert.ToString(DeskQuote.desk.ShippingDays);
            string material = DeskQuote.desk.Material;
            int SurfaceTotal = DeskQuote.desk.Width * DeskQuote.desk.Depth;

            string total = Convert.ToString(SurfaceTotal);

            WidthLabel.Text = width;
            DepthLabel.Text = depth;
            DrawerLabel.Text = drawers + " drawers";
            MaterialLabel.Text = material;
            DeliveryLabel.Text = shippingDays + " days";
            TotalSizeLabel.Text = total + " in^2";
        }

    }
}
