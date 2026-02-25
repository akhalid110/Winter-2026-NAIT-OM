/* CMPE2300 - Object - Oriented Programming
 * Name: Dareen Kinga Njatou
 * ICA06 - Be Ordering My Balls..
 * 
 * Description: The form allows users to add balls to a shared canvas, sort them based on 
                different criteria (size, distance from the center, and color), and delete 
                balls. The form also handles user input through button clicks and key presses, 
                and manages the rendering of the balls on the canvas.
 * 
 * Date: Wednesday 18, February 2026
 */

using System.Drawing;

namespace ICA06_DareenKN
{
    public partial class Form1 : Form
    {
        List<Ball> _balls = new List<Ball>();
        int radius = 10;

        public Form1()
        {
            InitializeComponent();

            // Enable key events to be captured by the form
            KeyPreview = true;

            UI_AddBalls_Btn.Text = $"Add Balls ({radius})";

            // Event handlers
            UI_AddBalls_Btn.Click += UI_AddBalls_Btn_Click;
            UI_AddBalls_Btn.MouseWheel += UI_AddBalls_Btn_MouseWheel;
            KeyDown += Form1_KeyDown;
            Shown += Form1_Shown;

        }

        /// <summary>
        /// Handles the MouseWheel event for the "Add Balls" button. It adjusts the 
        /// radius of the balls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_AddBalls_Btn_MouseWheel(object? sender, MouseEventArgs e)
        {
            radius += (e.Delta < 0) ? -1 : 1;
            UI_AddBalls_Btn.Text = $"Add Balls ({radius})";

        }

        /// <summary>
        /// Handles the click event for the "Add Balls" button. It attempts to add 
        /// a specified number of new Balls to the list, ensuring that they do not 
        /// intersect with existing Balls. The method also keeps track of how many 
        /// Balls were added and discarded, and updates the form's title with this 
        /// information. Finally, it renders all the Balls on the canvas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_AddBalls_Btn_Click(object? sender, EventArgs e)
        {

            int added = 0;
            int discarded = 0;

            Ball.Loading = true;

            // Attempt to add 25 new Balls, discarding any that intersect with existing Balls
            while (added < 25 && discarded < 1000)
            {
                Ball newBall = new Ball(radius);

                if (!_balls.Contains(newBall))
                {
                    _balls.Add(newBall);
                    added++;
                }
                else
                    discarded++;
            }

            // Inform user
            Text = $"Added: {added}  Discarded: {discarded}  Total: {_balls.Count}";

            // Render
            foreach (Ball b in _balls)
                b.ShowBall();

            Ball.Loading = false;
        }

        /// <summary>
        /// Handles key down events for the form. It allows the user to delete Balls, 
        /// change sorting types, and sort Balls based on the current sorting type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            // Binding keys to sorting types
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    if (_balls.Count > 0)
                        _balls.RemoveRange(0, _balls.Count / 2);
                    break;

                // Sorting based on the current sorting type
                case Keys.S: _balls.Sort(); break;                      // Default sorting by size
                case Keys.D: _balls.Sort(Ball.CompareByDistance); break;// Sorting by distance from the drawer's center
                case Keys.C: _balls.Sort(Ball.CompareByColor); break;   // Sorting by color (using the ARGB value of the color)
            }

            // Slow-mo
            Ball.Loading = true;

            // Render sorted Balls
            foreach (Ball b in _balls)
            {
                b.ShowBall();
                Ball.Loading = false;
                Thread.Sleep(10);
            }

            //Ball.Loading = false;
        }

        /// <summary>
        /// Handles the Shown event for the form. It sets the location of the Ball 
        /// drawer and activates the form to ensure it receives user input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object? sender, EventArgs e)
        {
            Ball.DrawerLocation = new Point(Top, Top + 150);
            Activate();
        }
    }
}
