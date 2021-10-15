using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Morris
{
    public partial class DisplayQuote : Form
    {
        private Form _displayQuote;

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            

            deskWidthInput.Value = deskQuote.QuoteDesk.Width;
            deskDepthInput.Value = deskQuote.QuoteDesk.Depth;

            surfaceMaterialSelect.SelectedValue = deskQuote.QuoteDesk.SurfaceMaterial;
            numberOfDrawersSelect.Value = deskQuote.QuoteDesk.NumberOfDrawers;


            firstNameInput.Text = deskQuote.FirstName;
            lastNameInput.Text = deskQuote.LastName;
            shippingSelect.SelectedValue = deskQuote.Shipping;
            

            date.Text = deskQuote.Date.ToString("dd/MM/yyyy");
            price.Text = deskQuote.Price.ToString("c");

            this.Enabled = false;
        }

       



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
