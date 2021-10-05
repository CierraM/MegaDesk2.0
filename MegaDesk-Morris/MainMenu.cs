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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewQuoteBtn_Click(object sender, EventArgs e)
        {
            var viewQuoteForm = new ViewAllQuotes();
            viewQuoteForm.Tag = this;
            viewQuoteForm.Show();
            this.Hide();
        }

        private void searchQuoteBtn_Click(object sender, EventArgs e)
        {
            var searchQuoteForm = new SearchQuotes();
            searchQuoteForm.Tag = this;
            searchQuoteForm.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Write stuff that needs to happen when the page loads
        }
    }
}
