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

    }
}
