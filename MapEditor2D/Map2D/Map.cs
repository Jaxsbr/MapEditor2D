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


// What is a map?
// A map is one of many areas in a game.
// Typically a player can relocate to different maps during game play and thus reach different areas.
// A map is requires the following to be usable by the game:

// Map - Container
// - A single outer container that allows the simple management of an enter map with all it's sub components

// Tile Information 
// - Tile Height and Width
// - Tile Rows and Columns

// Collision Layer
// - A 2 dimentional grid that correlates to tile row and columns
// - Tile information regarding tile passablility

// Map Layers - Container
// - Layer
//   - TileSetInfo
//     - Tileset Image
//     - Tileset Tile Width and Height
//     - Tileset Tile Rows and Cols
//   - TileGrid - 2 dimentional grid
//     - Tile
//       - Row and Column coordinates (e.g. tile 0,0 is the first tile in the grid)
//       - Tileset Index - the source image from the tileset image