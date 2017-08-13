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
    public partial class DesignerForm : DockContent
    {
        private DockPanel _dockPanel;
        private Project _project;

        public DesignerForm(Project project)
        {
            InitializeComponent();
            InitDocking();

            _project = project;
            Text = _project.ProjectName;

            TileRenderControl.InitMap(_project.Map);
            TileSetControl.InitMap(_project.Map);

            Invalidate();
        }

        private void InitDocking()
        {
            _dockPanel = new DockPanel();
            _dockPanel.Theme = new VS2015DarkTheme();
            _dockPanel.Dock = DockStyle.Fill;

            Controls.Add(_dockPanel);
        }

        //private void CreateTileRenderControl()
        //{
        //    var tileRenderControl = new TileRenderControl(_project.Map);
        //    tileRenderControl.Dock = DockStyle.Fill;
        //    MainSplitContainer.Panel1.Controls.Add(tileRenderControl);
        //}
    }
}
