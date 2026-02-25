/* CMPE2300 - Object - Oriented Programming
 * Name: Dareen Kinga Njatou
 * ICA06 - Be Ordering My Balls...
 * Ball.s
 * Description: Defines the Ball class, which represents a ball with properties such as
                color, location, velocity, and radius. The class includes methods for 
                displaying the ball on a shared canvas, moving the ball within the canvas 
                while bouncing off walls, and comparing balls based on their radius and color.
                
 * Date: Friday 20, February 2026
 */
using GDIDrawer;
using System.Numerics;

namespace ICA06_DareenKN
{
    internal class Ball : IComparable
    {
        // Static fields
        private static Random _rand = new Random(); // Random number generator
        private static CDrawer _canvas;      // Shared canvas for all balls

        // Instance field 
        private Color _color;       // Color of the ball
        private Vector2 _location;  // Location of the ball
        private Vector2 _velocity;  // Velocity of the ball
        private int _iAlive = 255;  // Opacity of the ball

        private int _radius;        // Radius of the ball

        // Public property
        public int Radius
        {
            get => _radius;
            set
            {
                // Ensure radius is positive and fits within canvas
                value = (value == 0) ? 1 : Math.Abs(value);
                int max = Math.Min(_canvas.m_ciWidth, _canvas.m_ciHeight) / 2;
                _radius = Math.Min(value, max);
            }
        }

        /// <summary>
        /// Static manual property to control the location of the shared canvas. 
        /// This allows the form to set the position of the canvas on the screen 
        /// when the application starts.
        /// </summary>
        public static Point DrawerLocation { set => _canvas.Position = value; }   // Sets canvas location

        /// <summary>
        /// Static manual property to control the rendering of the canvas. 
        /// When set to true, it clears the canvas, and when set to false, 
        /// it renders the canvas.
        /// </summary>
        public static bool Loading { set { if (value) _canvas.Clear(); else _canvas.Render(); } } // Renders canvas


        // Static constructor to initialize the shared canvas and radius.
        static Ball()
        {
            // Initialize shared canvas with random dimensions
            _canvas = new CDrawer(_rand.Next(400, 701), _rand.Next(500, 801), false);
        }


        /// <summary>
        /// Instance constructor to initialize a Ball instance with random properties.
        /// </summary>
        public Ball(int radius)
        {
            Radius = radius;   
            _color = RandColor.GetKnownColor();

            _velocity = new Vector2(
                (float)_rand.NextDouble() * 20 - 10,
                (float)_rand.NextDouble() * 20 - 10);

            _location = new Vector2(
                _rand.Next(_radius, _canvas.m_ciWidth - _radius),
                _rand.Next(_radius, _canvas.m_ciHeight - _radius));
        }

        /// <summary>
        /// Displays the ball on the shared canvas.
        /// </summary>
        public void ShowBall()
        {
            // Draw the ball with current opacity
            _canvas.AddCenteredEllipse(
                (int)_location.X, (int)_location.Y,
                _radius * 2, _radius * 2,
                Color.FromArgb(_iAlive, _color));
        }

        /// <summary>
        /// Moves the ball within the canvas, bouncing off walls.
        /// </summary>
        public void MoveBall()
        {
            _iAlive--;  // Decrease opacity

            // Reset ball if it becomes fully transparent
            if (_iAlive < 1)
            {
                _iAlive = _rand.Next(50, 128);
                _location = new Vector2(
                    _rand.Next(_radius, _canvas.m_ciWidth - _radius),
                    _rand.Next(_radius, _canvas.m_ciHeight - _radius));
            }

            // Calculate next position
            Vector2 next = _location + _velocity;

            // Bounce off walls
            if (next.X - _radius < 0 || next.X + _radius > _canvas.m_ciWidth)
                _velocity.X *= -1;

            if (next.Y - _radius < 0 || next.Y + _radius > _canvas.m_ciHeight)
                _velocity.Y *= -1;

            // Update location
            _location += _velocity;
        }

        /// <summary>
        /// Compares two balls based on radius, then by color if radii are equal. 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object? obj)
        {
            if (!(obj is Ball arg))
                throw new ArgumentException($"Ball:CompareTo {nameof(obj)} - is invalid");

            int result = arg._radius.CompareTo(this._radius);

            if (result == 0)
                result = -CompareByColor(this, arg);

            return result;
        }

        /// <summary>
        /// Calculates the distance of the ball from the center of the canvas. This is used for
        /// sorting the balls based on their distance from the center when the user presses the 
        /// 'D' key. The distance is calculated using the Euclidean distance formula, which 
        /// takes into account the ball's current location and the center of the canvas.
        /// </summary>
        public double DistanceFromCenter
        {
            get
            {
                return Math.Sqrt(Math.Pow(_location.X - _canvas.m_ciWidth / 2.0, 2) +
                                 Math.Pow(_location.Y - _canvas.m_ciHeight / 2.0, 2));
            }
        }

        /// <summary>
        /// Static method to compare two balls based on their distance from the center of the canvas.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int CompareByDistance(Ball a, Ball b)
        {
            return b.DistanceFromCenter.CompareTo(a.DistanceFromCenter);
        }

        /// <summary>
        /// Static method to compare two balls based on their color. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int CompareByColor(Ball a, Ball b)
        {
            return b._color.ToArgb().CompareTo(a._color.ToArgb());
        }

        /// <summary>
        /// Checks if the current ball intersects with another ball. 
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private bool IntersectCheck(Ball b)
        {
            double dx = _location.X - b._location.X;
            double dy = _location.Y - b._location.Y;

            double distanceSquared = dx * dx + dy * dy;
            double radiusSum = _radius + b._radius;

            return distanceSquared <= radiusSum * radiusSum;
        }

        /// <summary>
        /// Overrides the Equals method to determine if two balls intersect. 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is Ball arg)
                return IntersectCheck(arg);

            return false;
        }

        /// <summary>
        /// Overrides the GetHashCode method to return a constant value. 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
