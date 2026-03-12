using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BeetleGame
{
    public class Beetle
    {
        // Tip: to fix the first 3 tests of Beetle
        // 1. Add a constructor with 4 parameters (Canvas, int , int , int)
        // 2. Add PROPERTIES:
        //      double Speed
        //      int Size
        //      int Y
        //      bool Right
        //      bool Up 
        //      bool IsVisible

        private Ellipse _beetle;
        private Canvas _canvas;
        private int _x;
        private int _y;
        private int _size;
        
        public Beetle(Canvas canvas, int x, int y, int size)
        {
            _canvas = canvas;
            _x = x;
            _y = y;
            _size = size;

            Right = true;
            Up = true;

            _beetle = new Ellipse();
            _beetle.Width = _size;
            _beetle.Height = _size;
            _beetle.Fill = Brushes.Red;
            _beetle.Margin = new Thickness(_x - (_size / 2), _y - (_size / 2), 0, 0);

            _canvas.Children.Add(_beetle);
        }

        public double Speed { get; set; }
        public int Size 
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }
        public int X 
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y 
        { 
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public bool Right { get; set; }
        public bool Up { get; set; }
        public bool IsVisible { get; set; }

        public void ChangePosition()
        {
            if (Up)
            {
                _y--;
            } else
            {
                _y++;
            }

            if (Right)
            {
                _x++;
            } else
            {
                _x--;
            }
            _beetle.Margin = new Thickness(_x - (_size / 2), _y - (_size / 2), 0, 0);
        }


    }
}
