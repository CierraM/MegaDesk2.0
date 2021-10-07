using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Morris
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine,

    }
    public class Desk
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public  int NumberOfDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }
        public decimal SurfaceArea { get; set; }

    }
}
