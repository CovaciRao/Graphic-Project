using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicProject
{
    public static class GraphicEngine
    {
        public static Graphics graphicMap;
        public static Bitmap map;
        public enum Colors { red,blue,green,yellow}
        public enum Option { elipse, circle, rectangle, square ,triangle,line}
        public enum FillOption { none,fill}
        public static Pen pen;
        public static List<Shape> shapes = new List<Shape>();
        public static ListBox shapeList;
        public static Panel pb;

        public static void SetPenColor(Colors color,int penSize=1)
        {
            switch (color) {
                case Colors.yellow:
                    pen = new Pen(new SolidBrush(Color.Yellow),penSize);
                    break;
                case Colors.red:
                    pen = new Pen(new SolidBrush(Color.Red),penSize);
                    break;

                case Colors.blue:
                    pen = new Pen(new SolidBrush(Color.Blue),penSize);
                    break;

                case Colors.green:
                    pen = new Pen(new SolidBrush(Color.Green),penSize);
                    break;
                default:
                    pen = new Pen(new SolidBrush(Color.Black),penSize);
                    break;
            }
            
            
        }
        public static void Init(Size size)
        {   
            map = new Bitmap(size.Width,size.Height);
            graphicMap = Graphics.FromImage(map);
        }
    }
}
