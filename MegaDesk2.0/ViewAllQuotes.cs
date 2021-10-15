using Newtonsoft.Json;
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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            loadGrid();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();

        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadGrid()
        {

            //name of file, which is stored in bin
            var quotesFile = "deskQuotes.json";

            if (File.Exists(quotesFile))
            {

                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    //read the file
                    string quotes = reader.ReadToEnd();
                    //Turn it into a list so it can go into the grid
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    //loop through json to make a bunch of objects to use as the source for the grid.
                    //Select requires using linq at the top of the file
                    dataGridView1.DataSource = deskQuotes.Select(d => new
                    {
                        //create a new object
                        firstName = d.FirstName,
                        lastName = d.LastName,
                        date = d.Date,
                        shipping = d.Shipping,
                        depth = d.QuoteDesk.Depth,
                        width = d.QuoteDesk.Width,
                        numberOfDrawers = d.QuoteDesk.NumberOfDrawers,
                        surfaceMaterial = d.QuoteDesk.SurfaceMaterial,
                        quotePrice = d.Price.ToString("c") //format the price
                        //etc
                    }).ToList();

                }
            }
            else
            {

            }
        }

    }
}
