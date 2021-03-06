﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using BRY;

using Codeplex.Data;
/// <summary>
/// 基本となるアプリのスケルトン
/// </summary>
namespace SquenceToMovie
{
	public partial class Form1 : Form
	{
		//-------------------------------------------------------------
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Form1()
		{
			InitializeComponent();

			

		}
		/// <summary>
		/// コントロールの初期化はこっちでやる
		/// </summary>
		protected override void InitLayout()
		{
			base.InitLayout();
		}
		//-------------------------------------------------------------
		/// <summary>
		/// フォーム作成時に呼ばれる
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			//設定ファイルの読み込み
			JsonPref pref = new JsonPref();
			if (pref.Load())
			{
				bool ok = false;
				Size sz = pref.GetSize("Size", out ok);
				if (ok) this.Size = sz;
				Point p = pref.GetPoint("Point", out ok);
				if (ok) this.Location = p;
				string s = pref.GetString("ffmpeg", out ok);
				if (ok) sequenceFileTo1.ffmpegPath = s;
				s = pref.GetString("FrameRate", out ok);
				if (ok) sequenceFileTo1.FRAME_RATE_STR = s;
				s = pref.GetString("Codec", out ok);
				if (ok) sequenceFileTo1.MOVIE_CODEC_STR = s;
				s =   pref.GetString("SequenceFile", out ok);
				if (ok)
				{
					AddInputFile(s);
				}
				s =   pref.GetString("ExportDir", out ok);
				if (ok)
				{
					sequenceFileTo1.ExportDir = s;
					tbExportDir.Text = sequenceFileTo1.ExportDir;
				}
				s =   pref.GetString("SoundFile", out ok);
				if (ok)
				{
					sequenceFileTo1.SoundFile = s;
					tbSound.Text = sequenceFileTo1.SoundFile;
				}
				bool b =   pref.GetBool("IsSound", out ok);
				if (ok)
				{
					sequenceFileTo1.IsSound = b;
					cbIsSound.Checked = sequenceFileTo1.IsSound;
				}

			}
			this.Text = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
			if(sequenceFileTo1.ffmpegPath=="")
			{
				OpenFFmpeg();
			}
		}
		//-------------------------------------------------------------
		/// <summary>
		/// フォームが閉じられた時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			//設定ファイルの保存
			JsonPref pref = new JsonPref();
			pref.SetSize("Size", this.Size);
			pref.SetPoint("Point", this.Location);
			pref.SetString("ffmpeg", sequenceFileTo1.ffmpegPath);
			pref.SetString("FrameRate", sequenceFileTo1.FRAME_RATE_STR);
			pref.SetString("Codec", sequenceFileTo1.MOVIE_CODEC_STR);
			pref.SetString("SequenceFile", sequenceFileTo1.SequenceFile);
			pref.SetString("ExportDir", sequenceFileTo1.ExportDir);
			pref.SetString("SoundFile", sequenceFileTo1.SoundFile);
			pref.SetBool("IsSound", sequenceFileTo1.IsSound);

			pref.Save();

		}
		//-------------------------------------------------------------
		/// <summary>
		/// ドラッグ＆ドロップの準備
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		// *******************************************************************************
		public bool AddInputFile(string s)
		{
			bool ret = false;
			sequenceFileTo1.SetSquenceFile(s);
			if (sequenceFileTo1.Src != "")
			{
				if (sequenceFileTo1.IsError == true)
				{
					MessageBox.Show("ファイル数が足りません!\r\n" + sequenceFileTo1.Errors);
				}
				else
				{
					//bInputFile.Text = sequenceFileTo1.Src;
					tbExportDir.Text = sequenceFileTo1.ExportDir;
					ret = true;
				}
			}
			return ret;

		}
		// *******************************************************************************
		private void tbInputFile_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			foreach(string s in files)
			{
				if (AddInputFile(s) == true)
				{
					break;
				}

			}


		}
		private void btnSound_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			cbIsSound.Checked = false;
			foreach (string s in files)
			{
				sequenceFileTo1.SoundFile = s;
				if(sequenceFileTo1.SoundFile != "")
				{
					tbSound.Text = sequenceFileTo1.SoundFile;
					cbIsSound.Checked = sequenceFileTo1.IsSound;
					break;
				}
			}
		}
		private void tbExportDir_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			string pp = "";
			foreach (string s in files)
			{
				if (File.Exists(s) == true)
				{
					pp = Path.GetDirectoryName(s);
					break;
				}else if (Directory.Exists(s) == true)
				{
					pp = s;
					break;
				}
			}
			if(pp!="")
			{
				sequenceFileTo1.ExportDir = pp;
				tbExportDir.Text = sequenceFileTo1.ExportDir;
			}

		}

		//-------------------------------------------------------------
		/// <summary>
		/// ダミー関数
		/// </summary>
		/// <param name="cmd"></param>
		public void GetCommand(string[] cmd)
		{
			if (cmd.Length > 0)
			{
				foreach (string s in cmd)
				{
					//listBox1.Items.Add(s);
				}
			}
		}
		/// <summary>
		/// メニューの終了
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//-------------------------------------------------------------
		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppInfoDialog.ShowAppInfoDialog();
		}
		private void button1_Click(object sender, EventArgs e)
		{

			JsonPref j = new JsonPref();

			int[] aaa = new int[] { 78, 9, 12 };
			double[] bbb = new double[] { 0.7, 0.01, 0.12 };
			string[] ccc = new string[] { "eee", "sfskjbF", "13" };
			j.SetIntArray("aa", aaa);
			j.SetDoubleArray("bb", bbb);
			j.SetStringArray("cc", ccc);

			MessageBox.Show(j.ToJson());

		}
		public bool OpenFFmpeg()
		{
			bool ret = false;
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "ffmpeg.exe|ffmpeg.exe";
			string fn = sequenceFileTo1.ffmpegPath;
			if (fn=="")
			{
				dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				dlg.FileName = "ffmpeg.exe";
			}
			else
			{
				dlg.InitialDirectory = Path.GetDirectoryName(fn);
				dlg.FileName = Path.GetFileName(fn);

			}
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				sequenceFileTo1.ffmpegPath = dlg.FileName;
				ret = true;
			}

			return ret;
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			sequenceFileTo1.IsSound = cbIsSound.Checked;
			sequenceFileTo1.Exec();
		}






		/*
private void button1_Click(object sender, EventArgs e)
{
	dynamic a = new DynamicJson();
	a.fff = new string[] { "a", "B" };
	a.fff = "12";
	//a.fff = new { aaa=12, ccc="www" };

	MessageBox.Show(a.fff.GetType().ToString());

	JsonPref s = new JsonPref();
	s.AddInt("aaa", 99);
	string ss = s.ToJson();
	MessageBox.Show(ss);
	s.Parse(ss);
	string sss = s.ToJson();
	MessageBox.Show(sss);

	int i = s.GetInt("aaa");
	MessageBox.Show(String.Format("{0}", i));
}
*/
	}
}
