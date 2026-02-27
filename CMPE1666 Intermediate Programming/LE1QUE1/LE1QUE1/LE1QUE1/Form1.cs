using GDIDrawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LE1QUE1
{
    public partial class Form1 : Form
    {
        /*
         * STRUCT: SBall
         * Stores all information needed for one ball.
         * - Position : center point of the ball on the GDI canvas
         * - Radius   : size of the ball
         * - Dx, Dy   : movement speed/direction in X and Y
         * - Color    : fill color of the ball
         */
        private struct SBall
        {
            public Point Position;
            public int Radius;
            public int Dx;
            public int Dy;
            public Color Color;
        }

        // List to store all balls
        private List<SBall> _balls = new List<SBall>();

        // Random object for size, position, velocity, color
        private Random _rand = new Random();

        // GDI Drawer object
        private CDrawer _drawer;

        /*
         * Size loop control variables
         * _sizeLoopOn : true -> balls continuously change size
         * _sizeDir    : -1 shrink, +1 grow
         */
        private bool _sizeLoopOn = false;
        private int _sizeDir = -1;

        // Constants to control size limits and speed
        private const int MIN_R = 5;
        private const int MAX_R = 80;
        private const int STEP_R = 2;

        public Form1()
        {
            InitializeComponent();

            // Create the GDI drawing canvas
            _drawer = new CDrawer(600, 600, false);

            // Configure timer
            UI_Move_Tmr.Interval = 30;
            UI_Move_Tmr.Enabled = false;

            // Hook up button and timer events
            UI_AddBall_Btn.Click += UI_AddBall_Btn_Click;
            UI_Start_Btn.Click += UI_Start_Btn_Click;
            UI_Stop_Btn.Click += UI_Stop_Btn_Click;
            UI_Move_Tmr.Tick += UI_Move_Tmr_Tick;

            // Buttons to start/stop size changing loop
            UI_Smaller_Btn.Click += UI_Smaller_Btn_Click;
            UI_Bigger_Btn.Click += UI_Bigger_Btn_Click;
        }

        /*
         * Starts the continuous size change loop.
         * Balls will shrink first, then grow, repeatedly.
         */
        private void UI_Smaller_Btn_Click(object sender, EventArgs e)
        {
            _sizeLoopOn = true;
            _sizeDir = -1; // start shrinking
        }

        /*
         * Stops the continuous size change loop.
         * Balls keep their current size.
         */
        private void UI_Bigger_Btn_Click(object sender, EventArgs e)
        {
            _sizeLoopOn = false;
        }

        /*
         * Adds a new ball with random properties.
         */
        private void UI_AddBall_Btn_Click(object sender, EventArgs e)
        {
            // Create a new ball using struct initializer
            SBall b = new SBall
            {
                Radius = _rand.Next(10, 50),
                Dx = _rand.Next(-6, 7),
                Dy = _rand.Next(-6, 7),
                Color = RandColor.GetColor()
            };

            // Prevent zero movement
            if (b.Dx == 0) b.Dx = 3;
            if (b.Dy == 0) b.Dy = -3;

            // Random position inside canvas bounds
            b.Position = new Point(
                _rand.Next(b.Radius, _drawer.ScaledWidth - b.Radius),
                _rand.Next(b.Radius, _drawer.ScaledHeight - b.Radius)
            );

            // Add ball to list and listbox
            _balls.Add(b);
            UI_ListBox.Items.Add($"Ball {_balls.Count}  R={b.Radius}");

            Render();
        }

        // Starts movement (timer ON)
        private void UI_Start_Btn_Click(object sender, EventArgs e)
        {
            UI_Move_Tmr.Enabled = true;
        }

        // Stops movement (timer OFF)
        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            UI_Move_Tmr.Enabled = false;
        }

        /*
         * Timer Tick:
         * - Moves balls
         * - Handles bouncing
         * - Handles align mode
         * - Handles continuous size change
         */
        private void UI_Move_Tmr_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _balls.Count; i++)
            {
                SBall b = _balls[i];

                // ---------- RANDOM MOVEMENT MODE ----------
                if (UI_Rand_Rdo.Checked)
                {
                    b.Position.X += b.Dx;
                    b.Position.Y += b.Dy;

                    // Bounce left/right
                    if (b.Position.X <= b.Radius || b.Position.X >= _drawer.ScaledWidth - b.Radius)
                        b.Dx = -b.Dx;

                    // Bounce top/bottom
                    if (b.Position.Y <= b.Radius || b.Position.Y >= _drawer.ScaledHeight - b.Radius)
                        b.Dy = -b.Dy;
                }
                // ---------- ALIGN MODE ----------
                else if (UI_Align_Rdo.Checked)
                {
                    // Move ball toward left edge
                    if (b.Position.X > b.Radius)
                        b.Position.X -= 6;

                    if (b.Position.X < b.Radius)
                        b.Position.X = b.Radius;

                    // Still move vertically
                    b.Position.Y += b.Dy;

                    // Bounce vertically only
                    if (b.Position.Y <= b.Radius || b.Position.Y >= _drawer.ScaledHeight - b.Radius)
                        b.Dy = -b.Dy;
                }

                // ---------- SIZE LOOP ----------
                if (_sizeLoopOn)
                {
                    b.Radius += STEP_R * _sizeDir;

                    // Reverse direction at limits
                    if (b.Radius <= MIN_R)
                    {
                        b.Radius = MIN_R;
                        _sizeDir = 1;
                    }
                    else if (b.Radius >= MAX_R)
                    {
                        b.Radius = MAX_R;
                        _sizeDir = -1;
                    }

                    // Keep ball inside canvas after resizing
                    if (b.Position.X < b.Radius) b.Position.X = b.Radius;
                    if (b.Position.Y < b.Radius) b.Position.Y = b.Radius;
                    if (b.Position.X > _drawer.ScaledWidth - b.Radius)
                        b.Position.X = _drawer.ScaledWidth - b.Radius;
                    if (b.Position.Y > _drawer.ScaledHeight - b.Radius)
                        b.Position.Y = _drawer.ScaledHeight - b.Radius;
                }

                // Write back modified struct
                _balls[i] = b;
            }

            Render();
        }

        /*
         * Clears the canvas and redraws all balls.
         */
        private void Render()
        {
            _drawer.Clear();

            foreach (SBall b in _balls)
            {
                _drawer.AddCenteredEllipse(
                    b.Position.X,
                    b.Position.Y,
                    b.Radius * 2,
                    b.Radius * 2,
                    b.Color
                );
            }

            _drawer.Render();
        }
    }
}