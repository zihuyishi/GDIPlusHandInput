using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GDIPlusHandInput
{
    public partial class MainCanvas : Form
    {
        public MainCanvas()
        {
            InitializeComponent();
            this.InitConstruct();
        }
        public MainCanvas(int Width, int Height)
        {
            InitializeComponent();
            this.InitConstruct();
            this.Width = Width;
            this.Height = Height;
        }

        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            bool ret = this.EnableDraw;
            if (!ret)
            {
                return;
            }
            try
            {
                Graphics g = this.m_bufferCanvas.CreateGraphics();
                Pen pen = new Pen(this.penColor, this.m_penWidth);
                Point pt = new Point(e.X, e.Y);
                g.DrawLine(pen, this.m_lastPoint, pt);
                this.m_lastPoint = pt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void MainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_lastPoint.X = e.X;
            this.m_lastPoint.Y = e.Y;
            this.EnableDraw = true;
        }

        private void MainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            this.EnableDraw = false;
        }

        private void MainCanvas_MouseLeave(object sender, EventArgs e)
        {
            this.EnableDraw = false;
        }
    }
}
