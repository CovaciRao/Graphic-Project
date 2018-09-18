using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static GraphicProject.GraphicEngine;
using System.Windows.Forms;

namespace GraphicProject
{
    public abstract class Shape
    {
       
        public string Name { get; protected set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Coordinates { get; set; }
        protected Colors color;
        protected int penSize;
        protected FillOption fill;
        public static int shapeCounter = 0;
        protected PictureBox pictureBox;
        protected Graphics graphics;
        protected Bitmap map;

        public virtual void Draw()
        {
            SetPenColor(color, penSize);
            pictureBox.Size = new Size(Width + penSize, Height + penSize);
            pictureBox.Location = Coordinates;
            map = new Bitmap(pictureBox.Width + penSize, pictureBox.Height + penSize);
            graphics = Graphics.FromImage(map);
            pictureBox.BackgroundImage = null;
            pictureBox.BackgroundImage = map;
        }
        public abstract void Translate(int x, int y);
        public abstract void Rescale(int width,int height);
        public virtual void RotateX()
        {
            map.RotateFlip(RotateFlipType.Rotate90FlipX);
            Rescale(Height, Width);
            pictureBox.BackgroundImage = map;
        }
        public virtual void RotateY()
        {
            map.RotateFlip(RotateFlipType.Rotate90FlipY);
            Rescale(Height, Width);
            pictureBox.BackgroundImage = map;
        }
        public Shape(Colors color,FillOption fill,int penSize)
        {
            shapeCounter++;
            Name = GetType().Name;
            this.color = color;
            this.penSize = penSize;
            this.fill = fill;
            pictureBox = new PictureBox();
            pictureBox.Parent = pb;
        } 
      
    }
}
