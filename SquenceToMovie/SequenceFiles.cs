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

namespace SquenceToMovie
{
	public class FileNameWithFrame
	{
		// ******************************************************************************
		private string m_ParentDir = "";
		/// <summary>
		/// シークエンスファイルの親フォルダ名
		/// </summary>
		public string ParentDir { get { return m_ParentDir; } }
		private string m_Node = "";
		/// <summary>
		/// ファイル名（フレーム数、拡張子なし）
		/// </summary>
		public string Node { get { return m_Node; } }
		private string m_Ext = "";
		/// <summary>
		/// 拡張子
		/// </summary>
		public string Ext { get { return m_Ext; } }
		private string m_FrameStr = "";
		public string FrameStr { get { return m_FrameStr; } }
		private int m_Frame = -1;
		public int Frame
		{
			get
			{
				return m_Frame;
			}
		}

		public string FileName
		{
			get { return m_ParentDir + "\\" + m_Node + m_FrameStr + m_Ext; }
			set
			{
				SetFileName(value);
			}
		}
		private bool m_IsPicture = false;
		public bool IsPicture
		{
			get
			{
				return m_IsPicture;
			}
		}
		private long m_FileSize = 0;
		public long FileSize { get { return m_FileSize; } }
		// ******************************************************************************
		public FileNameWithFrame()
		{
			SetFileName("");
		}

		public FileNameWithFrame(string p = "")
		{
			SetFileName(p);
		}
		public void SetFileName(string p)
		{
			m_ParentDir = "";
			m_Node = "";
			m_FrameStr = "";
			m_Frame = -1;
			m_Ext = "";
			m_IsPicture = false;
			m_FileSize = 0;
			if (p == "") return;
			string[] fn = SplitFileName(p);
			if (fn.Length >= 4)
			{
				m_ParentDir = fn[0];
				m_Node = fn[1];
				m_FrameStr = fn[2];
				m_Frame = int.Parse(m_FrameStr);
				m_Ext = fn[3];
				string e = m_Ext.ToLower();
				m_IsPicture = ((e == ".png") || (e == ".jpg") || (e == ".tga") || (e == ".tif"));
			}

		}

		/// <summary>
		/// ファイル名を ParentDir/Node/フレーム/Extに分割する
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		private string[] SplitFileName(string s)
		{
			m_FileSize = 0;
			if (s == "") return new string[0];
			string[] ret = new string[4];
			FileInfo fi = new FileInfo(s);
			if (fi.Exists == false) return new string[0];

			ret[0] = fi.DirectoryName;
			ret[3] = fi.Extension;
			if (ret[3].Length > 0)
			{
				if (ret[3][0] != '.') ret[3] = "." + ret[3];
			}

			string nd = Path.GetFileNameWithoutExtension(fi.Name);
			int idx = -1;

			for (int i = nd.Length - 1; i >= 0; i--)
			{
				char c = nd[i];
				if ((c < '0') || (c > '9'))
				{
					idx = i;
					break;
				}
			}
			if (idx == nd.Length - 1)
			{
				ret[1] = nd;
				ret[2] = "";
			} else if (idx == -1)
			{
				ret[1] = "";
				ret[2] = nd;
			}
			else
			{
				ret[1] = nd.Substring(0, idx + 1);
				ret[2] = nd.Substring(idx + 1);

			}
			if (ret.Length >= 4)
			{
				m_FileSize = fi.Length;
			}
			return ret;
		}
		
	}


	public class SequenceFiles
	{
		
		private string m_ParentDir = "";
		/// <summary>
		/// シークエンスファイルの親フォルダ名
		/// </summary>
		public string ParentDir { get { return m_ParentDir; } }
		private string m_Node = "";
		/// <summary>
		/// ファイル名（フレーム数、拡張子なし）
		/// </summary>
		public string Node { get { return m_Node; } }
		private string m_Ext = "";
		/// <summary>
		/// 拡張子
		/// </summary>
		public string Ext { get { return m_Ext; } }
		private int m_StartFrame = 0;
		public int StartFrame { get { return m_StartFrame; } }
		private int m_LastFrame = -1;
		public int LastFrame { get { return m_LastFrame; } }
		public int FrameCount { get { return m_LastFrame - m_StartFrame + 1; } }
		public int FileCount { get { return m_Frames.Count; } }
		private int m_FrameStrLength = 0;
		public int FrameStrLength {  get { return m_FrameStrLength; } }
		private List<string> m_Frames = new List<string>();
		private List<string> m_Errers = new List<string>();

		public string Errers
		{
			get { return  string.Join( "\r\n",m_Errers.ToArray()); }
		}

		public string ffmpegFileName
		{
			get
			{
				if ((m_ParentDir == "") || (m_Node == ""))
				{
					return "";
				}
				else
				{
				return Path.Combine( m_ParentDir , m_Node + string.Format("%0{0}d", m_FrameStrLength) + m_Ext);
				}
			}
		}
		public string SrcFile
		{
			get
			{
				if ((m_ParentDir == "") || (m_Node == ""))
				{
					return "";
				}
				else
				{
					return Path.Combine(m_ParentDir , m_Node + m_Frames[0] + m_Ext);
				}
			}
		}
		// *****************************************************************************************
		public SequenceFiles(string p)
		{
			Init();
			Add(p);
		}
		// *****************************************************************************************
		public void Init()
		{
			m_ParentDir = "";
			m_Node = "";
			m_Ext = "";
			m_StartFrame = 0;
			m_LastFrame = -1;
			m_Frames.Clear();
			m_Errers.Clear();
		}
		// *****************************************************************************************
		public bool Add(string n)
		{
			if (n == "") return false;
			FileNameWithFrame fn = new FileNameWithFrame(n);
			if ((fn.FrameStr == "") || (fn.Node=="")) return false;
			if (fn.IsPicture == false) return false;
			if(FrameCount<=0)
			{
				m_ParentDir = fn.ParentDir;
				m_Node = fn.Node;
				m_Ext = fn.Ext;
				m_Frames.Add(fn.FrameStr);
				m_StartFrame = m_LastFrame = fn.Frame;
				m_FrameStrLength = fn.FrameStr.Length;

				return true;
			}
			if( ( m_ParentDir == fn.ParentDir)&&( m_Node == fn.Node)&&(m_Ext == fn.Ext))
			{
				int frm = fn.Frame;
				if (m_LastFrame < frm)
				{
					int fl = fn.FrameStr.Length;
					if (m_FrameStrLength == fl)
					{
						m_LastFrame = frm;
						m_Frames.Add(fn.FrameStr);
						if(fn.FileSize==0)
						{
							m_Errers.Add(fn.FileName + ",filesize Zero");
						}
						return true;
					}
				}
			}
			return false;

		}
		// *****************************************************************************************
		public bool IsError
		{
			get
			{
				bool ret = false;
				ret = (m_Errers.Count > 0);

				if (FileCount != FrameCount)
				{
					ret = true;
				}
				return ret;
			}
		}
		// *****************************************************************************************
	}
}
