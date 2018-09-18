using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GraphicProject.GraphicEngine;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicProject
{
    public class Square : Shape
    {
        public static int count = 0;
        public Square(Colors color,FillOption fill,int penSize) : base(color,fill, penSize)
        {
            count++;
            Name += count;
            Height = Width;
        }
        public override void Draw()
        {
            base.Draw();
            if (fill == FillOption.none)
                graphics.DrawRectangle(pen, penSize / 2, penSize / 2, Width, Height);
            else
                graphics.FillRectangle(new SolidBrush(pen.Color), penSize / 2, penSize / 2, Width, Height);
        }

        public override void Translate(int x, int y)
        {
            Coordinates = new Point(x, y);
            pictureBox.Location = Coordinates;

        }

        public override void Rescale(int width, int height)
        {
            Width = width;
            Height = Width;
            Draw();

        }

    }
}
