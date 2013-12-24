namespace GDIPlusHandInput
{
    partial class PaintControls
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
            this.components = new System.ComponentModel.Container();
            this.ClearPaintbutton = new System.Windows.Forms.Button();
            this.PencolorDialog = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PenWidthcomboBox = new System.Windows.Forms.ComboBox();
            this.PenUsingColorpictureBox = new System.Windows.Forms.PictureBox();
            this.BeginPaintbutton = new System.Windows.Forms.Button();
            this.EndPaintbutton = new System.Windows.Forms.Button();
            this.HidePaintbutton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenUsingColorpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearPaintbutton
            // 
            this.ClearPaintbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearPaintbutton.Location = new System.Drawing.Point(85, 3);
            this.ClearPaintbutton.Name = "ClearPaintbutton";
            this.ClearPaintbutton.Size = new System.Drawing.Size(35, 35);
            this.ClearPaintbutton.TabIndex = 2;
            this.ClearPaintbutton.Text = "C";
            this.toolTip1.SetToolTip(this.ClearPaintbutton, "清除图片");
            this.ClearPaintbutton.UseVisualStyleBackColor = true;
            this.ClearPaintbutton.Click += new System.EventHandler(this.ClearPaintbutton_Click);
            // 
            // PencolorDialog
            // 
            this.PencolorDialog.Color = System.Drawing.Color.Red;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BeginPaintbutton);
            this.flowLayoutPanel1.Controls.Add(this.EndPaintbutton);
            this.flowLayoutPanel1.Controls.Add(this.ClearPaintbutton);
            this.flowLayoutPanel1.Controls.Add(this.HidePaintbutton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 39);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // PenWidthcomboBox
            // 
            this.PenWidthcomboBox.FormattingEnabled = true;
            this.PenWidthcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.PenWidthcomboBox.Location = new System.Drawing.Point(270, 8);
            this.PenWidthcomboBox.Name = "PenWidthcomboBox";
            this.PenWidthcomboBox.Size = new System.Drawing.Size(37, 20);
            this.PenWidthcomboBox.TabIndex = 6;
            this.PenWidthcomboBox.Text = "2";
            this.PenWidthcomboBox.SelectedIndexChanged += new System.EventHandler(this.PenWidthcomboBox_SelectedIndexChanged);
            // 
            // PenUsingColorpictureBox
            // 
            this.PenUsingColorpictureBox.BackColor = System.Drawing.Color.Red;
            this.PenUsingColorpictureBox.Location = new System.Drawing.Point(243, 8);
            this.PenUsingColorpictureBox.Name = "PenUsingColorpictureBox";
            this.PenUsingColorpictureBox.Size = new System.Drawing.Size(21, 20);
            this.PenUsingColorpictureBox.TabIndex = 5;
            this.PenUsingColorpictureBox.TabStop = false;
            this.PenUsingColorpictureBox.Click += new System.EventHandler(this.PenUsingColorpictureBox_Click);
            // 
            // BeginPaintbutton
            // 
            this.BeginPaintbutton.BackgroundImage = global::GDIPlusHandInput.Properties.Resources.play;
            this.BeginPaintbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BeginPaintbutton.Location = new System.Drawing.Point(3, 3);
            this.BeginPaintbutton.Name = "BeginPaintbutton";
            this.BeginPaintbutton.Size = new System.Drawing.Size(35, 35);
            this.BeginPaintbutton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BeginPaintbutton, "开始画图");
            this.BeginPaintbutton.UseVisualStyleBackColor = true;
            this.BeginPaintbutton.Click += new System.EventHandler(this.BeginPaintbutton_Click);
            // 
            // EndPaintbutton
            // 
            this.EndPaintbutton.BackgroundImage = global::GDIPlusHandInput.Properties.Resources.ok;
            this.EndPaintbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EndPaintbutton.Location = new System.Drawing.Point(44, 3);
            this.EndPaintbutton.Name = "EndPaintbutton";
            this.EndPaintbutton.Size = new System.Drawing.Size(35, 35);
            this.EndPaintbutton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.EndPaintbutton, "完成");
            this.EndPaintbutton.UseVisualStyleBackColor = true;
            this.EndPaintbutton.Click += new System.EventHandler(this.EndPaintbutton_Click);
            // 
            // HidePaintbutton
            // 
            this.HidePaintbutton.BackgroundImage = global::GDIPlusHandInput.Properties.Resources.exit;
            this.HidePaintbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HidePaintbutton.Location = new System.Drawing.Point(126, 3);
            this.HidePaintbutton.Name = "HidePaintbutton";
            this.HidePaintbutton.Size = new System.Drawing.Size(35, 35);
            this.HidePaintbutton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.HidePaintbutton, "取消");
            this.HidePaintbutton.UseVisualStyleBackColor = true;
            this.HidePaintbutton.Click += new System.EventHandler(this.HidePaintbutton_Click);
            // 
            // PaintControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PenWidthcomboBox);
            this.Controls.Add(this.PenUsingColorpictureBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PaintControls";
            this.Size = new System.Drawing.Size(322, 48);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PenUsingColorpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EndPaintbutton;
        private System.Windows.Forms.Button ClearPaintbutton;
        private System.Windows.Forms.ColorDialog PencolorDialog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox PenUsingColorpictureBox;
        private System.Windows.Forms.ComboBox PenWidthcomboBox;
        private System.Windows.Forms.Button BeginPaintbutton;
        private System.Windows.Forms.Button HidePaintbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}