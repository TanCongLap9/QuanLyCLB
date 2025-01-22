
namespace QuanLyCLB.Lich
{
    partial class Lich
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pLich = new ReaLTaiizor.Controls.PoisonPanel();
            this.fpGio = new System.Windows.Forms.FlowLayoutPanel();
            this.pKeoVaoLich = new QuanLyCLB.Lich.LoaiLichItem();
            this.SuspendLayout();
            // 
            // pLich
            // 
            this.pLich.AllowDrop = true;
            this.pLich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLich.BackColor = System.Drawing.Color.Transparent;
            this.pLich.HorizontalScrollbarBarColor = true;
            this.pLich.HorizontalScrollbarHighlightOnWheel = false;
            this.pLich.HorizontalScrollbarSize = 10;
            this.pLich.Location = new System.Drawing.Point(60, 0);
            this.pLich.Margin = new System.Windows.Forms.Padding(0);
            this.pLich.Name = "pLich";
            this.pLich.Size = new System.Drawing.Size(832, 492);
            this.pLich.TabIndex = 1;
            this.pLich.UseCustomBackColor = true;
            this.pLich.VerticalScrollbarBarColor = true;
            this.pLich.VerticalScrollbarHighlightOnWheel = false;
            this.pLich.VerticalScrollbarSize = 10;
            this.pLich.DragDrop += new System.Windows.Forms.DragEventHandler(this.poisonPanel2_DragDrop);
            this.pLich.DragEnter += new System.Windows.Forms.DragEventHandler(this.poisonPanel2_DragEnter);
            this.pLich.DragOver += new System.Windows.Forms.DragEventHandler(this.poisonPanel2_DragOver);
            this.pLich.DragLeave += new System.EventHandler(this.poisonPanel2_DragLeave);
            // 
            // fpGio
            // 
            this.fpGio.BackColor = System.Drawing.Color.Transparent;
            this.fpGio.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpGio.Location = new System.Drawing.Point(0, 0);
            this.fpGio.Margin = new System.Windows.Forms.Padding(0);
            this.fpGio.Name = "fpGio";
            this.fpGio.Size = new System.Drawing.Size(60, 492);
            this.fpGio.TabIndex = 0;
            this.fpGio.WrapContents = false;
            // 
            // pKeoVaoLich
            // 
            this.pKeoVaoLich.ActiveControl = null;
            this.pKeoVaoLich.BackColor = System.Drawing.Color.White;
            this.pKeoVaoLich.DisplayFocusBorder = false;
            this.pKeoVaoLich.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pKeoVaoLich.Location = new System.Drawing.Point(0, 0);
            this.pKeoVaoLich.Margin = new System.Windows.Forms.Padding(0);
            this.pKeoVaoLich.Model = null;
            this.pKeoVaoLich.Name = "pKeoVaoLich";
            this.pKeoVaoLich.Size = new System.Drawing.Size(120, 72);
            this.pKeoVaoLich.TabIndex = 2;
            this.pKeoVaoLich.Text = "Lịch thi đấu";
            this.pKeoVaoLich.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.pKeoVaoLich.TileTextFontSize = ReaLTaiizor.Extension.Poison.PoisonTileTextSize.Small;
            this.pKeoVaoLich.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Regular;
            this.pKeoVaoLich.UseCustomBackColor = true;
            this.pKeoVaoLich.UseCustomForeColor = true;
            this.pKeoVaoLich.UseSelectable = true;
            this.pKeoVaoLich.UseStyleColors = true;
            this.pKeoVaoLich.Visible = false;
            // 
            // Lich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pKeoVaoLich);
            this.Controls.Add(this.fpGio);
            this.Controls.Add(this.pLich);
            this.DoubleBuffered = true;
            this.Name = "Lich";
            this.Size = new System.Drawing.Size(892, 492);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonPanel pLich;
        private LoaiLichItem pKeoVaoLich;
        private System.Windows.Forms.FlowLayoutPanel fpGio;
    }
}
