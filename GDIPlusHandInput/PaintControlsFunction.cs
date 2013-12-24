using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GDIPlusHandInput
{
    public partial class PaintControls
    {
        /// <summary>
        /// 显示画布开始画图
        /// </summary>
        public void BeginPaint()
        {
            if (this.BeforePaintBegin != null)
            {
                this.BeforePaintBegin();
            }
            this.m_mainCanvas.BeginPaint();
            if (this.AfterPaintBegin != null)
            {
                this.AfterPaintBegin();
            }
        }
        /// <summary>
        /// 结束画图
        /// </summary>
        public void EndPaint()
        {
            if (this.BeforePaintEnd != null)
            {
                this.BeforePaintEnd();
            }
            this.m_mainCanvas.EndPaint();
            if (this.AfterPaintEnd != null)
            {
                this.AfterPaintEnd();
            }
        }
        private void InitConstruct()
        {
            this.m_mainCanvas = new MainCanvas();
            this.m_mainCanvas.paintControls = this;
        }
        /// <summary>
        /// 清除画布图像
        /// </summary>
        public void Clear()
        {
            this.m_mainCanvas.Clear();
        }
        public void SetCanvasWitdh(int width)
        {
            this.m_mainCanvas.SetWidth(width);
        }
        public void SetCanvasHeight(int height)
        {
            this.m_mainCanvas.SetHeight(height);
        }
        public void SetCanvasLocation(Point location)
        {
            this.m_mainCanvas.SetLocation(location);
        }
        /// <summary>
        /// 设置画笔颜色
        /// </summary>
        /// <param name="color">颜色参数，Color类型</param>
        public void SetPenUsingColor(Color color)
        {
            this.m_mainCanvas.penColor= color;
        }
        /// <summary>
        /// 画笔宽度
        /// </summary>
        /// <param name="width">宽度</param>
        public void SetPenWidth(int width)
        {
            this.m_mainCanvas.penWidth = width;
        }
        /// <summary>
        /// 获得画布上的图像
        /// </summary>
        /// <returns>返回图像</returns>
        public Bitmap GetImage()
        {
            Bitmap _bitmap = this.m_mainCanvas.GetDrawImage();
            _bitmap.Save("d:\\2.bmp");
            return _bitmap;
        }
        /// <summary>
        /// 保存所画的图像
        /// </summary>
        /// <param name="imagepath">所要保存的位置</param>
        /// <returns></returns>
        public bool SaveImage(string imagepath)
        {
            try
            {
                Bitmap bitmap = this.m_mainCanvas.GetDrawImage();
                bitmap.Save(imagepath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存图片失败" + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 指向画布类型的指针
        /// </summary>
        public MainCanvas mainCanvas
        {
            get
            {
                return this.m_mainCanvas;
            }
            set
            {
                this.m_mainCanvas = value;
            }
        }
        MainCanvas m_mainCanvas;
        public delegate void NormalEvent();
        //结束画图之前事件
        public event NormalEvent AfterPaintEnd;
        //结束画图之后事件
        public event NormalEvent BeforePaintEnd;

        public event NormalEvent BeforePaintBegin;

        public event NormalEvent AfterPaintBegin;

    }
}