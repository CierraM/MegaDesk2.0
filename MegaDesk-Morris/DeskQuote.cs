using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Morris
{
    public enum rushOption
    {
        NoRush,
        Rush3day,
        Rush5day,
        Rush7day
    }
    public class DeskQuote
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public Desk QuoteDesk { get; set; }
        public rushOption Shipping { get; set; }

        public decimal CalculatePrice()
        {
            decimal price = 0;

            return price;
        }
    }
}
