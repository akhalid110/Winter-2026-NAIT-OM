using GDIDrawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LE1QUE1
{
    public partial class Form1 : Form
    {
        private struct SBall
        {
            public Point Center;
            public int Radius;
            public int Dx;
            public int Dy;
            public Color C;
        }

        private List<SBall> _balls = new List<SBall>();
        private Random _rand = new Random();
        private CDrawer _drawer;

        public Form1()
        {
            InitializeComponent();

            _drawer = new CDrawer(600, 600, false);

            UI_Move_Tmr.Interval = 30;
            UI_Move_Tmr.Enabled = false;

            UI_AddBall_Btn.Click += UI_AddBall_Btn_Click;
            UI_Start_Btn.Click += UI_Start_Btn_Click;
            UI_Stop_Btn.Click += UI_Stop_Btn_Click;
            UI_Move_Tmr.Tick += UI_Move_Tmr_Tick;
        }

        private void UI_AddBall_Btn_Click(object sender, EventArgs e)
        {
            SBall b;

            b.Radius = _rand.Next(10, 50);

            b.Center = new Point(
                _rand.Next(b.Radius, _drawer.ScaledWidth - b.Radius),
                _rand.Next(b.Radius, _drawer.ScaledHeight - b.Radius)
            );

            // random velocity (avoid 0,0)
            b.Dx = _rand.Next(-6, 7);
            b.Dy = _rand.Next(-6, 7);
            if (b.Dx == 0) b.Dx = 3;
            if (b.Dy == 0) b.Dy = -3;

            // random color
            b.C = Color.FromArgb(_rand.Next(256), _rand.Next(256), _rand.Next(256));

            _balls.Add(b);
            UI_ListBox.Items.Add($"Ball {_balls.Count}  R={b.Radius}");

            DrawBalls();
        }

        private void UI_Start_Btn_Click(object sender, EventArgs e)
        {
            UI_Move_Tmr.Enabled = true;
        }

        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            UI_Move_Tmr.Enabled = false;
        }

        private void UI_Move_Tmr_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _balls.Count; i++)
            {
                SBall b = _balls[i];

                if (UI_Rand_Rdo.Checked)
                {
                    // Move in any direction, bounce all edges
                    b.Center.X += b.Dx;
                    b.Center.Y += b.Dy;

                    // left/right bounce
                    if (b.Center.X <= b.Radius)
                    {
                        b.Center.X = b.Radius;
                        b.Dx = -b.Dx;
                    }
                    else if (b.Center.X >= _drawer.ScaledWidth - b.Radius)
                    {
                        b.Center.X = _drawer.ScaledWidth - b.Radius;
                        b.Dx = -b.Dx;
                    }

                    // top/bottom bounce
                    if (b.Center.Y <= b.Radius)
                    {
                        b.Center.Y = b.Radius;
                        b.Dy = -b.Dy;
                    }
                    else if (b.Center.Y >= _drawer.ScaledHeight - b.Radius)
                    {
                        b.Center.Y = _drawer.ScaledHeight - b.Radius;
                        b.Dy = -b.Dy;
                    }
                }
                else if (UI_Align_Rdo.Checked)
                {
                    // Bring all balls to the left
                    if (b.Center.X > b.Radius)
                        b.Center.X -= 6;

                    // Once at left edge, lock X at the left edge
                    if (b.Center.X < b.Radius)
                        b.Center.X = b.Radius;

                    // Still move up/down on the left side
                    b.Center.Y += b.Dy;

                    // bounce only top/bottom
                    if (b.Center.Y <= b.Radius)
                    {
                        b.Center.Y = b.Radius;
                        b.Dy = -b.Dy;
                    }
                    else if (b.Center.Y >= _drawer.ScaledHeight - b.Radius)
                    {
                        b.Center.Y = _drawer.ScaledHeight - b.Radius;
                        b.Dy = -b.Dy;
                    }
                }

                _balls[i] = b;
            }

            DrawBalls();
        }

        private void DrawBalls()
        {
            _drawer.Clear();

            foreach (SBall b in _balls)
            {
                _drawer.AddCenteredEllipse(
                    b.Center.X,
                    b.Center.Y,
                    b.Radius * 2,
                    b.Radius * 2,
                    b.C
                );
            }

            _drawer.Render();
        }
    }
}
