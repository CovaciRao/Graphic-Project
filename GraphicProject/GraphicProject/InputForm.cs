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
    public partial class InputForm : Form
    {
        private Option option;
        private int x, y, width, height, size;
        public InputForm(Option option)
        {
            this.option = option;
            InitializeComponent();
            GetComboBoxItems();
            CheckSize();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValues();
            switch(option)
            {
                case Option.elipse:
                    shapes.Add(new Elipse ((Colors)comboBox1.SelectedIndex, (FillOption)comboBox2.SelectedIndex, size) {Width = width, Height = height, Coordinates = new Point(x, y)});
                    shapes[Shape.shapeCounter-1].Draw();
                    shapeList.Items.Add(shapes.Last().Name);
                    shapeList.Refresh();
                    break;

                case Option.circle:
                    shapes.Add(new Circle((Colors)comboBox1.SelectedIndex, (FillOption)comboBox2.SelectedIndex, size) { Width = width, Height = height, Coordinates = new Point(x, y) });
                    shapes[Shape.shapeCounter - 1].Draw();
                    shapeList.Items.Add(shapes.Last().Name);
                    shapeList.Refresh();
                    break;

                case Option.rectangle:
                    shapes.Add(new Rectangle((Colors)comboBox1.SelectedIndex, (FillOption)comboBox2.SelectedIndex, size) { Width = width, Height = height, Coordinates = new Point(x, y) });
                    shapes[Shape.shapeCounter - 1].Draw();
                    shapeList.Items.Add(shapes.Last().Name);
                    shapeList.Refresh();
                    break;

                case Option.square:
                    shapes.Add(new Square((Colors)comboBox1.SelectedIndex, (FillOption)comboBox2.SelectedIndex, size) { Width = width, Height = height, Coordinates = new Point(x, y) });
                    shapes[Shape.shapeCounter - 1].Draw();
                    shapeList.Items.Add(shapes.Last().Name);
                    shapeList.Refresh();
                    break;
                case Option.triangle:
                    shapes.Add(new Triangle((Colors)comboBox1.SelectedIndex,(FillOption)comboBox2.SelectedIndex, size) { Width = width, Height = height, Coordinates = new Point(x, y) });
                    shapes[Shape.shapeCounter - 1].Draw();
                    shapeList.Items.Add(shapes.Last().Name);
                    shapeList.Refresh();
                    break;
                case Option.line:
                    shapes.Add(new Line((Colors)comboBox1.SelectedIndex, (FillOption)comboBox2.SelectedIndex, size) { Width = width, Height = height, Coordinates = new Point(x, y) });
                    shapes[Shape.shapeCounter - 1].Draw();
                    shapeList.Items.Add(shapes.Last().Name);
                    shapeList.Refresh();
                    break;
            }

            this.Close();
        }
        private void GetComboBoxItems()
        {
           comboBox1.DataSource =Enum.GetNames(typeof(Colors));
           comboBox2.DataSource = Enum.GetNames(typeof(FillOption));
        }
        private void SetValues()
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            width = int.Parse(textBox3.Text);
            size = int.Parse(textBox5.Text);
            if(option!=Option.circle&&option!=Option.square)
                height = int.Parse(textBox4.Text);
        }
        private void CheckSize()
        {
            if (option == Option.circle || option == Option.square)
            {
                textBox4.Enabled = false;
                WidthOrSize.Text = "Size:";
            }
            else
            {
                textBox4.Enabled = true;
                WidthOrSize.Text = "Width:";
            }
        }
    }
}
