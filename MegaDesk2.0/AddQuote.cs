using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Morris
{
    public partial class AddQuote : Form
    {
        Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
             
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
            _mainMenu.Show();
            this.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getQuoteBtn_Click(object sender, EventArgs e)
        {
            var desk = new Desk();
            var deskQuote = new DeskQuote();
            desk.Width = (int)deskWidthInput.Value;
            desk.Depth = (int)deskDepthInput.Value;
            desk.SurfaceMaterial = (DesktopMaterial)surfaceMaterialSelect.SelectedValue;
            desk.NumberOfDrawers = (int)numberOfDrawersSelect.Value;

            deskQuote.QuoteDesk = desk;
            deskQuote.FirstName = firstNameInput.Text;
            deskQuote.LastName = lastNameInput.Text;
            deskQuote.Date = DateTime.Now;
            deskQuote.Shipping = (rushOption)shippingSelect.SelectedValue;

            deskQuote.calcPrice();
            this.saveToFile(deskQuote);

            var displayQuoteForm = new DisplayQuote(deskQuote);
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show();
            this.Hide();


        }

        private void saveToFile(DeskQuote deskQuote)
        {
            //store quote in file

            //make list to put json in
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            string quotesFile = "deskQuotes.json";
            MemoryStream quotesStream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DeskQuote));
            ser.WriteObject(quotesStream, deskQuote);

            if (File.Exists(quotesFile))
            {
                //take all the stuff out of the quotes file, put it in a list, reserialize the list and overwrite the file
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    //A string of the whole file
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        //add stuff that exists in the list
                        //string to list
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }

            }
            //add to list of deskQuotes
            deskQuotes.Add(deskQuote);

            string serializedQuotes = JsonConvert.SerializeObject(deskQuotes);
            File.WriteAllText(quotesFile, serializedQuotes);


        }
    }
}




