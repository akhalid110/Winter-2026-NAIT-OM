using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace LE_1_pracitce_1
{
    // Enum with required integer values (diameters)
    public enum eSize
    {
        Small = 25,
        Medium = 50,
        Large = 100
    }

    // Struct holding circle data
    public struct SCircle
    {
        public eSize Diameter;
        public Point Position;
        public Color FillColor;
    }

    public partial class Form1 : Form
    {
        // Member variables required
        private List<SCircle> _circles = new List<SCircle>();
        private eSize _currentSize;
        private CDrawer _drawer;
        private Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // Create the drawer object (required)
            _drawer = new CDrawer(800, 600, false);

            // Default selection to Small (required)
            UI_Small_Rdo.Checked = true;
            _currentSize = eSize.Small;

            // Timer setup
            UI_Timer.Interval = 30;
            UI_Timer.Enabled = true;

            // Consolidated radio handler (required)
            UI_Small_Rdo.CheckedChanged += SizeRadio_CheckedChanged;
            UI_Medium_Rdo.CheckedChanged += SizeRadio_CheckedChanged;
            UI_Large_Rdo.CheckedChanged += SizeRadio_CheckedChanged;

            // Button handlers
            UI_RandColor_Btn.Click += UI_RandColor_Btn_Click;
            UI_RedColor_Btn.Click += UI_RedColor_Btn_Click;

            // Timer tick handler (required)
            UI_Timer.Tick += UI_Timer_Tick;
        }

        // Consolidated handler for radio buttons
        private void SizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Small_Rdo.Checked) _currentSize = eSize.Small;
            else if (UI_Medium_Rdo.Checked) _currentSize = eSize.Medium;
            else if (UI_Large_Rdo.Checked) _currentSize = eSize.Large;
        }

        // Timer tick: poll left clicks and add circles
        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            if (_drawer.GetLastMouseLeftClick(out Point p))
            {
                SCircle c;
                c.Diameter = _currentSize;
                c.Position = p;
                c.FillColor = Color.Red;

                _circles.Add(c);

                // Draw immediately (or just call Render)
                _drawer.AddCenteredEllipse(c.Position.X, c.Position.Y, (int)c.Diameter, (int)c.Diameter, c.FillColor);
                _drawer.Render();
            }
        }

        // Change to RANDOM color for circles of the selected size
        private void UI_RandColor_Btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _circles.Count; i++)
            {
                SCircle c = _circles[i];

                if (c.Diameter == _currentSize)
                {
                    c.FillColor = Color.FromArgb(_rand.Next(256), _rand.Next(256), _rand.Next(256));
                    _circles[i] = c; // write-back (struct fix)
                }
            }

            Render();
        }

        // Change to RED color for circles of the selected size
        private void UI_RedColor_Btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _circles.Count; i++)
            {
                SCircle c = _circles[i];

                if (c.Diameter == _currentSize)
                {
                    c.FillColor = Color.Red;
                    _circles[i] = c; // write-back (struct fix)
                }
            }

            Render();
        }

        // Helper method: clears and redraws all circles
        private void Render()
        {
            _drawer.Clear();

            foreach (SCircle c in _circles)
            {
                _drawer.AddCenteredEllipse(
                    c.Position.X,
                    c.Position.Y,
                    (int)c.Diameter,
                    (int)c.Diameter,
                    c.FillColor
                );
            }

            _drawer.Render();
        }
    }
}
