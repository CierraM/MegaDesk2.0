using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Morris
{
    public enum rushOption
    {
        Rush3day,
        Rush5day,
        Rush7day,
        NoRush
    }
    public class DeskQuote
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public Desk QuoteDesk { get; set; }
        public rushOption Shipping { get; set; }

        public Decimal Price { get; set; }

        public int calcPrice()
        {
            //calculate price
            //initialize base price
            int total = 200;

            //add surface area price
            int surfaceArea = this.QuoteDesk.Width * this.QuoteDesk.Depth;
            int surfaceAreaIndex;
            if (surfaceArea < 1000)
            {
                surfaceAreaIndex = 0;
            }
            else if (surfaceArea > 1000 && surfaceArea < 2000){
                surfaceAreaIndex = 1;
            }
            else
            {
                surfaceAreaIndex = 2;
            }
            if (surfaceAreaIndex >= 1)
            {
                total += (surfaceArea - 1000);
            }

            //add drawers price
            total += this.QuoteDesk.NumberOfDrawers * 50;

            //add materials price

            //add shipping price
            //pull prices from price file
            var priceFile = "RushOrderPrices.txt";

            int[,] shippingPrices = new int[3, 3];
            if (File.Exists(priceFile))
            {

                using (StreamReader reader = new StreamReader(priceFile))
                {
                    //shipping prices: a 3x3 array of the price grid
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            string line = reader.ReadLine();
                            int price = int.Parse(line);
                            shippingPrices[i, j] = price;
                        }
                    }

                }
            }


            //question: how to link the double array up to the user's input??
            //switch statement on this.shipping


            //int shippingCost = 0;
            int shippingCost = 0;
                
            if (this.Shipping == rushOption.NoRush)
            {
                shippingCost = 0;
            }
            else
            {
                shippingCost = shippingPrices[(int)this.Shipping, surfaceAreaIndex];
            }

            //Calculate added price for material
            switch (this.QuoteDesk.SurfaceMaterial)
            {
                case DesktopMaterial.Laminate:
                    total += 100;
                    break;
                case DesktopMaterial.Oak:
                    total += 200;
                    break;
                case DesktopMaterial.Pine:
                    total += 50;
                    break;
                case DesktopMaterial.Rosewood:
                    total += 300;
                    break;
                case DesktopMaterial.Veneer:
                    total += 125;
                    break;

            }

            total += shippingCost;

            return total;
        }
    }
}
