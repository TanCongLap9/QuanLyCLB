namespace QuanLyCLB.CauLacBo
{
    partial class ThongTinCLB
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Google",
            "https://www.google.com"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Facebook",
            "https://www.facebook.com"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tiktok",
            "https://tiktok.com"}, -1);
            this.lTenClb = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tMoTaClb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTenClb
            // 
            this.lTenClb.AutoSize = true;
            this.lTenClb.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.lTenClb.Location = new System.Drawing.Point(0, 0);
            this.lTenClb.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lTenClb.Name = "lTenClb";
            this.lTenClb.Size = new System.Drawing.Size(161, 25);
            this.lTenClb.TabIndex = 0;
            this.lTenClb.Text = "Câu lạc bộ thể thao";
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel3.Location = new System.Drawing.Point(0, 232);
            this.poisonLabel3.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(110, 25);
            this.poisonLabel3.TabIndex = 2;
            this.poisonLabel3.Text = "Liên kết khác";
            this.poisonLabel3.WrapToLine = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lTenClb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.poisonLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tMoTaClb, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView.Location = new System.Drawing.Point(0, 265);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(798, 192);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nền tảng";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đường link";
            this.columnHeader2.Width = 427;
            // 
            // tMoTaClb
            // 
            this.tMoTaClb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tMoTaClb.BackColor = System.Drawing.Color.White;
            this.tMoTaClb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMoTaClb.Cursor = System.Windows.Forms.Cursors.Default;
            this.tMoTaClb.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.tMoTaClb.Location = new System.Drawing.Point(0, 33);
            this.tMoTaClb.Margin = new System.Windows.Forms.Padding(0);
            this.tMoTaClb.Multiline = true;
            this.tMoTaClb.Name = "tMoTaClb";
            this.tMoTaClb.ReadOnly = true;
            this.tMoTaClb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tMoTaClb.Size = new System.Drawing.Size(798, 191);
            this.tMoTaClb.TabIndex = 1;
            this.tMoTaClb.Text = "dfasfasfasfdasf";
            this.tMoTaClb.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // ThongTinCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ThongTinCLB";
            this.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.Size = new System.Drawing.Size(862, 489);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonLabel lTenClb;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tMoTaClb;
    }
}
