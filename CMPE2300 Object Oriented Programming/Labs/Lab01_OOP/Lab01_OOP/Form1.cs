using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GDIDrawer;

namespace Lab01_OOP
{
    public partial class Form1 : Form
    {
        private static readonly Random _rnd = new Random();

        private CDrawer _canvas;

        private List<Package> _packages = new List<Package>();
        private List<Package> _loadable = new List<Package>();
        private Queue<Package> _queue = new Queue<Package>();

        private int _numRequired = 20;
        private int iMaxTries = 10000;

        /******************************************************
         * METHOD: Form1 (Constructor)
         * PURPOSE:
         * - Setup form, events, and drawer
         * - Print instruction text to status
         ******************************************************/
        public Form1()
        {
            InitializeComponent();

            KeyPreview = true;
            AllowDrop = true;

            KeyDown += Form1_KeyDown;
            DragEnter += Form1_DragEnter;
            DragDrop += Form1_DragDrop;

            _canvas = new CDrawer(800, 800, false);
            _canvas.BBColour = Color.Black;
            _canvas.ContinuousUpdate = false;

            StatusAdd("Press C to clear the loadable packages");
            StatusAdd("Press G to fill the grid");
            StatusAdd("Press R to randomize spots");
            StatusAdd("Drag and drop a file here");
            StatusAdd($"Loaded {_loadable.Count} packages");
        }

        /******************************************************
         * METHOD: StatusAdd
         * PURPOSE:
         * - Add status text to bottom and autoscroll
         * - Force UI to update so messages appear during long work
         *******************************************************/
        private void StatusAdd(string msg)
        {
            UI_Lst_Status.Items.Add(msg);
            UI_Lst_Status.TopIndex = UI_Lst_Status.Items.Count - 1;

            UI_Lst_Status.Refresh();
            Application.DoEvents();
        }

        /******************************************************
         * METHOD: Form1_DragEnter
         * PURPOSE:
         * - Allow file drop if data is a file list
         ******************************************************/
        private void Form1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /******************************************************
         * METHOD: Form1_DragDrop
         * PURPOSE:
         * - Load exactly one file
         * - Reset packages, queue, loadable
         * - Show preview grid of ALL packages (no collision)
         ******************************************************/
        private void Form1_DragDrop(object? sender, DragEventArgs e)
        {
            try
            {
                if (e.Data == null)
                {
                    StatusAdd("Error: invalid drop data");
                    return;
                }

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length != 1)
                {
                    StatusAdd("Error: drop a single file only");
                    return;
                }

                LoadPackagesFromFile(files[0]);
            }
            catch (Exception ex)
            {
                StatusAdd($"Error:{ex.Message}");
            }
        }

        /******************************************************
         * METHOD: LoadPackagesFromFile
         * PURPOSE:
         * - Replace _packages with new file content
         * - Clear _loadable and rebuild _queue
         * - Show preview grid of all loaded packages
         * - Output: Load:<file>: Package N to M loaded
         ******************************************************/
        private void LoadPackagesFromFile(string path)
        {
            _packages.Clear();
            _loadable.Clear();
            _queue.Clear();

            _canvas.Clear();

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    Package p = new Package(line);
                    _packages.Add(p);
                }
                catch (Exception exLine)
                {
                    StatusAdd($"Error:{exLine.Message}");
                }
            }

            foreach (Package p in _packages)
                _queue.Enqueue(p);

            ShowPreviewGrid(_packages);

            string fileName = Path.GetFileName(path);

            if (_packages.Count == 0)
            {
                StatusAdd($"Load:{fileName}: Package 0 to 0 loaded");
                StatusAdd($"Loaded {_loadable.Count} packages");
                return;
            }

            int minID = int.MaxValue;
            int maxID = int.MinValue;

            foreach (Package p in _packages)
            {
                if (p.ID < minID) minID = p.ID;
                if (p.ID > maxID) maxID = p.ID;
            }

            StatusAdd($"Load:{fileName}: Package {minID} to {maxID} loaded");
            StatusAdd($"Loaded {_loadable.Count} packages");
        }

        /******************************************************
         * METHOD: ShowPreviewGrid
         * PURPOSE:
         * - Display ALL packages in a grid
         * - NO collision detection (per spec)
         ******************************************************/
        private void ShowPreviewGrid(List<Package> list)
        {
            _canvas.Clear();

            if (list.Count == 0)
            {
                _canvas.Render();
                return;
            }

            int count = list.Count;
            int cols = (int)Math.Ceiling(Math.Sqrt(count));
            int rows = (int)Math.Ceiling(count / (double)cols);

            int cellW = Math.Max(1, _canvas.ScaledWidth / cols);
            int cellH = Math.Max(1, _canvas.ScaledHeight / rows);

            int i = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (i >= count)
                        break;

                    int x = c * cellW + cellW / 2;
                    int y = r * cellH + cellH / 2;

                    list[i].Location = new Point(x, y);
                    list[i].Draw(_canvas);

                    i++;
                }
            }

            _canvas.Render();
        }

        /******************************************************
         * METHOD: RenderLoadable
         * PURPOSE:
         * - Clear canvas and draw all loadable packages
         ******************************************************/
        private void RenderLoadable()
        {
            _canvas.Clear();

            foreach (Package p in _loadable)
                p.Draw(_canvas);

            _canvas.Render();
        }

        /******************************************************
         * METHOD: DoClear
         * PURPOSE:
         * - Clear _loadable only
         * - Reload _queue from _packages
         * - Clear canvas
         ******************************************************/
        private void DoClear()
        {
            _loadable.Clear();
            _queue.Clear();

            foreach (Package p in _packages)
                _queue.Enqueue(p);

            _canvas.Clear();
            _canvas.Render();

            StatusAdd("Clear:Loadable cleared, Queue reloaded");
        }

        /******************************************************
 * METHOD: OverlapsOrContainsAnyLoadable
 * PURPOSE:
 * - Fast reject: Intersects first
 * - Only if no intersection, check containment
 ******************************************************/
        private bool OverlapsOrContainsAnyLoadable(Package candidate)
        {
            foreach (Package placed in _loadable)
            {
                if (candidate.Intersects(placed))
                    return true;
            }

            foreach (Package placed in _loadable)
            {
                if (candidate.ContainsPackage(placed))
                    return true;

                if (placed.ContainsPackage(candidate))
                    return true;
            }

            return false;
        }

        /******************************************************
         * METHOD: DoRandomLoad
         * PURPOSE:
         * - Try to place up to _numRequired packages from queue
         * - Each package gets up to iMaxTries attempts
         * - Stop pass if current package fails after iMaxTries
         * - Accumulates into _loadable (does not clear it)
         ******************************************************/
        private void DoRandomLoad()
        {
            string start = DateTime.Now.ToString("h:mm tt");
            StatusAdd($"Random Load Start: {start}");

            if (_queue.Count == 0)
            {
                StatusAdd("Queue empty, stopping load");
                StatusAdd($"Pass loaded 0/{_numRequired} packages");
                StatusAdd($"Random Load End: {DateTime.Now.ToString("h:mm tt")}");
                StatusAdd($"Loaded {_loadable.Count} packages");
                return;
            }

            int passLoaded = 0;

            for (int n = 0; n < _numRequired; n++)
            {
                if (_queue.Count == 0)
                {
                    StatusAdd("Queue empty, stopping load");
                    break;
                }

                Package p = _queue.Dequeue();
                bool placed = false;

                for (int t = 0; t < iMaxTries; t++)
                {
                    p.NewLocation(_canvas);

                    if (!p.InBounds(_canvas))
                        continue;

                    if (OverlapsOrContainsAnyLoadable(p))
                        continue;

                    _loadable.Add(p);
                    passLoaded++;
                    placed = true;
                    break;
                }

                if (!placed)
                {
                    StatusAdd($"Failed to load current package after {iMaxTries} tries");
                    break;
                }
            }

            StatusAdd($"Pass loaded {passLoaded}/{_numRequired} packages");
            StatusAdd($"Random Load End: {DateTime.Now.ToString("h:mm tt")}");
            StatusAdd($"Loaded {_loadable.Count} packages");

            RenderLoadable();
        }

        /******************************************************
         * METHOD: BuildGridPoints
         * PURPOSE:
         * - Create a 100x100 grid of points within the canvas
         ******************************************************/
        private List<Point> BuildGridPoints()
        {
            List<Point> pts = new List<Point>();

            int cols = 100;
            int rows = 100;

            int stepX = Math.Max(1, _canvas.ScaledWidth / cols);
            int stepY = Math.Max(1, _canvas.ScaledHeight / rows);

            for (int y = 0; y < _canvas.ScaledHeight; y += stepY)
            {
                for (int x = 0; x < _canvas.ScaledWidth; x += stepX)
                {
                    pts.Add(new Point(x, y));
                }
            }

            return pts;
        }

        /******************************************************
         * METHOD: DoGridLoad
         * PURPOSE:
         * - For each package in queue:
         *   try every grid point until it fits
         * - Stop when current package cannot be placed anywhere
         * - Accumulates into _loadable
         ******************************************************/
        private void DoGridLoad()
        {
            string start = DateTime.Now.ToString("h:mm tt");
            StatusAdd($"Grid Load Start: {start}");

            if (_queue.Count == 0)
            {
                StatusAdd("Queue empty, stopping load");
                StatusAdd("Pass loaded 0 packages");
                StatusAdd($"Grid Load End: {DateTime.Now.ToString("h:mm tt")}");
                StatusAdd($"Loaded {_loadable.Count} packages");
                return;
            }

            List<Point> grid = BuildGridPoints();
            int passLoaded = 0;

            while (_queue.Count > 0)
            {
                Package p = _queue.Peek();
                bool placed = false;

                for (int i = 0; i < grid.Count; i++)
                {
                    p.Location = grid[i];

                    if (!p.InBounds(_canvas))
                        continue;

                    if (OverlapsOrContainsAnyLoadable(p))
                        continue;

                    _queue.Dequeue();
                    _loadable.Add(p);
                    passLoaded++;
                    placed = true;
                    break;
                }

                if (!placed)
                {
                    // stop when current package exhausted grid spots
                    break;
                }
            }

            if (_queue.Count == 0)
                StatusAdd("Queue empty, stopping load");

            StatusAdd($"Pass loaded {passLoaded} packages");
            StatusAdd($"Grid Load End: {DateTime.Now.ToString("h:mm tt")}");
            StatusAdd($"Loaded {_loadable.Count} packages");

            RenderLoadable();
        }

        /******************************************************
         * METHOD: Form1_KeyDown
         * PURPOSE:
         * - C: Clear loadable and reset queue
         * - R: Random load pass
         * - G: Grid fill pass
         ******************************************************/
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C) DoClear();
            if (e.KeyCode == Keys.R) DoRandomLoad();
            if (e.KeyCode == Keys.G) {
                StatusAdd("Key: G");
                DoGridLoad(); }
        }
    }
}