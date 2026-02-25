using System;
using System.Collections.Generic;
using System.Drawing;
using GDIDrawer;

namespace Lab01_OOP
{
    public class Package
    {
        /******************************************************
         * FIELD: _rnd
         * PURPOSE: Random generator for NewLocation().
         ******************************************************/
        private static readonly Random _rnd = new Random();

        /******************************************************
         * FIELD: _lines
         * PURPOSE: Polygon vertices (relative to Location).
         ******************************************************/
        private List<Point> _lines = new List<Point>();

        /******************************************************
         * FIELD: _id
         * PURPOSE: Unique package ID.
         ******************************************************/
        private int _id;

        /******************************************************
         * PROPERTY: ID
         * PURPOSE: Read-only access to _id.
         ******************************************************/
        public int ID
        {
            get { return _id; }
        }

        /******************************************************
         * PROPERTY: _color
         * PURPOSE: Drawing color for this package.
         ******************************************************/
        public Color _color { get; set; }

        /******************************************************
         * PROPERTY: Location
         * PURPOSE: Center location of this package on canvas.
         ******************************************************/
        public Point Location { get; set; }

        /******************************************************
         * METHOD: Package (CTOR)
         * PURPOSE:
         * - Parse one CSV line into:
         *   ID, Color(hex AARRGGBB), x1,y1,x2,y2,...
         * - Handles trailing commas by ignoring empty tokens.
         ******************************************************/
        public Package(string packageString)
        {
            if (string.IsNullOrWhiteSpace(packageString))
                throw new FormatException("Not enough values to create a package.");

            // Split and keep only non-empty trimmed tokens
            string[] raw = packageString.Split(',');
            List<string> tokens = new List<string>();

            foreach (string s in raw)
            {
                string t = s.Trim();
                if (t.Length > 0)
                    tokens.Add(t);
            }

            if (tokens.Count < 8)
                throw new FormatException("Not enough values to create a package.");

            // ID
            if (!int.TryParse(tokens[0], out _id))
                throw new FormatException("Invalid package ID.");

            // Color token is hex like FF7EFF00
            int argb;
            try
            {
                argb = Convert.ToInt32(tokens[1], 16);
            }
            catch
            {
                throw new FormatException("Invalid color value.");
            }

            _color = Color.FromArgb(unchecked(argb));

            // Remaining tokens are x,y pairs
            int remain = tokens.Count - 2;
            if (remain % 2 != 0)
                throw new FormatException("Point list must be x,y pairs.");

            _lines.Clear();

            for (int i = 2; i < tokens.Count; i += 2)
            {
                if (!int.TryParse(tokens[i], out int x) ||
                    !int.TryParse(tokens[i + 1], out int y))
                    throw new FormatException("Invalid point value.");

                _lines.Add(new Point(x, y));
            }

            if (_lines.Count < 3)
                throw new FormatException("A package must have at least 3 points.");

            Location = new Point(0, 0);
        }

        /******************************************************
         * METHOD: Draw
         * PURPOSE:
         * - Draw polygon edges with AddLine()
         * - Draw ID centered at Location using inflated rect
         ******************************************************/
        public void Draw(CDrawer canvas)
        {
            if (_lines.Count < 2)
                return;

            for (int i = 0; i < _lines.Count; i++)
            {
                Point aRel = _lines[i];
                Point bRel = _lines[(i + 1) % _lines.Count];

                Point a = new Point(Location.X + aRel.X, Location.Y + aRel.Y);
                Point b = new Point(Location.X + bRel.X, Location.Y + bRel.Y);

                canvas.AddLine(a.X, a.Y, b.X, b.Y, _color, 2);
            }

            Rectangle r = new Rectangle(Location, new Size(1, 1));
            r.Inflate(30, 30);
            canvas.AddText(_id.ToString(), 14, r, Color.White);
        }

        /******************************************************
         * METHOD: InBounds
         * PURPOSE:
         * - Returns true if ALL vertices are inside the canvas.
         ******************************************************/
        public bool InBounds(CDrawer canvas)
        {
            for (int i = 0; i < _lines.Count; i++)
            {
                int x = Location.X + _lines[i].X;
                int y = Location.Y + _lines[i].Y;

                if (x < 0 || y < 0 || x >= canvas.ScaledWidth || y >= canvas.ScaledHeight)
                    return false;
            }

            return true;
        }

        /******************************************************
         * METHOD: NewLocation
         * PURPOSE:
         * - Randomly choose a new Location that is InBounds()
         ******************************************************/
        public void NewLocation(CDrawer canvas)
        {
            // Keep trying until in bounds (caller controls outer max tries)
            while (true)
            {
                int x = _rnd.Next(0, canvas.ScaledWidth);
                int y = _rnd.Next(0, canvas.ScaledHeight);

                Location = new Point(x, y);

                if (InBounds(canvas))
                    return;
            }
        }

        /******************************************************
         * METHOD: Intersects
         * PURPOSE:
         * - Returns true if any edge of this polygon intersects
         *   any edge of the other polygon.
         ******************************************************/
        public bool Intersects(Package other)
        {
            List<(Point A, Point B)> edgesA = GetEdgesAbsolute();
            List<(Point A, Point B)> edgesB = other.GetEdgesAbsolute();

            for (int i = 0; i < edgesA.Count; i++)
            {
                for (int j = 0; j < edgesB.Count; j++)
                {
                    if (LineIntersects(edgesA[i].A, edgesA[i].B, edgesB[j].A, edgesB[j].B))
                        return true;
                }
            }

            return false;
        }

        /******************************************************
         * METHOD: ContainsPackage
         * PURPOSE (per spec):
         * - Create radial lines from center to each vertex of THIS
         * - If ANY edge of OTHER intersects ANY radial line,
         *   then OTHER must be inside THIS -> return true
         ******************************************************/
        public bool ContainsPackage(Package other)
        {
            List<(Point A, Point B)> otherEdges = other.GetEdgesAbsolute();

            // Radials from THIS center to each THIS vertex (absolute)
            for (int i = 0; i < _lines.Count; i++)
            {
                Point vertex = new Point(Location.X + _lines[i].X, Location.Y + _lines[i].Y);
                Point center = Location;

                for (int e = 0; e < otherEdges.Count; e++)
                {
                    if (LineIntersects(center, vertex, otherEdges[e].A, otherEdges[e].B))
                        return true;
                }
            }

            return false;
        }

        /******************************************************
         * METHOD: Equals (override)
         * PURPOSE:
         * - Two packages considered equal if they overlap OR contain
         *   each other in any way (for lab placement logic).
         ******************************************************/
        public override bool Equals(object? obj)
        {
            Package? other = obj as Package;
            if (other == null)
                return false;

            // Overlap or containment in either direction
            if (Intersects(other))
                return true;

            if (ContainsPackage(other))
                return true;

            if (other.ContainsPackage(this))
                return true;

            return false;
        }

        /******************************************************
         * METHOD: GetHashCode (override)
         * PURPOSE:
         * - Hash based on ID (stable identifier).
         ******************************************************/
        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        /******************************************************
         * METHOD: GetEdgesAbsolute (helper)
         * PURPOSE:
         * - Convert polygon into list of absolute line segments.
         ******************************************************/
        private List<(Point A, Point B)> GetEdgesAbsolute()
        {
            List<(Point A, Point B)> edges = new List<(Point A, Point B)>();

            for (int i = 0; i < _lines.Count; i++)
            {
                Point aRel = _lines[i];
                Point bRel = _lines[(i + 1) % _lines.Count];

                Point a = new Point(Location.X + aRel.X, Location.Y + aRel.Y);
                Point b = new Point(Location.X + bRel.X, Location.Y + bRel.Y);

                edges.Add((a, b));
            }

            return edges;
        }

        /******************************************************
         * METHOD: LineIntersects (static helper)
         * PURPOSE:
         * - Return true if line segments AB and CD intersect.
         * CITATION (per spec requirement):
         * - Based on standard orientation / segment intersection logic
         *   commonly taught in computational geometry.
         ******************************************************/
        public static bool LineIntersects(Point a, Point b, Point c, Point d)
        {
            int o1 = Orientation(a, b, c);
            int o2 = Orientation(a, b, d);
            int o3 = Orientation(c, d, a);
            int o4 = Orientation(c, d, b);

            // General case
            if (o1 != o2 && o3 != o4)
                return true;

            // Special cases (collinear)
            if (o1 == 0 && OnSegment(a, c, b)) return true;
            if (o2 == 0 && OnSegment(a, d, b)) return true;
            if (o3 == 0 && OnSegment(c, a, d)) return true;
            if (o4 == 0 && OnSegment(c, b, d)) return true;

            return false;
        }

        /******************************************************
         * METHOD: Orientation (helper)
         * PURPOSE:
         * - Returns:
         *   0 = collinear
         *   1 = clockwise
         *   2 = counterclockwise
         ******************************************************/
        private static int Orientation(Point p, Point q, Point r)
        {
            long val = (long)(q.Y - p.Y) * (r.X - q.X) -
                       (long)(q.X - p.X) * (r.Y - q.Y);

            if (val == 0) return 0;
            return (val > 0) ? 1 : 2;
        }

        /******************************************************
         * METHOD: OnSegment (helper)
         * PURPOSE:
         * - Check if q lies on segment pr (collinear case)
         ******************************************************/
        private static bool OnSegment(Point p, Point q, Point r)
        {
            return q.X >= Math.Min(p.X, r.X) && q.X <= Math.Max(p.X, r.X) &&
                   q.Y >= Math.Min(p.Y, r.Y) && q.Y <= Math.Max(p.Y, r.Y);
        }
    }
}