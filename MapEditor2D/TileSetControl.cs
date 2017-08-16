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

        private Rectangle _prevSelectedTile;
        private Rectangle _selectedTile;
        private List<Rectangle> _selectedRectangles = new List<Rectangle>();


        public TileSetControl()
        {
            InitializeComponent();
            DoubleBuffered = true;
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
                DrawSelectedTiles(e);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // TODO: Rectangle of visible area
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            var tileCoords = GetTileUnderMouse(e.Location);
            _prevSelectedTile = _selectedTile;
            _selectedTile = new Rectangle(
                tileCoords.X * _map.TileWidth,
                tileCoords.Y * _map.TileHeight,
                _map.TileWidth,
                _map.TileHeight);
            _selectedRectangles.Add(_selectedTile);

            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
           base.OnMouseMove(e);

            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            var tileCoords = GetTileUnderMouse(e.Location);
            var tileRect = new Rectangle(
                tileCoords.X * _map.TileWidth,
                tileCoords.Y * _map.TileHeight,
                _map.TileWidth,
                _map.TileHeight);

            if (!_selectedRectangles.Contains(tileRect))
            {
                _selectedRectangles.Add(tileRect);
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _selectedRectangles.Clear();
        }

        private Point GetTileUnderMouse(Point mousePoint)
        {
            var x = Math.Floor((double)mousePoint.X / _map.TileWidth);
            var y = Math.Floor((double)mousePoint.Y / _map.TileHeight);
            return new Point((int)x, (int)y);
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
        }

        private void DrawSelectedTiles(PaintEventArgs e)
        {
            var brush = new SolidBrush(Color.FromArgb(128, Color.CornflowerBlue));

            foreach (var rect in _selectedRectangles)
            {
                e.Graphics.FillRectangle(brush, rect);
            }            
        }
    }
}
