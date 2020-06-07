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

namespace SquenceToMovie
{
	public enum FRAME_RATE
	{
		Fps24 = 0,
		Fps23_976,
		Fps30,
		Fps29_97

	}
	public enum MOVIE_CODEC
	{
		QTRLE,
		H264,
		PRORES_PROXY,
		PRORES_LT
	}


	public class SequenceFileTo : Component
	{
		static public readonly string[] CodecStr = new string[] { "Quicktime Animation", "H.264",  "Quicktime Prores Proxy", "Quicktime Prores LT" }; 
		static public readonly string[] CodecExt = new string[] { ".mov", ".mp4",  ".mov", ".mov" }; 
		static public readonly string[] FpsStr = new string[] { "24fps", "23.976fps", "30fps", "29.97fps" }; 
		static public readonly string[] FpsOption = new string[] { "24", "23.976", "30", "29.97" }; 
		private string m_ffmpegPath = "";
		public string ffmpegPath
		{
			get { return m_ffmpegPath; }
			set
			{
				if (File.Exists(value) == true)
				{
					string fn = Path.GetFileName(value).ToLower();
					if(fn == "ffmpeg.exe")
					{
						m_ffmpegPath = value;
					}
				}
			}

		}
		/// <summary>
		/// 読み込み対象のファイル
		/// </summary>
		private SequenceFiles m_SequenceFile = new SequenceFiles("");
		public string SequenceFile
		{
			get { return m_SequenceFile.SrcFile; }
			set
			{
				SetSquenceFile(value);
			}
		}
		public int SrcFileCount { get { return m_SequenceFile.FileCount; } }
		public int SrcFrameCount { get { return m_SequenceFile.FrameCount; } }
		public int SrcStart { get { return m_SequenceFile.StartFrame; } }
		public int SrcLast { get { return m_SequenceFile.LastFrame; } }
		public bool IsError { get { return m_SequenceFile.IsError; } }
		public string Src { get { return m_SequenceFile.ffmpegFileName; } }
		public string Errors {  get { return m_SequenceFile.Errers; } }
		private FRAME_RATE m_FRAME_RATE = FRAME_RATE.Fps24;
		public FRAME_RATE FRAME_RATE
		{
			get { return m_FRAME_RATE; }
			set
			{
				int v = (int)value;
				if ((v < 0) || (v > 3)) v = 0;
				FRAME_RATE v2 = (FRAME_RATE)v;
				if (m_FRAME_RATE != v2)
				{
					m_FRAME_RATE = v2;
				}
				if(m_CmbFrameRate!=null)
				{
					if(m_CmbFrameRate.FRAME_RATE != v2)
					{
						m_CmbFrameRate.FRAME_RATE = v2;
					}
				}
			}
		}
		public string FRAME_RATE_STR
		{
			get
			{
				return FpsStr[(int)m_FRAME_RATE];
			}
			set
			{
				if (value == "")
				{
					FRAME_RATE = FRAME_RATE.Fps24;
					return;
				}
				int idx = 0;
				for (int i = 0; i < FpsStr.Length; i++)
				{
					if (FpsStr[i] == value)
					{
						idx = i;
						break;
					}
				}
				FRAME_RATE = (FRAME_RATE)idx;
			}
		}
		public string MOVIE_CODEC_STR
		{
			get
			{
				return CodecStr[(int)m_MOVIE_CODEC];
			}
			set
			{
				if (value == "")
				{
					m_MOVIE_CODEC = MOVIE_CODEC.QTRLE;
					return;
				}
				int idx = 0;
				for (int i = 0; i < CodecStr.Length; i++)
				{
					if (CodecStr[i] == value)
					{
						idx = i;
						break;
					}
				}
				MOVIE_CODEC = (MOVIE_CODEC)idx;
			}
		}
		private MOVIE_CODEC m_MOVIE_CODEC = MOVIE_CODEC.QTRLE;
		public MOVIE_CODEC MOVIE_CODEC
		{
			get { return m_MOVIE_CODEC; }
			set
			{
				int v = (int)value;
				if ((v < 0) || (v > 3)) v = 0;
				MOVIE_CODEC v2 = (MOVIE_CODEC)v;
				if (m_MOVIE_CODEC != v2)
				{
					m_MOVIE_CODEC = v2;
				}
				
				if(m_CombCodec!=null)
				{
					if(m_CombCodec.MOVI_CODEC != v2)
					{
						m_CombCodec.MOVI_CODEC = v2;
					}
				}
				if(m_TextBox_ExportName!=null)
				{
					string fn = ExportName;
					if (m_TextBox_ExportName.Text != fn)
					{
						m_TextBox_ExportName.Text = fn;
					}
				}
			}
		}
		private CombFrameRate m_CmbFrameRate = null;
		public CombFrameRate CmbFrameRate
		{
			get { return m_CmbFrameRate; }
			set
			{
				m_CmbFrameRate = value;
				if(m_CmbFrameRate!=null)
				{
					m_CmbFrameRate.FRAME_RATE = m_FRAME_RATE;
					m_CmbFrameRate.SelectedIndexChanged += M_CmbFrameRate_SelectedIndexChanged;
				}
			}
		}

		private void M_CmbFrameRate_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (m_CmbFrameRate == null) return;
			if (m_FRAME_RATE !=m_CmbFrameRate.FRAME_RATE)
			{
				m_FRAME_RATE = m_CmbFrameRate.FRAME_RATE;
			}
		}
		private CombCodec m_CombCodec = null;
		public CombCodec CombCodec
		{
			get { return m_CombCodec; }
			set
			{
				m_CombCodec = value;
				if(m_CombCodec!=null)
				{
					m_CombCodec.MOVI_CODEC = m_MOVIE_CODEC;
					m_CombCodec.SelectedIndexChanged += M_CombCodec_SelectedIndexChanged;
				}
			}
		}

		private void M_CombCodec_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (m_CombCodec == null) return;
			if (m_MOVIE_CODEC !=m_CombCodec.MOVI_CODEC)
			{
				MOVIE_CODEC = m_CombCodec.MOVI_CODEC;
			}
		}

		private string m_SoundFile = "";
		/// <summary>
		/// 音声ファイル
		/// </summary>
		public string SoundFile
		{
			get { return m_SoundFile; }
			set
			{
				m_SoundFile = "";
				m_IsSound = false;
				if (value != "")
				{
					FileInfo fi = new FileInfo(value);
					if (fi.Exists == true)
					{
						string ext = fi.Extension.ToLower();
						if ((ext == ".wav") || (ext == ".aif") || (ext == ".aiff") || (ext == ".mov") || (ext == ".mp4"))
						{
							m_SoundFile = fi.FullName;
							m_IsSound = true;
						}

					}
				}

			}
		}
		private bool m_IsSound = false;
		public bool IsSound
		{
			get { return m_IsSound; }
			set { m_IsSound = value; }
		}
		private string m_ExportDir = "";
		public string ExportDir
		{
			get { return m_ExportDir; }
			set
			{
				if(Directory.Exists(value)==true)
				{
					m_ExportDir = value;
				}
			}
		}
		private string m_ExportName = "";
		public string ExportName
		{
			get
			{
				
				switch(m_MOVIE_CODEC)
				{
					case MOVIE_CODEC.H264:
						return m_ExportName + ".mp4";
					default:
						return m_ExportName + ".mov";
				}

			}
			set
			{
				m_ExportName = Path.GetFileNameWithoutExtension(value);
			}
		}
		public string ExportFullName
		{
			get { return Path.Combine(ExportDir, ExportName); }
		}
		private TextBox m_TextBox_ExportName = null;
		public TextBox TextBox_ExportName
		{
			get { return m_TextBox_ExportName; }
			set
			{
				m_TextBox_ExportName = value;
				if (m_TextBox_ExportName !=null)
				{
					m_TextBox_ExportName.TextChanged += M_TextBox_ExportName_TextChanged;
				}
			}
		}
		private void M_TextBox_ExportName_TextChanged(object sender, EventArgs e)
		{
			string fn = Path.GetFileNameWithoutExtension(m_TextBox_ExportName.Text);
			if ( m_ExportName != fn)
			{
				m_ExportName = fn;
			}

		}

		/// <summary>
		/// フォルダ内にある画像ファイルを返す。
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		private string FileInFolder(string s)
		{
			IEnumerable<string> files= Directory.EnumerateFiles(s, "*",SearchOption.TopDirectoryOnly);
			foreach ( string f in files)
			{
				string e = Path.GetExtension(f).ToLower();
				if( (e==".png")||(e==".jpg")||(e==".tga")||(e==".tif"))
				{
					return f;
				}
			}
			return "";
		}
		/// <summary>
		/// 連番ファイルを設定する
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public bool SetSquenceFile(string s)
		{
			bool ret = false;
			if (s == "") return ret;
			if (Directory.Exists(s) == true)
			{
				s = FileInFolder(s);
				if (s == "") return ret;
			}
			FileNameWithFrame fn = new FileNameWithFrame(s);

			IEnumerable<string> files= Directory.EnumerateFiles(fn.ParentDir, fn.Node + "*" +fn.Ext,SearchOption.TopDirectoryOnly);
			m_SequenceFile.Init();
			foreach(string file in files)
			{
				m_SequenceFile.Add(file);
			}
			if (m_SequenceFile.IsError==true)
			{

			}
			if (m_ExportDir == "")
			{
				m_ExportDir = Path.GetDirectoryName(fn.ParentDir);
			}
			string nd = DeleteLastChar(m_SequenceFile.Node);
			if (m_ExportName!=nd)
			{
				m_ExportName = nd;
			}
			if(m_TextBox_ExportName!=null)
			{
				string nm = ExportName;
				if (m_TextBox_ExportName.Text != nm)
				{
					m_TextBox_ExportName.Text = nm;
				}
			}
			return ret;

		}
		// ******************************************************************************
		private string DeleteLastChar(string s)
		{
			if (s == "") return s;
			char c = s.Last<char>();
			if ((c == '_') || (c == '-') || (c == '.'))
			{
				s = s.Substring(0, s.Length - 1);
			}
			return s;
		}
		// ******************************************************************************
		public SequenceFileTo()
		{
		}
		// ******************************************************************************
		public bool Exec()
		{
			bool ret = false;
	/*
	 *
ffmpeg.exe -r 24 -i D:\work\movie\IKF61_FCA1_v8\IKF61_FCA1_v8_%%05d.png -i D:\work\movie\IKF61_FCA1_v8.mp4 -vcodec libx264   -pix_fmt yuv420p -crf 10 -r 24 -c:a aac -map 0:v:0 -map 1:a:0 out1.mp4
ffmpeg.exe -r 24 -i D:\work\movie\IKF61_FCA1_v8\IKF61_FCA1_v8_%%05d.png -i D:\work\movie\IKF61_FCA1_v8.mp4 -codec:v prores_ks -profile:v 1 -r 24 -c:a aac -map 0:v:0 -map 1:a:0 out3_prores.mov
ffmpeg.exe -r 24 -i D:\work\movie\IKF61_FCA1_v8\IKF61_FCA1_v8_%%05d.png -i D:\work\movie\IKF61_FCA1_v8.mp4 -codec:v prores_ks -profile:v 0 -r 24 -c:a aac -map 0:v:0 -map 1:a:0 out3_prores0.mov
ffmpeg.exe -r 24 -i D:\work\movie\IKF61_FCA1_v8\IKF61_FCA1_v8_%%05d.png -i D:\work\movie\IKF61_FCA1_v8.mp4 -codec:v prores_ks -profile:v 3 -r 24 -c:a aac -map 0:v:0 -map 1:a:0 out3_prores3.mov
ffmpeg.exe -r 24 -i D:\work\movie\IKF61_FCA1_v8\IKF61_FCA1_v8_%%05d.png -i D:\work\movie\IKF61_FCA1_v8.mp4 -codec:v prores_ks -profile:v 2 -r 24 -c:a aac -map 0:v:0 -map 1:a:0 out3_prores2.mov


ffmpeg.exe -r 24 -i D:\work\movie\IKF61_FCA1_v8\IKF61_FCA1_v8_%%05d.png -i D:\work\movie\IKF61_FCA1_v8.mp4 -thread_queue_size 16 -vcodec qtrle  -r 24 -c:a pcm_s16le -map 0:v:0 -map 1:a:0 out1.mov


	 */ 

			if (m_ffmpegPath == "")
			{
				MessageBox.Show("ffmpeg.exeが登録されていません!");
				return ret;
			}
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = m_ffmpegPath;

			string args = "";
			args += String.Format("-r {0}",FpsOption[(int)m_FRAME_RATE]);
			args += String.Format(" -i {0}",Src);
			if(m_IsSound)
			{
				args += String.Format(" -i {0}", m_SoundFile);
			}
			switch (m_MOVIE_CODEC)
			{
				case MOVIE_CODEC.QTRLE:
					args += " -vcodec qtrle";
					break;
				case MOVIE_CODEC.H264:
					args += " -vcodec libx264 -pix_fmt yuv420p -crf 10";
					break;
				case MOVIE_CODEC.PRORES_LT:
					args += " -vcodec:v prores_ks -profile:v 1";
					break;
				case MOVIE_CODEC.PRORES_PROXY:
					args += " -vcodec:v prores_ks -profile:v 0";
					break;
			}
			args += String.Format(" -r {0}",FpsOption[(int)m_FRAME_RATE]);
			if(m_IsSound)
			{
				if (m_MOVIE_CODEC == MOVIE_CODEC.H264)
				{
					args += " -c:a aac -map 0:v:0 -map 1:a:0";
				}
				else
				{
					args += " -c:a pcm_s16le -map 0:v:0 -map 1:a:0";
				}
			}
			args += " " + Path.Combine(ExportFullName)
			//p.StartInfo.Arguments = "/c \"" + ex + "\"";

			//起動
			p.Start();

			return ret;
		}
	}
}
