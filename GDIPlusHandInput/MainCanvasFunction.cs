using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;


namespace GDIPlusHandInput
{
    public partial class MainCanvas
    {
        #region Import Winapi
        [DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc,
           int nXSrc, int nYSrc, long dwRop);
        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteDC(IntPtr hDc);
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateCompatibleDC(IntPtr hdc);
        [DllImport("gdi32.dll")]
        static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);
        [DllImport("user32.dll")]  
        public static extern IntPtr GetWindowDC(IntPtr ptr);
        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, UInt32 nFlags);
        #endregion

        public void BeginPaint()
        {
            this.Show();
            this.m_bufferCanvas.Show();
        }
        public void EndPaint()
        {
            this.Clear();
            this.Hide();
            this.m_bufferCanvas.Hide();
        }
        public Bitmap GetDrawImage()
        {
            int width = 0, height = 0;
            try
            {
                
                 //* 有bug，当成组件无法得到正确的图像
                Graphics g = Graphics.FromHwnd(this.m_bufferCanvas.Handle);
                width = this.Width;
                height = this.Height;
                Bitmap bitmap = new Bitmap(Width, Height);
                Graphics graBitmap = Graphics.FromImage(bitmap);
                IntPtr bitmapHdc = graBitmap.GetHdc();
                IntPtr gHdc = g.GetHdc();
                BitBlt(bitmapHdc, 0, 0, this.Width, this.Width, gHdc, 0, 0, 0x00CC0020);
                graBitmap.ReleaseHdc();
                g.ReleaseHdc();
                g.Dispose();
                bitmap.Save("d:\\1.png");
                return bitmap;
                
                /*
                IntPtr bufferHdc = GetWindowDC(this.m_bufferCanvas.Handle);
                Control control = Control.FromHandle(this.m_bufferCanvas.Handle);
                IntPtr hbitmap = CreateCompatibleBitmap(bufferHdc, control.Width,
                    control.Height);
                IntPtr hmemdc = CreateCompatibleDC(bufferHdc);
                SelectObject(hmemdc, hbitmap);
                PrintWindow(this.m_bufferCanvas.Handle, hmemdc, 0);
                Bitmap bitmap = Bitmap.FromHbitmap(hbitmap);
                DeleteDC(bufferHdc);
                DeleteDC(hmemdc);
                bitmap.Save("D:\\1.png");
                return bitmap;
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new Bitmap(width, height);
            }
        }
        public void Clear()
        {
            Graphics g = this.m_bufferCanvas.CreateGraphics();
            g.Clear(Color.FromArgb(255,255,255));
            this.m_bufferCanvas.Opacity = 1;
        }
        #region 初始化
        private void InitConstruct()
        {
            this.m_usingColor = Color.Red;
            this.m_penWidth = 2;
            this.bufferCanvas = new BufferCanvas();
            this.m_lastPoint = new Point(0, 0);
        }
        #endregion
        public void SetWidth(int width)
        {
            this.Width = width;
            this.m_bufferCanvas.Width = width;
        }
        public void SetHeight(int height)
        {
            this.Height = height;
            this.m_bufferCanvas.Height = height;
        }
        public void SetLocation(Point point)
        {
            this.Location = point;
            this.m_bufferCanvas.Location = point;
        }
        public bool EnableDraw
        {
            set
            {
                this.m_enableDraw = value;
            }
            get
            {
                return this.m_enableDraw;
            }
        }
        public PaintControls paintControls
        {
            get
            {
                return this.m_paintControls;
            }
            set
            {
                this.m_paintControls = value;
            }
        }
        public Color penColor
        {
            get
            {
                return this.m_usingColor;
            }
            set
            {
                this.m_usingColor = value;
            }
        }
        public int penWidth
        {
            get
            {
                return this.m_penWidth;
            }
            set
            {
                this.m_penWidth = value;
            }
        }
        public BufferCanvas bufferCanvas
        {
            get
            {
                return this.m_bufferCanvas;
            }
            set
            {
                this.m_bufferCanvas = value;
            }
        }
        private Point m_lastPoint;
        //画图控制窗口
        private PaintControls m_paintControls;
        //显示画图笔记的窗口
        private BufferCanvas m_bufferCanvas;
        //是否可以画图
        private bool m_enableDraw;
        //画笔颜色
        private Color m_usingColor;
        //笔粗细
        private int m_penWidth;
    }
}