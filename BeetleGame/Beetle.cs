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
        private Canvas _canvas;
        private Ellipse _ellipse;
        public Beetle(Canvas canvas, int StartX, int StartY, int size)
        {
            X = StartX;
            Y = StartY;
            Size = size;

            Right = true;
            Up = true;

            _canvas = canvas;
            _ellipse = new Ellipse();
            _ellipse.Height = size;
            _ellipse.Width = size;
            _ellipse.Fill = new SolidColorBrush(Colors.Brown);

            _ellipse.Margin = new Thickness((StartX - size / 2.0), (StartY - size / 2.0), 0, 0);
            _canvas.Children.Add(_ellipse);
        }

        public double Speed { get; set; }
        public int Size { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Right { get; set; }
        public bool Up { get; set; }
        public bool IsVisible { get; set; }

        public void ChangePosition()
        {
            if (Up)
            {
                Y--;
            } else
            {
                Y++;
            }

            if (Right)
            {
                X++;
            } else
            {
                X--;
            }

            DetectBorderCollision();
            _ellipse.Margin = new Thickness(X - (Size / 2.0), Y - (Size / 2.0), 0, 0);
        }

        private void DetectBorderCollision()
        {
            if ((Y - Size / 2) <= 0)
            {
                Up = false;
            } else if ((Y + Size / 2) >= _canvas.Height)
            {
                Up = true;
            }

            if ((X - Size / 2) <= 0)
            {
                Right = true;
            } else if ((X + Size / 2) >= _canvas.Width)
            {
                Right = false;
            }
        }
    }
}
