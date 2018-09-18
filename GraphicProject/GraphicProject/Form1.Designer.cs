namespace GraphicProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.form = new System.Windows.Forms.Panel();
            this.rotatey = new System.Windows.Forms.Button();
            this.rotatex = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightTxt = new System.Windows.Forms.TextBox();
            this.WidthTxt = new System.Windows.Forms.TextBox();
            this.ytext = new System.Windows.Forms.TextBox();
            this.xtext = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createElipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form
            // 
            this.form.AutoSize = true;
            this.form.Controls.Add(this.rotatey);
            this.form.Controls.Add(this.rotatex);
            this.form.Controls.Add(this.canvas);
            this.form.Controls.Add(this.label6);
            this.form.Controls.Add(this.button2);
            this.form.Controls.Add(this.label5);
            this.form.Controls.Add(this.button1);
            this.form.Controls.Add(this.label4);
            this.form.Controls.Add(this.label3);
            this.form.Controls.Add(this.label2);
            this.form.Controls.Add(this.label1);
            this.form.Controls.Add(this.HeightTxt);
            this.form.Controls.Add(this.WidthTxt);
            this.form.Controls.Add(this.ytext);
            this.form.Controls.Add(this.xtext);
            this.form.Controls.Add(this.listBox1);
            this.form.Controls.Add(this.menuStrip1);
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Location = new System.Drawing.Point(0, 0);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(830, 613);
            this.form.TabIndex = 0;
            this.form.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // rotatey
            // 
            this.rotatey.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rotatey.ForeColor = System.Drawing.Color.Cornsilk;
            this.rotatey.Location = new System.Drawing.Point(725, 537);
            this.rotatey.Name = "rotatey";
            this.rotatey.Size = new System.Drawing.Size(75, 23);
            this.rotatey.TabIndex = 17;
            this.rotatey.Text = "RotateY90";
            this.rotatey.UseVisualStyleBackColor = false;
            this.rotatey.Click += new System.EventHandler(this.rotatey_Click);
            // 
            // rotatex
            // 
            this.rotatex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rotatex.ForeColor = System.Drawing.Color.Cornsilk;
            this.rotatex.Location = new System.Drawing.Point(647, 537);
            this.rotatex.Name = "rotatex";
            this.rotatex.Size = new System.Drawing.Size(72, 23);
            this.rotatex.TabIndex = 16;
            this.rotatex.Text = "RotateX90";
            this.rotatex.UseVisualStyleBackColor = false;
            this.rotatex.Click += new System.EventHandler(this.rotatex_Click);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 27);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(585, 494);
            this.canvas.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Scale Options";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(647, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Rescale";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Translate Options";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(647, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X:";
            // 
            // HeightTxt
            // 
            this.HeightTxt.Location = new System.Drawing.Point(750, 457);
            this.HeightTxt.Name = "HeightTxt";
            this.HeightTxt.Size = new System.Drawing.Size(50, 20);
            this.HeightTxt.TabIndex = 6;
            // 
            // WidthTxt
            // 
            this.WidthTxt.Location = new System.Drawing.Point(647, 457);
            this.WidthTxt.Name = "WidthTxt";
            this.WidthTxt.Size = new System.Drawing.Size(50, 20);
            this.WidthTxt.TabIndex = 5;
            // 
            // ytext
            // 
            this.ytext.Location = new System.Drawing.Point(750, 341);
            this.ytext.Name = "ytext";
            this.ytext.Size = new System.Drawing.Size(50, 20);
            this.ytext.TabIndex = 4;
            // 
            // xtext
            // 
            this.xtext.Location = new System.Drawing.Point(647, 341);
            this.xtext.Name = "xtext";
            this.xtext.Size = new System.Drawing.Size(50, 20);
            this.xtext.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(647, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 251);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createShapesToolStripMenuItem,
            this.createLinesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createShapesToolStripMenuItem
            // 
            this.createShapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createElipseToolStripMenuItem,
            this.createCircleToolStripMenuItem,
            this.createRectangleToolStripMenuItem,
            this.createSquareToolStripMenuItem,
            this.createTriangleToolStripMenuItem});
            this.createShapesToolStripMenuItem.Name = "createShapesToolStripMenuItem";
            this.createShapesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.createShapesToolStripMenuItem.Text = "Create Shapes";
            // 
            // createElipseToolStripMenuItem
            // 
            this.createElipseToolStripMenuItem.Name = "createElipseToolStripMenuItem";
            this.createElipseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createElipseToolStripMenuItem.Text = "Create Elipse";
            this.createElipseToolStripMenuItem.Click += new System.EventHandler(this.createElipseToolStripMenuItem_Click);
            // 
            // createCircleToolStripMenuItem
            // 
            this.createCircleToolStripMenuItem.Name = "createCircleToolStripMenuItem";
            this.createCircleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createCircleToolStripMenuItem.Text = "Create Circle";
            this.createCircleToolStripMenuItem.Click += new System.EventHandler(this.createCircleToolStripMenuItem_Click);
            // 
            // createRectangleToolStripMenuItem
            // 
            this.createRectangleToolStripMenuItem.Name = "createRectangleToolStripMenuItem";
            this.createRectangleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createRectangleToolStripMenuItem.Text = "Create Rectangle";
            this.createRectangleToolStripMenuItem.Click += new System.EventHandler(this.createRectangleToolStripMenuItem_Click);
            // 
            // createSquareToolStripMenuItem
            // 
            this.createSquareToolStripMenuItem.Name = "createSquareToolStripMenuItem";
            this.createSquareToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createSquareToolStripMenuItem.Text = "Create Square";
            this.createSquareToolStripMenuItem.Click += new System.EventHandler(this.createSquareToolStripMenuItem_Click);
            // 
            // createTriangleToolStripMenuItem
            // 
            this.createTriangleToolStripMenuItem.Name = "createTriangleToolStripMenuItem";
            this.createTriangleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createTriangleToolStripMenuItem.Text = "Create Triangle";
            this.createTriangleToolStripMenuItem.Click += new System.EventHandler(this.createTriangleToolStripMenuItem_Click);
            // 
            // createLinesToolStripMenuItem
            // 
            this.createLinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLineToolStripMenuItem});
            this.createLinesToolStripMenuItem.Name = "createLinesToolStripMenuItem";
            this.createLinesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.createLinesToolStripMenuItem.Text = "Create Lines";
            // 
            // createLineToolStripMenuItem
            // 
            this.createLineToolStripMenuItem.Name = "createLineToolStripMenuItem";
            this.createLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createLineToolStripMenuItem.Text = "Create Line";
            this.createLineToolStripMenuItem.Click += new System.EventHandler(this.createLineToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 613);
            this.Controls.Add(this.form);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel form;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createElipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLineToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ytext;
        private System.Windows.Forms.TextBox xtext;
        public System.Windows.Forms.TextBox HeightTxt;
        public System.Windows.Forms.TextBox WidthTxt;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button rotatey;
        public System.Windows.Forms.Button rotatex;
        private System.Windows.Forms.ToolStripMenuItem createTriangleToolStripMenuItem;
    }
}

