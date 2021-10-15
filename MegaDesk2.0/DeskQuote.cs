
﻿using System;
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
        public int Price;

        private const int _BASE_DESK_PRICE = 200;
        private const int _COST_PER_SQUARE_INCH = 1;
        private const int _COST_PER_DRAWER = 50;
        private const int _COST_OAK = 200;
        private const int _COST_LAMINATE = 100;
        private const int _COST_PINE = 50;
        private const int _COST_ROSEWOOD = 300;
        private const int _COST_VENEER = 125;

        private int _surfaceArea;
        private int _extraAreaCost;
        private int _drawersCost;
        private int _materialCost;
        string priceFile = "RushOrderPrices.txt"; //pull prices from price file
        int[,] shippingPrices = new int[3, 3];
        private int _shippingCost;
        private int _surfaceAreaIndex;


        public void calcPrice()
        {
            // Calculate surface area
            _surfaceArea = this.QuoteDesk.Width * this.QuoteDesk.Depth;

            // Calculate the surface area index
            if (_surfaceArea < 1000)
            {
                _surfaceAreaIndex = 0;
            }
            else if (_surfaceArea > 1000 && _surfaceArea < 2000)
            {
                _surfaceAreaIndex = 1;
            }
            else
            {
                _surfaceAreaIndex = 2;
            }

            // Calculate the extra area cost
            if (_surfaceArea > 1000) _extraAreaCost = (_surfaceArea - 1000) * _COST_PER_SQUARE_INCH;


            // Calculate the drawers cost
            _drawersCost = this.QuoteDesk.NumberOfDrawers * _COST_PER_DRAWER;

            // Calculate the materials cost
            switch (this.QuoteDesk.SurfaceMaterial)
            {
                case DesktopMaterial.Laminate:
                    _materialCost = _COST_LAMINATE;
                    break;
                case DesktopMaterial.Oak:
                    _materialCost = _COST_OAK;
                    break;
                case DesktopMaterial.Pine:
                    _materialCost = _COST_PINE;
                    break;
                case DesktopMaterial.Rosewood:
                    _materialCost = _COST_ROSEWOOD;
                    break;
                case DesktopMaterial.Veneer:
                    _materialCost = _COST_VENEER;
                    break;

            }

            // Gets and sets up shipping price 3x3 array based on file 
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

            //Set shipping cost to 0 as default shipping
            _shippingCost = 0;

            // if the the shippin is not the default, set cost based on shipping speed and surface area with the array.
            if (this.Shipping != rushOption.NoRush)
            {
                _shippingCost = shippingPrices[(int)this.Shipping, _surfaceAreaIndex];
            }

            //Calculate added price for material
            this.Price = _BASE_DESK_PRICE + _extraAreaCost + _materialCost + _shippingCost + _drawersCost;

            //Return calculated sum to the DeskQuote object
            
        }
    }
}
