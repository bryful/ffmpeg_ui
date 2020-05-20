namespace ToH264
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
			this.lbTargetList = new System.Windows.Forms.ListBox();
			this.btnOutput = new System.Windows.Forms.Button();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.cbIsSameDir = new System.Windows.Forms.CheckBox();
			this.btnExec = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numCRF = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numJobCount = new System.Windows.Forms.NumericUpDown();
			this.btnADD = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cbDNxHD = new System.Windows.Forms.CheckBox();
			this.ffmpeg_ctrl1 = new ToH264.Ffmpeg_ctrl();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCRF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numJobCount)).BeginInit();
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
			this.menuStrip1.Size = new System.Drawing.Size(584, 24);
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 500);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(584, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbTargetList
			// 
			this.lbTargetList.AllowDrop = true;
			this.lbTargetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTargetList.FormattingEnabled = true;
			this.lbTargetList.ItemHeight = 12;
			this.lbTargetList.Location = new System.Drawing.Point(12, 92);
			this.lbTargetList.Name = "lbTargetList";
			this.lbTargetList.Size = new System.Drawing.Size(564, 208);
			this.lbTargetList.TabIndex = 4;
			this.lbTargetList.SelectedIndexChanged += new System.EventHandler(this.lbTargetList_SelectedIndexChanged);
			this.lbTargetList.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.lbTargetList.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// btnOutput
			// 
			this.btnOutput.AllowDrop = true;
			this.btnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOutput.Location = new System.Drawing.Point(16, 313);
			this.btnOutput.Name = "btnOutput";
			this.btnOutput.Size = new System.Drawing.Size(75, 23);
			this.btnOutput.TabIndex = 5;
			this.btnOutput.Text = "出力先";
			this.btnOutput.UseVisualStyleBackColor = true;
			this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
			this.btnOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnOutput_DragDrop);
			this.btnOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// tbOutput
			// 
			this.tbOutput.AllowDrop = true;
			this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutput.Location = new System.Drawing.Point(97, 315);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.ReadOnly = true;
			this.tbOutput.Size = new System.Drawing.Size(479, 19);
			this.tbOutput.TabIndex = 6;
			this.tbOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnOutput_DragDrop);
			this.tbOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// cbIsSameDir
			// 
			this.cbIsSameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbIsSameDir.AutoSize = true;
			this.cbIsSameDir.Location = new System.Drawing.Point(39, 342);
			this.cbIsSameDir.Name = "cbIsSameDir";
			this.cbIsSameDir.Size = new System.Drawing.Size(328, 16);
			this.cbIsSameDir.TabIndex = 7;
			this.cbIsSameDir.Text = "ムービーと同じ場所。出力と入力が同じ名前の時は実行しません";
			this.cbIsSameDir.UseVisualStyleBackColor = true;
			// 
			// btnExec
			// 
			this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExec.Location = new System.Drawing.Point(424, 77);
			this.btnExec.Name = "btnExec";
			this.btnExec.Size = new System.Drawing.Size(116, 50);
			this.btnExec.TabIndex = 4;
			this.btnExec.Text = "実行";
			this.btnExec.UseVisualStyleBackColor = true;
			this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cbDNxHD);
			this.groupBox1.Controls.Add(this.numCRF);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.numJobCount);
			this.groupBox1.Controls.Add(this.btnExec);
			this.groupBox1.Location = new System.Drawing.Point(16, 364);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(556, 133);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "H.264 options";
			// 
			// numCRF
			// 
			this.numCRF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numCRF.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numCRF.Location = new System.Drawing.Point(277, 23);
			this.numCRF.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numCRF.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.numCRF.Name = "numCRF";
			this.numCRF.Size = new System.Drawing.Size(157, 26);
			this.numCRF.TabIndex = 6;
			this.numCRF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numCRF.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(20, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(251, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "H.264画質crf (小さいほど奇麗なはず)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(314, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "実行個数";
			// 
			// numJobCount
			// 
			this.numJobCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numJobCount.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numJobCount.Location = new System.Drawing.Point(317, 95);
			this.numJobCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numJobCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numJobCount.Name = "numJobCount";
			this.numJobCount.Size = new System.Drawing.Size(101, 26);
			this.numJobCount.TabIndex = 3;
			this.numJobCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numJobCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnADD
			// 
			this.btnADD.AllowDrop = true;
			this.btnADD.Location = new System.Drawing.Point(16, 63);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(75, 23);
			this.btnADD.TabIndex = 2;
			this.btnADD.Text = "追加";
			this.btnADD.UseVisualStyleBackColor = true;
			this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
			this.btnADD.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.btnADD.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(505, 63);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "削除";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "ffmpeg を使ったエンコードをします。";
			// 
			// cbDNxHD
			// 
			this.cbDNxHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDNxHD.AutoSize = true;
			this.cbDNxHD.Location = new System.Drawing.Point(23, 80);
			this.cbDNxHD.Name = "cbDNxHD";
			this.cbDNxHD.Size = new System.Drawing.Size(168, 16);
			this.cbDNxHD.TabIndex = 10;
			this.cbDNxHD.Text = "線撮用のDNxHDを書き出す。";
			this.cbDNxHD.UseVisualStyleBackColor = true;
			// 
			// ffmpeg_ctrl1
			// 
			this.ffmpeg_ctrl1.AddButton = this.btnADD;
			this.ffmpeg_ctrl1.CBIsDNxHD = this.cbDNxHD;
			this.ffmpeg_ctrl1.CBIsSameDir = this.cbIsSameDir;
			this.ffmpeg_ctrl1.CRF = 18;
			this.ffmpeg_ctrl1.DeleteButton = this.btnDelete;
			this.ffmpeg_ctrl1.IsDNxHD = false;
			this.ffmpeg_ctrl1.IsSameDir = false;
			this.ffmpeg_ctrl1.JobCount = 1;
			this.ffmpeg_ctrl1.NumCRF = this.numCRF;
			this.ffmpeg_ctrl1.NumJobCount = this.numJobCount;
			this.ffmpeg_ctrl1.OutputnBox = this.tbOutput;
			this.ffmpeg_ctrl1.OutputPath = "";
			this.ffmpeg_ctrl1.TargetListBox = this.lbTargetList;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 522);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnADD);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbIsSameDir);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.btnOutput);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lbTargetList);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(600, 500);
			this.Name = "Form1";
			this.Text = "H.264への変換";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCRF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numJobCount)).EndInit();
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
		private System.Windows.Forms.ListBox lbTargetList;
		private System.Windows.Forms.Button btnOutput;
		private System.Windows.Forms.TextBox tbOutput;
		private System.Windows.Forms.CheckBox cbIsSameDir;
		private System.Windows.Forms.Button btnExec;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numJobCount;
		private System.Windows.Forms.Button btnADD;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numCRF;
		private Ffmpeg_ctrl ffmpeg_ctrl1;
		private System.Windows.Forms.CheckBox cbDNxHD;
	}
}

