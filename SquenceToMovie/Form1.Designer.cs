namespace SquenceToMovie
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.btnInputfile = new System.Windows.Forms.Button();
			this.tbInputFile = new System.Windows.Forms.TextBox();
			this.gpInputfile = new System.Windows.Forms.GroupBox();
			this.tbExportName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbIsSound = new System.Windows.Forms.CheckBox();
			this.btnSound = new System.Windows.Forms.Button();
			this.tbSound = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnExportDir = new System.Windows.Forms.Button();
			this.tbExportDir = new System.Windows.Forms.TextBox();
			this.combCodec1 = new SquenceToMovie.CombCodec();
			this.combFrameRate1 = new SquenceToMovie.CombFrameRate();
			this.sequenceFileTo1 = new SquenceToMovie.SequenceFileTo();
			this.menuStrip1.SuspendLayout();
			this.gpInputfile.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(604, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.saveAsToolStripMenuItem.Text = "SaveAs";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.aboutToolStripMenuItem.Text = "バージョン情報の表示";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 329);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(604, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// btnInputfile
			// 
			this.btnInputfile.AllowDrop = true;
			this.btnInputfile.Location = new System.Drawing.Point(16, 18);
			this.btnInputfile.Name = "btnInputfile";
			this.btnInputfile.Size = new System.Drawing.Size(75, 23);
			this.btnInputfile.TabIndex = 2;
			this.btnInputfile.Text = "Select";
			this.btnInputfile.UseVisualStyleBackColor = true;
			this.btnInputfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbInputFile_DragDrop);
			this.btnInputfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// tbInputFile
			// 
			this.tbInputFile.AllowDrop = true;
			this.tbInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbInputFile.Location = new System.Drawing.Point(97, 20);
			this.tbInputFile.Name = "tbInputFile";
			this.tbInputFile.ReadOnly = true;
			this.tbInputFile.Size = new System.Drawing.Size(477, 19);
			this.tbInputFile.TabIndex = 3;
			this.tbInputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbInputFile_DragDrop);
			this.tbInputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// gpInputfile
			// 
			this.gpInputfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpInputfile.Controls.Add(this.btnInputfile);
			this.gpInputfile.Controls.Add(this.tbInputFile);
			this.gpInputfile.Location = new System.Drawing.Point(12, 27);
			this.gpInputfile.Name = "gpInputfile";
			this.gpInputfile.Size = new System.Drawing.Size(580, 51);
			this.gpInputfile.TabIndex = 4;
			this.gpInputfile.TabStop = false;
			this.gpInputfile.Text = "連番ファイル";
			// 
			// tbExportName
			// 
			this.tbExportName.AllowDrop = true;
			this.tbExportName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbExportName.Location = new System.Drawing.Point(97, 87);
			this.tbExportName.Name = "tbExportName";
			this.tbExportName.Size = new System.Drawing.Size(241, 23);
			this.tbExportName.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cbIsSound);
			this.groupBox1.Controls.Add(this.btnSound);
			this.groupBox1.Controls.Add(this.tbSound);
			this.groupBox1.Location = new System.Drawing.Point(12, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(580, 79);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "音声ファイル";
			// 
			// cbIsSound
			// 
			this.cbIsSound.AutoSize = true;
			this.cbIsSound.Location = new System.Drawing.Point(26, 18);
			this.cbIsSound.Name = "cbIsSound";
			this.cbIsSound.Size = new System.Drawing.Size(76, 16);
			this.cbIsSound.TabIndex = 4;
			this.cbIsSound.Text = "音を付ける";
			this.cbIsSound.UseVisualStyleBackColor = true;
			// 
			// btnSound
			// 
			this.btnSound.AllowDrop = true;
			this.btnSound.Location = new System.Drawing.Point(16, 40);
			this.btnSound.Name = "btnSound";
			this.btnSound.Size = new System.Drawing.Size(75, 23);
			this.btnSound.TabIndex = 2;
			this.btnSound.Text = "Select";
			this.btnSound.UseVisualStyleBackColor = true;
			this.btnSound.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnSound_DragDrop);
			this.btnSound.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// tbSound
			// 
			this.tbSound.AllowDrop = true;
			this.tbSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSound.Location = new System.Drawing.Point(97, 40);
			this.tbSound.Name = "tbSound";
			this.tbSound.ReadOnly = true;
			this.tbSound.Size = new System.Drawing.Size(477, 19);
			this.tbSound.TabIndex = 3;
			this.tbSound.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnSound_DragDrop);
			this.tbSound.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.btnExport);
			this.groupBox2.Controls.Add(this.tbExportName);
			this.groupBox2.Controls.Add(this.btnExportDir);
			this.groupBox2.Controls.Add(this.combCodec1);
			this.groupBox2.Controls.Add(this.tbExportDir);
			this.groupBox2.Controls.Add(this.combFrameRate1);
			this.groupBox2.Location = new System.Drawing.Point(12, 169);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(580, 152);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "出力ムービー";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(273, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "Codec";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "FrameRate";
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.Location = new System.Drawing.Point(384, 89);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(155, 40);
			this.btnExport.TabIndex = 7;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnExportDir
			// 
			this.btnExportDir.AllowDrop = true;
			this.btnExportDir.Location = new System.Drawing.Point(16, 60);
			this.btnExportDir.Name = "btnExportDir";
			this.btnExportDir.Size = new System.Drawing.Size(75, 23);
			this.btnExportDir.TabIndex = 2;
			this.btnExportDir.Text = "Select";
			this.btnExportDir.UseVisualStyleBackColor = true;
			this.btnExportDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbExportDir_DragDrop);
			this.btnExportDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// tbExportDir
			// 
			this.tbExportDir.AllowDrop = true;
			this.tbExportDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbExportDir.Location = new System.Drawing.Point(97, 62);
			this.tbExportDir.Name = "tbExportDir";
			this.tbExportDir.ReadOnly = true;
			this.tbExportDir.Size = new System.Drawing.Size(477, 19);
			this.tbExportDir.TabIndex = 3;
			this.tbExportDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbExportDir_DragDrop);
			this.tbExportDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// combCodec1
			// 
			this.combCodec1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combCodec1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.combCodec1.FormattingEnabled = true;
			this.combCodec1.Items.AddRange(new object[] {
            "Quicktime Animation",
            "H.264",
            "Quicktime Prores Proxy",
            "Quicktime Prores LT"});
			this.combCodec1.Location = new System.Drawing.Point(316, 18);
			this.combCodec1.MOVI_CODEC = SquenceToMovie.MOVIE_CODEC.QTRLE;
			this.combCodec1.Name = "combCodec1";
			this.combCodec1.Size = new System.Drawing.Size(182, 24);
			this.combCodec1.TabIndex = 6;
			// 
			// combFrameRate1
			// 
			this.combFrameRate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combFrameRate1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.combFrameRate1.FormattingEnabled = true;
			this.combFrameRate1.FRAME_RATE = SquenceToMovie.FRAME_RATE.Fps24;
			this.combFrameRate1.Items.AddRange(new object[] {
            "24fps",
            "23.976fps",
            "30fps",
            "29.97fps"});
			this.combFrameRate1.Location = new System.Drawing.Point(127, 18);
			this.combFrameRate1.Name = "combFrameRate1";
			this.combFrameRate1.Size = new System.Drawing.Size(121, 24);
			this.combFrameRate1.TabIndex = 5;
			// 
			// sequenceFileTo1
			// 
			this.sequenceFileTo1.BtnOpenSeq = this.btnInputfile;
			this.sequenceFileTo1.CmbFrameRate = this.combFrameRate1;
			this.sequenceFileTo1.CombCodec = this.combCodec1;
			this.sequenceFileTo1.ExportDir = "";
			this.sequenceFileTo1.ExportName = ".mov";
			this.sequenceFileTo1.ffmpegPath = "";
			this.sequenceFileTo1.FRAME_RATE = SquenceToMovie.FRAME_RATE.Fps24;
			this.sequenceFileTo1.FRAME_RATE_STR = "24fps";
			this.sequenceFileTo1.IsSound = false;
			this.sequenceFileTo1.MOVIE_CODEC = SquenceToMovie.MOVIE_CODEC.QTRLE;
			this.sequenceFileTo1.MOVIE_CODEC_STR = "Quicktime Animation";
			this.sequenceFileTo1.SequenceFile = "";
			this.sequenceFileTo1.SoundFile = "";
			this.sequenceFileTo1.SrcFile = "";
			this.sequenceFileTo1.TextBox_ExportName = this.tbExportName;
			this.sequenceFileTo1.TextBox_Seq = this.tbInputFile;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 351);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gpInputfile);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(40000, 390);
			this.MinimumSize = new System.Drawing.Size(620, 390);
			this.Name = "Form1";
			this.Text = "連番ファイルをムービーへ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gpInputfile.ResumeLayout(false);
			this.gpInputfile.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private SequenceFileTo sequenceFileTo1;
		private System.Windows.Forms.Button btnInputfile;
		private System.Windows.Forms.TextBox tbInputFile;
		private System.Windows.Forms.GroupBox gpInputfile;
		private CombFrameRate combFrameRate1;
		private CombCodec combCodec1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbIsSound;
		private System.Windows.Forms.Button btnSound;
		private System.Windows.Forms.TextBox tbSound;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.TextBox tbExportName;
		private System.Windows.Forms.Button btnExportDir;
		private System.Windows.Forms.TextBox tbExportDir;
	}
}

