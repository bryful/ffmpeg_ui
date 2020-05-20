using System;
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
namespace ToH264
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
				string s = pref.GetString("OutputPath", out ok);
				if (ok) ffmpeg_ctrl1.OutputPath = s;
				bool b = pref.GetBool("IsSameDir", out ok);
				if (ok) ffmpeg_ctrl1.IsSameDir = b;
				int v = pref.GetInt("CRF", out ok);
				if (ok) ffmpeg_ctrl1.CRF = v;
				v = pref.GetInt("JobCount", out ok);
				if (ok) ffmpeg_ctrl1.JobCount = v;
				b = pref.GetBool("IsDNxHD", out ok);
				if (ok) ffmpeg_ctrl1.IsDNxHD = b;
				v = pref.GetInt("DNxHD_STYLE", out ok);
				if (ok)
				{
					if (v < 0) v = 0; else if (v > 1) v = 1;
					ffmpeg_ctrl1.DNxHD_STYLE = (DNxHD_STYLE)v;
				}
				


			}
			this.Text = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
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
			pref.SetString("OutputPath", ffmpeg_ctrl1.OutputPath);
			pref.SetBool("IsSameDir", ffmpeg_ctrl1.IsSameDir);
			pref.SetInt("CRF", ffmpeg_ctrl1.CRF);
			pref.SetInt("JobCount", ffmpeg_ctrl1.JobCount);
			pref.SetBool("IsDNxHD", ffmpeg_ctrl1.IsDNxHD);
			pref.SetInt("DNxHD_STYLE", (int)ffmpeg_ctrl1.DNxHD_STYLE);

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
		        e.Effect = DragDropEffects.Copy;
			else
				//ファイル以外は受け付けない
				e.Effect = DragDropEffects.None;
		}
		/// ドラッグ＆ドロップの本体
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			//ここでは単純にファイルをリストアップするだけ
			GetCommand(files);
		}
		//-------------------------------------------------------------
		private void btnOutput_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			if (files.Length > 0)
			{
				foreach (string s in files)
				{
					ffmpeg_ctrl1.OutputPath = s;
					if (ffmpeg_ctrl1.OutputPath != "")
					{
						break;
					}
				}
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
					if (File.Exists(s) == true)
					{
						ffmpeg_ctrl1.AddMovie(s);
					}else if (Directory.Exists(s) == true)
					{
						string[] fl = Directory.GetFiles(s);
						GetCommand(fl);
					}
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

		private void btnExec_Click(object sender, EventArgs e)
		{
			if(ffmpeg_ctrl1.IsSameDir&&ffmpeg_ctrl1.IsDNxHD)
			{
				MessageBox.Show("DNxHD書き出し時は同じフォルダに書き出せません");
				return;
			}

			ffmpeg_ctrl1.Exec();
		}

		private void lbTargetList_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnDelete.Enabled = (lbTargetList.SelectedIndex >= 0);
		}

		private string m_fileNmae = "";
		private void btnADD_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "*.*|*.*";
			if (m_fileNmae != "")
			{
				dlg.InitialDirectory = Path.GetDirectoryName(m_fileNmae);
				dlg.FileName = Path.GetFileName(m_fileNmae);
			}
			else
			{
				dlg.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
			}
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				ffmpeg_ctrl1.AddMovie(dlg.FileName);
				m_fileNmae = dlg.FileName;
			}

		}

		private void btnOutput_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			dlg.Description = "フォルダを指定してください。";
			//デフォルトでDesktop
			dlg.RootFolder = Environment.SpecialFolder.Desktop;
			dlg.SelectedPath = ffmpeg_ctrl1.OutputPath;
			dlg.ShowNewFolderButton = true;

			//ダイアログを表示する
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				ffmpeg_ctrl1.OutputPath = dlg.SelectedPath;
			}
		}

		private void cbDNxHD_CheckedChanged(object sender, EventArgs e)
		{
			bool b = cbDNxHD.Checked;
			cbIsSameDir.Enabled = !b;
			lbCRF.Enabled = !b;
			numCRF.Enabled = !b;
			cmbDNHD.Enabled = b;
		}
	}
}
