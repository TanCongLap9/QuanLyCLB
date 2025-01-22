
namespace QuanLyCLB.Console
{
    partial class BangDieuKhien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tCommand = new ReaLTaiizor.Controls.PoisonTextBox();
            this.dgvOutput = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tOutput = new System.Windows.Forms.TextBox();
            this.pMaBaoMat = new ReaLTaiizor.Controls.PoisonPanel();
            this.lStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.tMaBaoMat = new ReaLTaiizor.Controls.PoisonTextBox();
            this.pQuanLy = new ReaLTaiizor.Controls.PoisonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.pMaBaoMat.SuspendLayout();
            this.pQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCommand
            // 
            this.tCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tCommand.CustomButton.Image = null;
            this.tCommand.CustomButton.Location = new System.Drawing.Point(760, 1);
            this.tCommand.CustomButton.Name = "";
            this.tCommand.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.tCommand.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tCommand.CustomButton.TabIndex = 1;
            this.tCommand.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tCommand.CustomButton.UseSelectable = true;
            this.tCommand.CustomButton.Visible = false;
            this.tCommand.Lines = new string[0];
            this.tCommand.Location = new System.Drawing.Point(0, 0);
            this.tCommand.Margin = new System.Windows.Forms.Padding(0);
            this.tCommand.MaxLength = 32767;
            this.tCommand.Multiline = true;
            this.tCommand.Name = "tCommand";
            this.tCommand.PasswordChar = '\0';
            this.tCommand.PromptText = "Nhập \'help\' để hiển thị danh sách các câu lệnh.\r\nNhấn Enter để thực thi lệnh hoặc" +
    " Shift+Enter để xuống dòng.";
            this.tCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tCommand.SelectedText = "";
            this.tCommand.SelectionLength = 0;
            this.tCommand.SelectionStart = 0;
            this.tCommand.ShortcutsEnabled = true;
            this.tCommand.Size = new System.Drawing.Size(800, 41);
            this.tCommand.TabIndex = 0;
            this.tCommand.UseSelectable = true;
            this.tCommand.WaterMark = "Nhập \'help\' để hiển thị danh sách các câu lệnh.\r\nNhấn Enter để thực thi lệnh hoặc" +
    " Shift+Enter để xuống dòng.";
            this.tCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.poisonTextBox1_KeyDown);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutput.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOutput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOutput.EnableHeadersVisualStyles = false;
            this.dgvOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOutput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOutput.Location = new System.Drawing.Point(0, 41);
            this.dgvOutput.Margin = new System.Windows.Forms.Padding(0);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutput.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOutput.Size = new System.Drawing.Size(800, 409);
            this.dgvOutput.TabIndex = 1;
            this.dgvOutput.Visible = false;
            // 
            // tOutput
            // 
            this.tOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tOutput.BackColor = System.Drawing.SystemColors.Window;
            this.tOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tOutput.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.tOutput.Location = new System.Drawing.Point(0, 41);
            this.tOutput.Margin = new System.Windows.Forms.Padding(0);
            this.tOutput.Multiline = true;
            this.tOutput.Name = "tOutput";
            this.tOutput.ReadOnly = true;
            this.tOutput.Size = new System.Drawing.Size(800, 409);
            this.tOutput.TabIndex = 2;
            this.tOutput.Visible = false;
            // 
            // pMaBaoMat
            // 
            this.pMaBaoMat.Controls.Add(this.lStatus);
            this.pMaBaoMat.Controls.Add(this.tMaBaoMat);
            this.pMaBaoMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMaBaoMat.HorizontalScrollbarBarColor = true;
            this.pMaBaoMat.HorizontalScrollbarHighlightOnWheel = false;
            this.pMaBaoMat.HorizontalScrollbarSize = 10;
            this.pMaBaoMat.Location = new System.Drawing.Point(0, 0);
            this.pMaBaoMat.Margin = new System.Windows.Forms.Padding(0);
            this.pMaBaoMat.Name = "pMaBaoMat";
            this.pMaBaoMat.Size = new System.Drawing.Size(800, 450);
            this.pMaBaoMat.TabIndex = 0;
            this.pMaBaoMat.VerticalScrollbarBarColor = true;
            this.pMaBaoMat.VerticalScrollbarHighlightOnWheel = false;
            this.pMaBaoMat.VerticalScrollbarSize = 10;
            // 
            // lStatus
            // 
            this.lStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStatus.Location = new System.Drawing.Point(199, 248);
            this.lStatus.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(403, 23);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "Nhập mã bảo mật để tiếp tục.";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tMaBaoMat
            // 
            this.tMaBaoMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.tMaBaoMat.CustomButton.Image = null;
            this.tMaBaoMat.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.tMaBaoMat.CustomButton.Name = "";
            this.tMaBaoMat.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tMaBaoMat.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tMaBaoMat.CustomButton.TabIndex = 1;
            this.tMaBaoMat.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tMaBaoMat.CustomButton.UseSelectable = true;
            this.tMaBaoMat.CustomButton.Visible = false;
            this.tMaBaoMat.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Tall;
            this.tMaBaoMat.Lines = new string[0];
            this.tMaBaoMat.Location = new System.Drawing.Point(288, 210);
            this.tMaBaoMat.Margin = new System.Windows.Forms.Padding(0);
            this.tMaBaoMat.MaxLength = 8;
            this.tMaBaoMat.Name = "tMaBaoMat";
            this.tMaBaoMat.PasswordChar = '●';
            this.tMaBaoMat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tMaBaoMat.SelectedText = "";
            this.tMaBaoMat.SelectionLength = 0;
            this.tMaBaoMat.SelectionStart = 0;
            this.tMaBaoMat.ShortcutsEnabled = true;
            this.tMaBaoMat.Size = new System.Drawing.Size(225, 30);
            this.tMaBaoMat.TabIndex = 1;
            this.tMaBaoMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tMaBaoMat.UseSelectable = true;
            this.tMaBaoMat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tMaBaoMat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tMaBaoMat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tMaBaoMat_KeyDown);
            // 
            // pQuanLy
            // 
            this.pQuanLy.AutoScroll = true;
            this.pQuanLy.Controls.Add(this.dgvOutput);
            this.pQuanLy.Controls.Add(this.tOutput);
            this.pQuanLy.Controls.Add(this.tCommand);
            this.pQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pQuanLy.HorizontalScrollbar = true;
            this.pQuanLy.HorizontalScrollbarBarColor = true;
            this.pQuanLy.HorizontalScrollbarHighlightOnWheel = false;
            this.pQuanLy.HorizontalScrollbarSize = 10;
            this.pQuanLy.Location = new System.Drawing.Point(0, 0);
            this.pQuanLy.Margin = new System.Windows.Forms.Padding(0);
            this.pQuanLy.Name = "pQuanLy";
            this.pQuanLy.Size = new System.Drawing.Size(800, 450);
            this.pQuanLy.TabIndex = 1;
            this.pQuanLy.VerticalScrollbar = true;
            this.pQuanLy.VerticalScrollbarBarColor = true;
            this.pQuanLy.VerticalScrollbarHighlightOnWheel = false;
            this.pQuanLy.VerticalScrollbarSize = 10;
            this.pQuanLy.Visible = false;
            // 
            // BangDieuKhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pQuanLy);
            this.Controls.Add(this.pMaBaoMat);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BangDieuKhien";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.pMaBaoMat.ResumeLayout(false);
            this.pQuanLy.ResumeLayout(false);
            this.pQuanLy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTextBox tCommand;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvOutput;
        private System.Windows.Forms.TextBox tOutput;
        private ReaLTaiizor.Controls.PoisonPanel pMaBaoMat;
        private ReaLTaiizor.Controls.PoisonLabel lStatus;
        private ReaLTaiizor.Controls.PoisonTextBox tMaBaoMat;
        private ReaLTaiizor.Controls.PoisonPanel pQuanLy;
    }
}