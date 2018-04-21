namespace ApplicationLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Menus = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppName = new System.Windows.Forms.Label();
            this.AppPathLabel = new System.Windows.Forms.Label();
            this.AppPath = new System.Windows.Forms.Label();
            this.SaveDirLabel = new System.Windows.Forms.Label();
            this.SaveDir = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.MakerLabel = new System.Windows.Forms.Label();
            this.Maker = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Menus
            // 
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.Menus.Location = new System.Drawing.Point(0, 0);
            this.Menus.Name = "Menus";
            this.Menus.Size = new System.Drawing.Size(800, 24);
            this.Menus.TabIndex = 1;
            this.Menus.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitXToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileFToolStripMenuItem.Text = "File(&F)";
            // 
            // newNToolStripMenuItem
            // 
            this.newNToolStripMenuItem.Name = "newNToolStripMenuItem";
            this.newNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newNToolStripMenuItem.Text = "New(&N)...";
            this.newNToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.AppName, 2);
            this.AppName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AppName.Location = new System.Drawing.Point(100, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(65, 24);
            this.AppName.TabIndex = 2;
            this.AppName.Text = "xxxxx";
            this.AppName.Visible = false;
            // 
            // AppPathLabel
            // 
            this.AppPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AppPathLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.AppPathLabel, 2);
            this.AppPathLabel.Location = new System.Drawing.Point(3, 96);
            this.AppPathLabel.Name = "AppPathLabel";
            this.AppPathLabel.Size = new System.Drawing.Size(48, 12);
            this.AppPathLabel.TabIndex = 3;
            this.AppPathLabel.Text = "AppPath";
            this.AppPathLabel.Visible = false;
            // 
            // AppPath
            // 
            this.AppPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AppPath.AutoSize = true;
            this.AppPath.Location = new System.Drawing.Point(197, 96);
            this.AppPath.Name = "AppPath";
            this.AppPath.Size = new System.Drawing.Size(11, 12);
            this.AppPath.TabIndex = 4;
            this.AppPath.Text = "-";
            this.AppPath.Visible = false;
            // 
            // SaveDirLabel
            // 
            this.SaveDirLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveDirLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.SaveDirLabel, 2);
            this.SaveDirLabel.Location = new System.Drawing.Point(3, 137);
            this.SaveDirLabel.Name = "SaveDirLabel";
            this.SaveDirLabel.Size = new System.Drawing.Size(45, 12);
            this.SaveDirLabel.TabIndex = 5;
            this.SaveDirLabel.Text = "SaveDir";
            this.SaveDirLabel.Visible = false;
            // 
            // SaveDir
            // 
            this.SaveDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveDir.AutoSize = true;
            this.SaveDir.Location = new System.Drawing.Point(197, 137);
            this.SaveDir.Name = "SaveDir";
            this.SaveDir.Size = new System.Drawing.Size(11, 12);
            this.SaveDir.TabIndex = 6;
            this.SaveDir.Text = "-";
            this.SaveDir.Visible = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.CausesValidation = false;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartBtn.Location = new System.Drawing.Point(698, 179);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Visible = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Location = new System.Drawing.Point(698, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Visible = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // dataList
            // 
            this.dataList.AllowDrop = true;
            this.dataList.AllowUserToAddRows = false;
            this.dataList.AllowUserToDeleteRows = false;
            this.dataList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataList, 4);
            this.dataList.Location = new System.Drawing.Point(3, 208);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.ReadOnly = true;
            this.dataList.RowHeadersVisible = false;
            this.dataList.RowTemplate.Height = 21;
            this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataList.Size = new System.Drawing.Size(770, 200);
            this.dataList.TabIndex = 9;
            this.dataList.CurrentCellChanged += new System.EventHandler(this.dataList_CurrentCellChanged);
            this.dataList.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataList_DragDrop);
            this.dataList.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataList_DragEnter);
            // 
            // MakerLabel
            // 
            this.MakerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MakerLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MakerLabel, 2);
            this.MakerLabel.Location = new System.Drawing.Point(3, 55);
            this.MakerLabel.Name = "MakerLabel";
            this.MakerLabel.Size = new System.Drawing.Size(36, 12);
            this.MakerLabel.TabIndex = 10;
            this.MakerLabel.Text = "Maker";
            // 
            // Maker
            // 
            this.Maker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Maker.AutoSize = true;
            this.Maker.Location = new System.Drawing.Point(197, 55);
            this.Maker.Name = "Maker";
            this.Maker.Size = new System.Drawing.Size(11, 12);
            this.Maker.TabIndex = 11;
            this.Maker.Text = "-";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.MakerLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AppPathLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SaveDirLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.GenreLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EditBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Maker, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AppPath, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.SaveDir, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Genre, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataList, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.AppName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 411);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // GenreLabel
            // 
            this.GenreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GenreLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.GenreLabel, 2);
            this.GenreLabel.Location = new System.Drawing.Point(3, 178);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(35, 12);
            this.GenreLabel.TabIndex = 12;
            this.GenreLabel.Text = "Genre";
            // 
            // Genre
            // 
            this.Genre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(197, 178);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(11, 12);
            this.Genre.TabIndex = 13;
            this.Genre.Text = "-";
            // 
            // iconBox
            // 
            this.iconBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBox.Location = new System.Drawing.Point(3, 3);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(91, 35);
            this.iconBox.TabIndex = 14;
            this.iconBox.TabStop = false;
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help...";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Menus);
            this.MainMenuStrip = this.Menus;
            this.Name = "MainForm";
            this.Text = "ApplicationLauncher";
            this.Shown += new System.EventHandler(this.FormShown);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menus;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNToolStripMenuItem;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label AppPathLabel;
        private System.Windows.Forms.Label AppPath;
        private System.Windows.Forms.Label SaveDirLabel;
        private System.Windows.Forms.Label SaveDir;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.Label MakerLabel;
        private System.Windows.Forms.Label Maker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

