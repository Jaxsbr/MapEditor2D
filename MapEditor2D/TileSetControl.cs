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

        private Point _startPoint;

        public delegate void TileSelectedEventHandler(Point tileCoords, int tileIndex, Bitmap tileImage);
        public TileSelectedEventHandler OnTileSelected;

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

            var tileCoords = GetTileCoordinateFromPoint(e.Location);            

            _startPoint = e.Location;
            _prevSelectedTile = _selectedTile;
            _selectedTile = new Rectangle(
                tileCoords.X * _map.TileWidth,
                tileCoords.Y * _map.TileHeight,
                _map.TileWidth,
                _map.TileHeight);

            Invalidate();

            OnTileSelected.Invoke(tileCoords, GetTileIndexFromCoords(tileCoords), GetTileImage(tileCoords));
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left && CalculateSelectedTiles(e.Location))
            {
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            var tileCoords = GetTileCoordinateFromPoint(e.Location);
            OnTileSelected.Invoke(tileCoords, GetTileIndexFromCoords(tileCoords), GetTileImage(tileCoords));

            _selectedRectangles.Clear();
            _startPoint = Point.Empty;
        }


        private Bitmap GetTileImage(Point tileCoords)
        {
            var src = _image as Bitmap;
            var target = new Bitmap(_selectedTile.Width, _selectedTile.Height);

            using (var graphics = Graphics.FromImage(target))
            {
                graphics.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), _selectedTile, GraphicsUnit.Pixel);
            }

            return target;
        }

        private int GetTileIndexFromCoords(Point coords)
        {
            var rows = _image.Height / _map.TileHeight;
            var cols = _image.Width / _map.TileWidth;
            var index = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (coords.X == col && coords.Y == row)
                    {
                        return index;
                    }
                    index++;
                }
            }

            return -1;
        }

        private bool CalculateSelectedTiles(Point mousePoint)
        {
            var added = false;
            var inputA = _startPoint;
            var inputB = mousePoint;

            var startPoint = new Point(Math.Min(inputA.X, inputB.X), Math.Min(inputA.Y, inputB.Y));
            var endPoint = new Point(Math.Max(inputA.X, inputB.X), Math.Max(inputA.Y, inputB.Y));

            var startTileCoords = GetTileCoordinateFromPoint(startPoint);
            var endTileCoords = GetTileCoordinateFromPoint(endPoint);

            var xTiles = startTileCoords.X + (endTileCoords.X - startTileCoords.X) + 1; // + 1 offset
            var yTiles = startTileCoords.Y + (endTileCoords.Y - startTileCoords.Y) + 1; // + 1 offset

            _selectedRectangles.Clear();

            for (int y = startTileCoords.Y; y < yTiles; y++)
            {
                for (int x = startTileCoords.X; x < xTiles; x++)
                {
                    var tileRect = new Rectangle(x * _map.TileWidth, y * _map.TileHeight, _map.TileWidth, _map.TileHeight);
                    if (!_selectedRectangles.Contains(tileRect))
                    {
                        _selectedRectangles.Add(tileRect);
                        added = true;
                    }
                }
            }

            return added;
        }

        private PointF Normalize(Point pointA, Point pointB)
        {
            var px = pointA.X - pointB.X;
            var py = pointA.Y - pointB.Y;
            var distance = Math.Sqrt(px * px + py * py);
            return new PointF((float)(px / distance), (float)(py / distance));
        }

        private double DistanceBetween(Point pointA, Point pointB)
        {
            var px = pointA.X - pointB.X;
            var py = pointA.Y - pointB.Y;
            return Math.Sqrt(px * px + py * py);
        }

        private Point GetTileCoordinateFromPoint(Point mousePoint)
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
