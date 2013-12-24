using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GDIPlusHandInput
{
    public partial class PaintControls : UserControl
    {
        public PaintControls()
        {
            InitializeComponent();
            this.InitConstruct();
        }

        private void PenUsingColorpictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgret = this.PencolorDialog.ShowDialog();
                if (dlgret == DialogResult.OK)
                {
                    Color color = this.PencolorDialog.Color;
                    this.PenUsingColorpictureBox.BackColor = color;
                    this.SetPenUsingColor(color);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void PaintControls_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.m_mainCanvas.Hide();
        }

        private void EndPaintbutton_Click(object sender, EventArgs e)
        {
            this.EndPaint();
        }

        private void PenWidthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int w;
            w = Convert.ToInt32( ((ComboBox)sender).Text );
            this.SetPenWidth(w);
        }

        private void ClearPaintbutton_Click(object sender, EventArgs e)
        {
            this.m_mainCanvas.Clear();
        }

        private void BeginPaintbutton_Click(object sender, EventArgs e)
        {
            this.BeginPaint();
        }

        private void HidePaintbutton_Click(object sender, EventArgs e)
        {
            this.EndPaint();
            this.Hide();
        }
    }
}
