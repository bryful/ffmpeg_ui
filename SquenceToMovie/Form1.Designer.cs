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
			this.btnInputFile = new System.Windows.Forms.Button();
			this.tbInputFile = new System.Windows.Forms.TextBox();
			this.cbIsSound = new System.Windows.Forms.CheckBox();
			this.tbSoundFile = new System.Windows.Forms.TextBox();
			this.btnAudioFile = new System.Windows.Forms.Button();
			this.cmbCordec = new System.Windows.Forms.ComboBox();
			this.tbOutputDir = new System.Windows.Forms.TextBox();
			this.btnOutputDir = new System.Windows.Forms.Button();
			this.cmbFps = new System.Windows.Forms.ComboBox();
			this.gbRenban = new System.Windows.Forms.GroupBox();
			this.gbSound = new System.Windows.Forms.GroupBox();
			this.gbOutput = new System.Windows.Forms.GroupBox();
			this.tbOutputName = new System.Windows.Forms.TextBox();
			this.btnExec = new System.Windows.Forms.Button();
			this.squenceFileTo1 = new SquenceToMovie.SquenceFileTo();
			this.menuStrip1.SuspendLayout();
			this.gbRenban.SuspendLayout();
			this.gbSound.SuspendLayout();
			this.gbOutput.SuspendLayout();
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 319);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(604, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// btnInputFile
			// 
			this.btnInputFile.AllowDrop = true;
			this.btnInputFile.Location = new System.Drawing.Point(10, 30);
			this.btnInputFile.Name = "btnInputFile";
			this.btnInputFile.Size = new System.Drawing.Size(75, 23);
			this.btnInputFile.TabIndex = 2;
			this.btnInputFile.Text = "選択";
			this.btnInputFile.UseVisualStyleBackColor = true;
			this.btnInputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbInputFile_DragDrop);
			this.btnInputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// tbInputFile
			// 
			this.tbInputFile.AllowDrop = true;
			this.tbInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbInputFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbInputFile.Location = new System.Drawing.Point(110, 30);
			this.tbInputFile.Name = "tbInputFile";
			this.tbInputFile.Size = new System.Drawing.Size(457, 23);
			this.tbInputFile.TabIndex = 3;
			this.tbInputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbInputFile_DragDrop);
			this.tbInputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// cbIsSound
			// 
			this.cbIsSound.AllowDrop = true;
			this.cbIsSound.AutoSize = true;
			this.cbIsSound.Location = new System.Drawing.Point(10, 18);
			this.cbIsSound.Name = "cbIsSound";
			this.cbIsSound.Size = new System.Drawing.Size(128, 16);
			this.cbIsSound.TabIndex = 4;
			this.cbIsSound.Text = "音声ファイルをアペンド";
			this.cbIsSound.UseVisualStyleBackColor = true;
			this.cbIsSound.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbIsSound_DragDrop);
			this.cbIsSound.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// tbSoundFile
			// 
			this.tbSoundFile.AllowDrop = true;
			this.tbSoundFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSoundFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbSoundFile.Location = new System.Drawing.Point(110, 43);
			this.tbSoundFile.Name = "tbSoundFile";
			this.tbSoundFile.Size = new System.Drawing.Size(457, 23);
			this.tbSoundFile.TabIndex = 6;
			this.tbSoundFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbIsSound_DragDrop);
			this.tbSoundFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// btnAudioFile
			// 
			this.btnAudioFile.AllowDrop = true;
			this.btnAudioFile.Location = new System.Drawing.Point(10, 43);
			this.btnAudioFile.Name = "btnAudioFile";
			this.btnAudioFile.Size = new System.Drawing.Size(75, 23);
			this.btnAudioFile.TabIndex = 5;
			this.btnAudioFile.Text = "Audio";
			this.btnAudioFile.UseVisualStyleBackColor = true;
			this.btnAudioFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbIsSound_DragDrop);
			this.btnAudioFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// cmbCordec
			// 
			this.cmbCordec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCordec.FormattingEnabled = true;
			this.cmbCordec.Items.AddRange(new object[] {
            "Quicktime アニメーション圧縮(*.mov)",
            "Quicktime prores LB(*.mov)",
            "Quicktime prores proxy(*.mov)",
            "H.246(*.mp4)"});
			this.cmbCordec.Location = new System.Drawing.Point(204, 98);
			this.cmbCordec.Name = "cmbCordec";
			this.cmbCordec.Size = new System.Drawing.Size(201, 20);
			this.cmbCordec.TabIndex = 7;
			// 
			// tbOutputDir
			// 
			this.tbOutputDir.AllowDrop = true;
			this.tbOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutputDir.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbOutputDir.Location = new System.Drawing.Point(110, 29);
			this.tbOutputDir.Name = "tbOutputDir";
			this.tbOutputDir.Size = new System.Drawing.Size(457, 23);
			this.tbOutputDir.TabIndex = 9;
			this.tbOutputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// btnOutputDir
			// 
			this.btnOutputDir.AllowDrop = true;
			this.btnOutputDir.Location = new System.Drawing.Point(9, 31);
			this.btnOutputDir.Name = "btnOutputDir";
			this.btnOutputDir.Size = new System.Drawing.Size(75, 23);
			this.btnOutputDir.TabIndex = 8;
			this.btnOutputDir.Text = "OutputDir";
			this.btnOutputDir.UseVisualStyleBackColor = true;
			this.btnOutputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// cmbFps
			// 
			this.cmbFps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFps.FormattingEnabled = true;
			this.cmbFps.Items.AddRange(new object[] {
            "24fps",
            "23.976fps",
            "30fps",
            "29.97fps"});
			this.cmbFps.Location = new System.Drawing.Point(110, 98);
			this.cmbFps.Name = "cmbFps";
			this.cmbFps.Size = new System.Drawing.Size(88, 20);
			this.cmbFps.TabIndex = 10;
			// 
			// gbRenban
			// 
			this.gbRenban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbRenban.Controls.Add(this.btnInputFile);
			this.gbRenban.Controls.Add(this.tbInputFile);
			this.gbRenban.Location = new System.Drawing.Point(12, 27);
			this.gbRenban.Name = "gbRenban";
			this.gbRenban.Size = new System.Drawing.Size(579, 72);
			this.gbRenban.TabIndex = 11;
			this.gbRenban.TabStop = false;
			this.gbRenban.Text = "元連番ファイル";
			// 
			// gbSound
			// 
			this.gbSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbSound.Controls.Add(this.cbIsSound);
			this.gbSound.Controls.Add(this.btnAudioFile);
			this.gbSound.Controls.Add(this.tbSoundFile);
			this.gbSound.Location = new System.Drawing.Point(12, 105);
			this.gbSound.Name = "gbSound";
			this.gbSound.Size = new System.Drawing.Size(579, 72);
			this.gbSound.TabIndex = 12;
			this.gbSound.TabStop = false;
			this.gbSound.Text = "音声ファイル";
			// 
			// gbOutput
			// 
			this.gbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbOutput.Controls.Add(this.tbOutputName);
			this.gbOutput.Controls.Add(this.btnExec);
			this.gbOutput.Controls.Add(this.cmbCordec);
			this.gbOutput.Controls.Add(this.btnOutputDir);
			this.gbOutput.Controls.Add(this.cmbFps);
			this.gbOutput.Controls.Add(this.tbOutputDir);
			this.gbOutput.Location = new System.Drawing.Point(13, 183);
			this.gbOutput.Name = "gbOutput";
			this.gbOutput.Size = new System.Drawing.Size(579, 133);
			this.gbOutput.TabIndex = 13;
			this.gbOutput.TabStop = false;
			this.gbOutput.Text = "出力";
			// 
			// tbOutputName
			// 
			this.tbOutputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutputName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbOutputName.Location = new System.Drawing.Point(109, 58);
			this.tbOutputName.Name = "tbOutputName";
			this.tbOutputName.Size = new System.Drawing.Size(284, 23);
			this.tbOutputName.TabIndex = 12;
			// 
			// btnExec
			// 
			this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExec.Location = new System.Drawing.Point(406, 58);
			this.btnExec.Name = "btnExec";
			this.btnExec.Size = new System.Drawing.Size(160, 60);
			this.btnExec.TabIndex = 11;
			this.btnExec.Text = "実行";
			this.btnExec.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 341);
			this.Controls.Add(this.gbOutput);
			this.Controls.Add(this.gbSound);
			this.Controls.Add(this.gbRenban);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(40000, 380);
			this.MinimumSize = new System.Drawing.Size(620, 380);
			this.Name = "Form1";
			this.Text = "連番ファイルをムービーへ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gbRenban.ResumeLayout(false);
			this.gbRenban.PerformLayout();
			this.gbSound.ResumeLayout(false);
			this.gbSound.PerformLayout();
			this.gbOutput.ResumeLayout(false);
			this.gbOutput.PerformLayout();
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
		private System.Windows.Forms.Button btnInputFile;
		private System.Windows.Forms.TextBox tbInputFile;
		private System.Windows.Forms.CheckBox cbIsSound;
		private System.Windows.Forms.TextBox tbSoundFile;
		private System.Windows.Forms.Button btnAudioFile;
		private System.Windows.Forms.ComboBox cmbCordec;
		private System.Windows.Forms.TextBox tbOutputDir;
		private System.Windows.Forms.Button btnOutputDir;
		private System.Windows.Forms.ComboBox cmbFps;
		private System.Windows.Forms.GroupBox gbRenban;
		private System.Windows.Forms.GroupBox gbSound;
		private System.Windows.Forms.GroupBox gbOutput;
		private System.Windows.Forms.TextBox tbOutputName;
		private System.Windows.Forms.Button btnExec;
		private SquenceFileTo squenceFileTo1;
	}
}

