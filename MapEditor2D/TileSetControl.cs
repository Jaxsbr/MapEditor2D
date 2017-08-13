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

namespace MapEditor2D
{
    public partial class TileSetControl : UserControl
    {
        private Map _map;
        private Image _image;

        public TileSetControl()
        {
            InitializeComponent();
        }

        public void InitMap(Map map)
        {
            _map = map;
            if (_map != null && _map.TileSet != null)
            {
                _image = Image.FromFile(_map.TileSet.ImagePath);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_map != null && _map.TileSet != null)
            {
                DrawTileSet(e);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // TODO: Rectangle of visible area
        }

        private void DrawTileSet(PaintEventArgs e)
        {
            e.Graphics.DrawImage(_image, new Point(0, 0));

            var rows = _image.Height / _map.TileHeight;
            var cols = _image.Width / _map.TileWidth;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    DrawTile(e, row, col);
                }
            }
        }

        private void DrawTile(PaintEventArgs e, int row, int col)
        {
            e.Graphics.DrawRectangle(
                Pens.Gray,
                col * _map.TileWidth,
                row * _map.TileHeight,
                _map.TileWidth,
                _map.TileHeight);

            //var destRect = new Rectangle(
            //    col * _map.TileWidth,
            //    row * _map.TileHeight,
            //    _map.TileWidth,
            //    _map.TileHeight);

            //var srcRect = new Rectangle(
            //    col * _map.TileWidth, 
            //    row * _map.TileHeight,
            //    _map.TileWidth,
            //    _map.TileHeight
            //);

            //e.Graphics.DrawImage(
            //    _image,
            //    destRect,
            //    srcRect,
            //    GraphicsUnit.Pixel);
        }
    }
}
