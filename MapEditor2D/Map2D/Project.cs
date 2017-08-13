using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor2D.Map2D
{
    public class Project
    { 
        public string ProjectFilePath { get; set; }
        public string ProjectName { get; set; }
        public Map Map { get; set; }
        public List<TileSet> TileSets { get; set; } = new List<TileSet>();
    }
}
