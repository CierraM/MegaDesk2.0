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
        public int Width { get; set; }
        public int Depth { get; set; }
        public  int NumberOfDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }
        public decimal SurfaceArea { get; set; }

    }
}
