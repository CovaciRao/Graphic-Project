using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static GraphicProject.GraphicEngine;

namespace GraphicProject
{
    public class Triangle : Shape
    {
        public static int count = 0;
        private Point[] points;
        public Triangle(Colors color,FillOption fill ,int penSize) : base(color,fill, penSize)
        {
            count++;
            Name += count;
            //pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
        }
        public override void Translate(int x, int y)
        {
            Coordinates = new Point(x, y);
            pictureBox.Location = Coordinates;

        }

        public override void Rescale(int width, int height)
        {
            Width = width;
            Height = height;
            Draw();

        }
        public override void Draw()
        {
            base.Draw();
            points = new Point []{ new Point(Width / 2, 0), new Point(Width - penSize, Height - penSize), new Point(penSize, Height - penSize) };

            if (fill == FillOption.none)
                graphics.DrawPolygon(pen, points);
            else
                graphics.FillPolygon(new SolidBrush(pen.Color), points);
        }
    }
}
