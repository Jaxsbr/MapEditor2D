using MapEditor2D.Map2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MapEditor2D
{
    public partial class MainForm : Form
    {
        private DockPanel _dockPanel;
        private List<Project> _projects = new List<Project>();


        public MainForm()
        {
            InitializeComponent();
            InitDocking();            
        }

        private void InitDocking()
        {
            _dockPanel = new DockPanel();
            _dockPanel.Theme = new VS2015DarkTheme();

            var mdiClientControl = GetMdiClientControl();            
            if (mdiClientControl != null)
            {                
                _dockPanel.Bounds = new Rectangle(
                        mdiClientControl.ClientRectangle.X,
                        mdiClientControl.ClientRectangle.Y + MenuStrip.Height,
                        mdiClientControl.ClientRectangle.Width,
                        mdiClientControl.ClientRectangle.Height - MenuStrip.Height);
                _dockPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
            else
            {
                _dockPanel.Dock = DockStyle.Fill;
            }            
            
            Controls.Add(_dockPanel);
        }

        private Control GetMdiClientControl()
        {
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    return control;
                }
            }
            return null;
        }


        private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO:
            // Launch dialog and prompt for required input

            var project = new Project()
            {
                ProjectName = "TestProj",
                ProjectFilePath = @"C:\Users\Jacobus\Desktop",
                Map = new Map()
                {
                    Columns = 10,
                    Rows = 10,
                    TileWidth = 32,
                    TileHeight = 32,
                    TileSet = new TileSet()
                    {
                        ImagePath = @"C:\Users\Jacobus\Pictures\terrain_atlas.png"
                    },
                    MapLayers = new List<MapLayer>()
                    {
                        new MapLayer()
                        {
                            Data = new List<List<int>>()
                            {
                                new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                new List<int>() { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                                new List<int>() { 1, 0, 1, 0, 0, 1, 0, 0, 0, 0}
                            },
                            Index = 1,                            
                            Visible = true
                        }
                    }
                }
            };

            var designer = new DesignerForm(project);
            designer.Show(_dockPanel, DockState.Document);
        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
