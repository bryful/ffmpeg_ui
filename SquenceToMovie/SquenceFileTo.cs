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
	public class SquenceFileTo : Component
	{
		private string m_Src = "";
		public string Src
		{
			get { return m_Src; }
			set { SetSquenceFile(value); }
		}
		private string m_Node = "";

		private int m_SrcCount = 0;
		public int SrcCount { get { return m_SrcCount; } }
		private int m_SrcStart = 0;
		public int SrcStart { get { return m_SrcStart; } }
		private int m_SrcLast = 0;
		public int SrcLast { get { return m_SrcLast; } }

		private string m_SoundFile = "";
		public string SoundFile
		{
			get { return m_SoundFile; }
			set
			{
				m_SoundFile = "";
				if (File.Exists(value) == true)
				{
					string ext = Path.GetExtension(value).ToLower();
					if( (ext==".wav")||(ext==".aif")||(ext==".aiff"))
					{
						m_SoundFile = value;
					}

				}

			}
		}



		private string[] SplitFileName(string s)
		{
			if (s == "") return new string[0];
			string[] ret = new string[4];
			FileInfo fi = new FileInfo(s);
			if(fi.Exists==false) return  new string[0];

			ret[0] = fi.DirectoryName;
			ret[3] = fi.Extension;
			if (ret[3].Length > 0)
			{
				if (ret[3][0] != '.') ret[3] = "." + ret[3];
			}

			string nd = Path.GetFileNameWithoutExtension(fi.Name);
			int idx = -1;

			for (int i = nd.Length-1;i>=0;i--)
			{
				char c = nd[i];
				if ((c < '0') || (c > '9'))
				{
					idx = i;
					break;
				}
			}
			if(idx == nd.Length - 1)
			{
				ret[1] = nd;
				ret[2] = "";
			}else if (idx == -1)
			{
				ret[1] = "";
				ret[2] = nd;
			}
			else
			{
				ret[1] = nd.Substring(0,idx+1);
				ret[2] = nd.Substring(idx+1);

			}
			return ret;
		}

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
		public bool SetSquenceFile(string s)
		{
			bool ret = false;
			if (Directory.Exists(s) == true)
			{
				s = FileInFolder(s);
				if (s == "") return ret;
			}

			FileInfo fi = new FileInfo(s);
			if (fi.Exists == false) return ret;
			string [] target = SplitFileName(fi.FullName);
			if ((target.Length<=0)||(target[1]=="")||(target[2]=="")) return ret;

			IEnumerable<string> files= Directory.EnumerateFiles(target[0], target[1] + "*" + target[3],SearchOption.TopDirectoryOnly);
			m_SrcCount = files.Count<string>();

			string s0 = files.First<string>().ToString();
			string s1 = files.Last<string>().ToString();
			string[] sa0 = SplitFileName(s0);
			string[] sa1 = SplitFileName(s1);
			m_SrcStart = int.Parse(sa0[2]);
			m_SrcLast = int.Parse(sa1[2]);

			m_Src = target[1] + String.Format("%0{0}d",target[2].Length) + target[3];
			m_Src = Path.Combine(target[0], m_Src);
			ret = (m_SrcCount == (m_SrcLast - m_SrcStart + 1));
			return ret;

		}
		public SquenceFileTo()
		{
		}
	}
}
