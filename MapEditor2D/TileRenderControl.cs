using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapEditor2D.Map2D;
using WeifenLuo.WinFormsUI.Docking;

namespace MapEditor2D
{
    public partial class TileRenderControl : UserControl
    {
        private Map _map;

        public TileRenderControl()
        {
            InitializeComponent();
        }

        public void InitMap(Map map)
        {
            _map = map;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_map != null)
            {
                DrawLayers(e);
            }            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // TODO: Rectangle of visible area
        }

        private void DrawLayers(PaintEventArgs e)
        {
            var layers = _map.MapLayers.OrderBy(l => l.Index);
            foreach (var layer in layers)
            {
                if (layer.Visible)
                {
                    DrawLayer(e, layer);
                }
            }
        }

        private void DrawLayer(PaintEventArgs e, MapLayer layer)
        {
            for (int row = 0; row < layer.Data.Count; row++)
            {
                for (int col = 0; col < layer.Data[row].Count; col++)
                {
                    var tileIndex = layer.Data[row][col];
                    DrawTile(e, layer, row, col, tileIndex);
                }
            }
        }

        private void DrawTile(PaintEventArgs e, MapLayer layer, int row, int col, int tileIndex)
        {
            // Find image source from tile set and tile index

            var offset = GetDrawingOffset(
                new Rectangle(0, 0, _map.Columns * _map.TileWidth, _map.Rows * _map.TileHeight));

            e.Graphics.DrawRectangle(
                tileIndex == 0 ? Pens.Gray : Pens.Blue,
                offset.X + col * _map.TileWidth,
                offset.Y + row * _map.TileHeight,
                _map.TileWidth,
                _map.TileHeight);
        }

        private Point GetDrawingOffset(Rectangle drawObjectBounds)
        {
            var centerX = ClientRectangle.X + ClientRectangle.Width / 2;
            var centerY = ClientRectangle.Y + ClientRectangle.Height / 2;

            var x = centerX - drawObjectBounds.Width / 2;
            var y = centerY - drawObjectBounds.Height / 2;

            return new Point(x, y);
        }
    }
}
