using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GraphicProject.GraphicEngine;
namespace GraphicProject
{
    public partial class Form1 : Form
    {
        InputForm inputForm;
        public Form1()
        {
            InitializeComponent();
            Init(new Size(form.Width,form.Height));
            form.BackgroundImage = map;
            shapeList = listBox1;
            pb = canvas;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            //DrawTriangle(Colors.red, 3, new Point(canvas.Width+150, canvas.Height-350), new Point(canvas.Width / 3, canvas.Height / 3), new Point(canvas.Width / 4, canvas.Height / 4));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void createElipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm(Option.elipse);
            inputForm.ShowDialog();
            HeightTxt.Enabled = true;
            form.Refresh();
        }

        private void createCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            inputForm = new InputForm(Option.circle);
            inputForm.ShowDialog();
            HeightTxt.Enabled = false;
            form.Refresh();
        }

        private void createRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm(Option.rectangle);
            inputForm.ShowDialog();
            HeightTxt.Enabled = true;
            form.Refresh();
        }

        private void createSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm(Option.square);
            inputForm.ShowDialog();
            HeightTxt.Enabled = false;
            form.Refresh();
        }

        private void createLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm(Option.line);
            inputForm.ShowDialog();
            HeightTxt.Enabled = true;
            form.Refresh();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeList.SelectedIndex > -1)
            {
                xtext.Text = shapes[listBox1.SelectedIndex].Coordinates.X.ToString();
                ytext.Text = shapes[listBox1.SelectedIndex].Coordinates.Y.ToString();
                WidthTxt.Text = shapes[listBox1.SelectedIndex].Width.ToString();
                HeightTxt.Text = shapes[listBox1.SelectedIndex].Height.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (shapeList.SelectedIndex>-1)
            shapes[shapeList.SelectedIndex].Translate(int.Parse(xtext.Text),int.Parse(ytext.Text));
            this.ResumeLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (shapeList.SelectedIndex>-1)
            shapes[shapeList.SelectedIndex].Rescale(int.Parse(WidthTxt.Text), int.Parse(HeightTxt.Text));
            this.ResumeLayout();

        }

        private void rotatex_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedIndex > -1)
                shapes[shapeList.SelectedIndex].RotateX();
        }

        private void rotatey_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedIndex > -1)
                shapes[shapeList.SelectedIndex].RotateY();
        }

        private void createTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm(Option.triangle);
            inputForm.ShowDialog();
            HeightTxt.Enabled = true;
            form.Refresh();
        }
    }

}
