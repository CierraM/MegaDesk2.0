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

namespace MegaDesk_Morris
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            // populate materials combobox
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            surfaceMaterialSelect.DataSource = materials;
            surfaceMaterialSelect.SelectedIndex = -1;

            //populate shipping combobox
            List<rushOption> options = Enum.GetValues(typeof(rushOption)).Cast<rushOption>().ToList();
            shippingSelect.DataSource = options;
            shippingSelect.SelectedIndex = -1;

            var todayDate = DateTime.Now;
            date.Text = todayDate.ToString("d MMMM yyyy");
        }
        
        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getQuoteBtn_Click(object sender, EventArgs e)
        {
            var desk = new Desk();
            var deskQuote = new DeskQuote();
            desk.Width = (int) deskWidthInput.Value;
            desk.Depth = (int) deskDepthInput.Value;
            desk.SurfaceMaterial = (DesktopMaterial)surfaceMaterialSelect.SelectedValue;
            desk.NumberOfDrawers = (int) numberOfDrawersSelect.Value;

            deskQuote.QuoteDesk = desk;
            deskQuote.FirstName = firstNameInput.Text;
            deskQuote.LastName = lastNameInput.Text;
            deskQuote.Date = DateTime.Now;
            deskQuote.Shipping = (rushOption) shippingSelect.SelectedValue;

            //TODO:
            //pull prices from price file
            var priceFile = "RushOrderPrices.txt";
            
            if (File.Exists(priceFile))
            {

                using (StreamReader reader = new StreamReader(priceFile))
                {
                    
                    int[,] prices = new int[3,3];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            string line = reader.ReadLine();
                            int price = int.Parse(line);
                            prices[i, j] = price;
                        }
                    }

                }
            }
            else
            {

            }
            //calculate price

            //store quote in file
        }
    }
}
