namespace ApplicationLauncher
{
    partial class RegisterForm
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
            this.cancel = new System.Windows.Forms.Button();
            this.regist = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.openExeFileBtn = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.saveDir = new System.Windows.Forms.Label();
            this.saveDirBox = new System.Windows.Forms.TextBox();
            this.openSaveDirBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.maker = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Genre = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.makerBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(311, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(73, 20);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // regist
            // 
            this.regist.Location = new System.Drawing.Point(234, 3);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(71, 20);
            this.regist.TabIndex = 9;
            this.regist.Text = "regist";
            this.regist.UseVisualStyleBackColor = true;
            this.regist.Click += new System.EventHandler(this.Regist_Click);
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(3, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(72, 27);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.nameBox, 2);
            this.nameBox.Location = new System.Drawing.Point(81, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(209, 19);
            this.nameBox.TabIndex = 1;
            // 
            // openExeFileBtn
            // 
            this.openExeFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openExeFileBtn.Location = new System.Drawing.Point(257, 57);
            this.openExeFileBtn.Name = "openExeFileBtn";
            this.openExeFileBtn.Size = new System.Drawing.Size(33, 21);
            this.openExeFileBtn.TabIndex = 4;
            this.openExeFileBtn.Text = "...";
            this.openExeFileBtn.UseVisualStyleBackColor = true;
            this.openExeFileBtn.Click += new System.EventHandler(this.OpenExeFileBtn_Click);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(3, 54);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(72, 27);
            this.path.TabIndex = 5;
            this.path.Text = "Path";
            // 
            // pathBox
            // 
            this.pathBox.AllowDrop = true;
            this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathBox.Location = new System.Drawing.Point(81, 57);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(170, 19);
            this.pathBox.TabIndex = 3;
            this.pathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathBox_DragDrop);
            this.pathBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathBox_DragEnter);
            // 
            // iconBox
            // 
            this.iconBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBox.Location = new System.Drawing.Point(296, 3);
            this.iconBox.Name = "iconBox";
            this.tableLayoutPanel1.SetRowSpan(this.iconBox, 5);
            this.iconBox.Size = new System.Drawing.Size(94, 129);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 7;
            this.iconBox.TabStop = false;
            // 
            // saveDir
            // 
            this.saveDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDir.AutoSize = true;
            this.saveDir.Location = new System.Drawing.Point(3, 81);
            this.saveDir.Name = "saveDir";
            this.saveDir.Size = new System.Drawing.Size(72, 27);
            this.saveDir.TabIndex = 8;
            this.saveDir.Text = "SaveDir";
            // 
            // saveDirBox
            // 
            this.saveDirBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDirBox.Location = new System.Drawing.Point(81, 84);
            this.saveDirBox.Name = "saveDirBox";
            this.saveDirBox.Size = new System.Drawing.Size(170, 19);
            this.saveDirBox.TabIndex = 5;
            // 
            // openSaveDirBtn
            // 
            this.openSaveDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openSaveDirBtn.Location = new System.Drawing.Point(257, 84);
            this.openSaveDirBtn.Name = "openSaveDirBtn";
            this.openSaveDirBtn.Size = new System.Drawing.Size(33, 21);
            this.openSaveDirBtn.TabIndex = 6;
            this.openSaveDirBtn.Text = "...";
            this.openSaveDirBtn.UseVisualStyleBackColor = true;
            this.openSaveDirBtn.Click += new System.EventHandler(this.OpenSaveDirBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(157, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(71, 20);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // maker
            // 
            this.maker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maker.AutoSize = true;
            this.maker.Location = new System.Drawing.Point(3, 27);
            this.maker.Name = "maker";
            this.maker.Size = new System.Drawing.Size(72, 27);
            this.maker.TabIndex = 12;
            this.maker.Text = "Maker";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.openSaveDirBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.openExeFileBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.maker, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.path, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveDir, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveDirBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pathBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Genre, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.genreBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.makerBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 167);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.DeleteBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancel, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.regist, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 26);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // Genre
            // 
            this.Genre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(3, 108);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(72, 27);
            this.Genre.TabIndex = 15;
            this.Genre.Text = "Genre";
            // 
            // genreBox
            // 
            this.genreBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.genreBox, 2);
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(81, 111);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(209, 20);
            this.genreBox.TabIndex = 7;
            // 
            // makerBox
            // 
            this.makerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.makerBox, 2);
            this.makerBox.FormattingEnabled = true;
            this.makerBox.Location = new System.Drawing.Point(81, 30);
            this.makerBox.Name = "makerBox";
            this.makerBox.Size = new System.Drawing.Size(209, 20);
            this.makerBox.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 188);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button regist;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button openExeFileBtn;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label saveDir;
        private System.Windows.Forms.TextBox saveDirBox;
        private System.Windows.Forms.Button openSaveDirBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label maker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.ComboBox makerBox;
    }
}