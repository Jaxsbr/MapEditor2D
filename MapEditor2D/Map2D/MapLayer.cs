using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor2D.Map2D
{
    public class MapLayer
    {
        // Map layer contains placement definition for tiles
        // Map layer contains collision flags
        public int Index { get; set; }
        public bool Visible { get; set; } = true;        
        public List<List<int>> Data { get; set; } = new List<List<int>>();
    }
}
