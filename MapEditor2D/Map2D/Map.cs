using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor2D.Map2D
{
    public class Map
    {
        // A map contains map layers
        // A map references tile sets used in map layers        

        public List<MapLayer> MapLayers { get; set; } = new List<MapLayer>();
        public int TileWidth { get; set; }
        public TileSet TileSet { get; set; }
        public int TileHeight { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
    }
}
