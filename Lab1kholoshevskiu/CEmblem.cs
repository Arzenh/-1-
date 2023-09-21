using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1kholoshevskiu
{
    internal class CEmblem
    {
        private Graphics graphics;
        private int _sideLength;

        public int X { get; set; }
        public int Y { get; set; }
        public int SideLength
        {
            get { return _sideLength; }
            set
            {
                _sideLength = value >= 200 ? 200 : (value <= 5 ? 5 : value);
            }
        }

        public CEmblem(Graphics graphics, int X, int Y, int v)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.SideLength = 50;
        }

        private void Draw(Pen pen)
        {

            Rectangle square = new Rectangle(X - SideLength / 2, Y - SideLength / 60, SideLength, SideLength);
            graphics.DrawRectangle(pen, square);

            Rectangle circle = new Rectangle(X - SideLength / 2, Y - SideLength / 1, SideLength, SideLength);
            graphics.DrawEllipse(pen, circle);

            int circleCenterX = X;
            int circleCenterY = Y;


            Point[] triangle = new Point[3];
            double kut = Math.PI / 6;
            for (int i = 0; i < 3; i++)
            {
                int triangleX = (int)(circleCenterX + SideLength / 2  * Math.Cos(kut + i * 2 * Math.PI / 3));
                int triangleY = (int)(circleCenterY + SideLength / -2 * Math.Sin(kut + i * 2 * Math.PI / 3));

                triangle[i] = new Point(triangleX, triangleY -SideLength /-1);
            }

            graphics.DrawPolygon(pen, triangle);
        }

        public void Show()
        {
            Draw(Pens.Red);
        }

        public void Hide()
        {
            Draw(Pens.White);
        }
        public void Expand()
        {
            Hide();
            SideLength++;
            Show();
        }

        public void Expand(int dSideLength)
        {
            Hide();
            SideLength += dSideLength;
            Show();
        }

        public void Collapse()
        {
            Hide();
            SideLength--;
            Show();
        }

        public void Collapse(int dSideLength)
        {
            Hide();
            SideLength -= dSideLength;
            Show();
        }

        public void Move(int dX, int dY)
        {
            Hide();
            X += dX;
            Y += dY;
            Show();
        }
    }
}

