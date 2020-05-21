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


namespace ToH264
{

	public enum DNxHD_STYLE
	{
		LB=0,
		HQX
	}
	public class Ffmpeg_ctrl : Component
	{
		private List<string> m_TargetList = new List<string>();

		private readonly string cmdStr = "\"{0}\" -i \"{1}\" -movflags faststart -y -vcodec libx264 -vf format=yuv420p -crf {2} -acodec libmp3lame \"{3}\"";

		private readonly string cmdStrDNxHD ="\"{0}\" -i \"{1}\" -y -c:v dnxhd -vf \"scale=1920:1080,format=yuv422p\" -b:v 90M  -r 23.976 -c:a pcm_s16le \"{2}\"";
		private readonly string cmdStrDNxHD2 ="\"{0}\" -i \"{1}\" -y -c:v dnxhd -vf \"scale=1920:1080,format=yuv422p10le\" -b:v 175M -r 23.976 -c:a pcm_s16le \"{2}\"";

		private DNxHD_STYLE m_DNxHD_STYLE = DNxHD_STYLE.LB;
		public DNxHD_STYLE DNxHD_STYLE
		{
			get { return m_DNxHD_STYLE; }
			set
			{
				if (m_DNxHD_STYLE != value)
				{
					m_DNxHD_STYLE = value;

					if(m_CmpDNxHD!=null)
					{
						if (m_CmpDNxHD.SelectedIndex!= (int)value)
						{
							m_CmpDNxHD.SelectedIndex = (int)value;
						}
					}
				}
			}
		}


		private bool m_IsDNxHD = false;
		public bool IsDNxHD
		{
			get { return m_IsDNxHD; }
			set
			{
				if (m_IsDNxHD != value)
				{
					m_IsDNxHD = value;

					if(m_CBIsDNxHD!=null)
					{
						if (m_CBIsDNxHD.Checked!= value)
						{
							m_CBIsDNxHD.Checked = value;
						}
					}
				}
			}
		}


		private bool m_IsSameDir = false;
		public bool IsSameDir
		{
			get { return m_IsSameDir; }
			set
			{
				if (m_IsSameDir != value)
				{
					m_IsSameDir = value;

					if(m_CBIsSameDir!=null)
					{
						if (m_CBIsSameDir.Checked!= value)
						{
							m_CBIsSameDir.Checked = value;
						}
					}
				}
			}
		}

		private string m_FFMPEG_Path = "";

		private int m_CRF = 12;
		public int CRF
		{
			get { return m_CRF; }
			set
			{
				if (m_CRF!=value)
				{
					m_CRF = value;
					if(m_NumCRF!=null)
					{
						if (m_NumCRF.Value != (decimal)value)
						{
							m_NumCRF.Value = (decimal)value;
						}
					}
				}
			}
		}

		private int m_JobCount = 1;
		public int JobCount
		{
			get { return m_JobCount; }
			set
			{
				if (m_JobCount!=value)
				{
					m_JobCount = value;
					if(m_NumJobCount!=null)
					{
						if (m_NumJobCount.Value != (decimal)value)
						{
							m_NumJobCount.Value = (decimal)value;
						}
					}
				}
			}
		}
		public string FFMPEG_Path
		{
		
			get { return m_FFMPEG_Path; }
		}
		private string m_OutputPath = "";
		public string OutputPath
		{
			get { return m_OutputPath; }
			set
			{
				if (Directory.Exists(value))
				{
					m_OutputPath = value;
					if(m_OutputnBox!=null)
					{
						m_OutputnBox.Text = m_OutputPath;
					}
				}
				else
				{
					m_OutputPath = "";
				}
			}
		}

		public Ffmpeg_ctrl()
		{
			m_FFMPEG_Path = FindFfmpeg();
		}
		// *********************************************************
		private string FindFfmpeg()
		{
			string p = Path.GetDirectoryName(Application.ExecutablePath);
			p = Path.Combine(p, "ffmpeg.exe");
			return p;
		}
		// *********************************************************
		private ListBox m_TargetListBox = null;
		public ListBox TargetListBox
		{
			get { return m_TargetListBox; }
			set
			{
				m_TargetListBox = value;
				if(m_TargetListBox!=null)
				{
					m_TargetListBox.SelectedIndexChanged += M_TargetListBox_SelectedIndexChanged;
				}
			}
		}
		private void M_TargetListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//throw new NotImplementedException();
		}
		// *********************************************************
		private Button m_AddButton = null;
		public Button AddButton
		{
			get { return m_AddButton; }
			set
			{
				m_AddButton = value;
				if(m_AddButton!=null)
				{
					m_AddButton.Click += M_AddButton_Click;
				}
			}
		}
		private void M_AddButton_Click(object sender, EventArgs e)
		{
		}
		// *********************************************************
		private Button m_DeleteButton = null;
		public Button DeleteButton
		{
			get { return m_DeleteButton; }
			set
			{
				m_DeleteButton = value;
				if(m_DeleteButton!=null)
				{
					m_DeleteButton.Click += M_DeleteButton_Click;
				}
			}
		}
		private void M_DeleteButton_Click(object sender, EventArgs e)
		{
			if (m_TargetListBox != null)
			{
				DeleteTarget(m_TargetListBox.SelectedIndex);
			}
	
		}
		// *********************************************************
		private TextBox m_OutputnBox = null;
		public TextBox OutputnBox
		{
			get { return m_OutputnBox; }
			set
			{
				m_OutputnBox = value;
				if(m_OutputnBox!=null)
				{
					m_OutputnBox.Text = m_OutputPath;
				}
			}
		}
		// *********************************************************
		private NumericUpDown m_NumCRF = null;
		public NumericUpDown NumCRF
		{
			get { return m_NumCRF; }
			set
			{
				m_NumCRF = value;
				if(m_NumCRF!=null)
				{
					if (m_NumCRF.Value != (decimal)m_CRF)
					{
						m_NumCRF.Value = (decimal)m_CRF;
					}
					m_NumCRF.ValueChanged += NumCRF_ValueChanged;
				}

			}
		}

		private void NumCRF_ValueChanged(object sender, EventArgs e)
		{
			if(m_CRF != NumCRF.Value)
			{
				m_CRF = (int)NumCRF.Value;
			}
		}
		// *********************************************************
		private NumericUpDown m_NumJobCount = null;
		public NumericUpDown NumJobCount
		{
			get { return m_NumJobCount; }
			set
			{
				m_NumJobCount = value;
				if(m_NumJobCount!=null)
				{
					m_NumJobCount.Minimum = 1;
					m_NumJobCount.Maximum = 8;
					if (m_NumJobCount.Value != (decimal)m_JobCount)
					{
						m_NumJobCount.Value = (decimal)m_JobCount;
					}
					m_NumJobCount.ValueChanged += m_NumJobCount_ValueChanged;
				}

			}
		}

		private void m_NumJobCount_ValueChanged(object sender, EventArgs e)
		{
			if(m_JobCount != (int)m_NumJobCount.Value)
			{
				m_JobCount = (int)m_NumJobCount.Value;
			}
		}
		// *********************************************************
		private CheckBox m_CBIsSameDir = null;
		public CheckBox CBIsSameDir
		{
			get { return m_CBIsSameDir; }
			set
			{
				m_CBIsSameDir = value;
				if(m_CBIsSameDir!=null)
				{
					if (m_CBIsSameDir.Checked != m_IsSameDir)
					{
						m_CBIsSameDir.Checked = m_IsSameDir;
					}
					m_CBIsSameDir.CheckedChanged += M_CBIsSameDir_CheckedChanged;
				}

			}
		}

		private void M_CBIsSameDir_CheckedChanged(object sender, EventArgs e)
		{
			if (m_IsSameDir != m_CBIsSameDir.Checked)
			{
				m_IsSameDir = m_CBIsSameDir.Checked;
			}
		}
		// *********************************************************
		private CheckBox m_CBIsDNxHD = null;
		public CheckBox CBIsDNxHD
		{
			get { return m_CBIsDNxHD; }
			set
			{
				m_CBIsDNxHD = value;
				if(m_CBIsDNxHD!=null)
				{
					if (m_CBIsDNxHD.Checked != m_IsDNxHD)
					{
						m_CBIsDNxHD.Checked = m_IsDNxHD;
					}
					m_CBIsDNxHD.CheckedChanged += M_CBIsDNxHD_CheckedChanged;
				}

			}
		}

		private void M_CBIsDNxHD_CheckedChanged(object sender, EventArgs e)
		{
			if (m_IsDNxHD != m_CBIsDNxHD.Checked)
			{
				m_IsDNxHD = m_CBIsDNxHD.Checked;
			}
		}
		// *********************************************************
		private ComboBox m_CmpDNxHD = null;
		public ComboBox CmpDNxHD
		{
			get { return m_CmpDNxHD; }
			set
			{
				m_CmpDNxHD = value;
				if(m_CmpDNxHD!=null)
				{
					m_CmpDNxHD.Items.Clear();
					m_CmpDNxHD.Items.AddRange(new object[] {
					"1080p DNxHD LB 8bit -コンテ・タイミング撮",
					"1080p DNxHD HQX 10bit -本撮"});

					if (m_CmpDNxHD.SelectedIndex != (int)m_DNxHD_STYLE)
					{
						m_CmpDNxHD.SelectedIndex = (int)m_DNxHD_STYLE;
					}
					m_CmpDNxHD.SelectedIndexChanged += M_CmpDNxHD_SelectedIndexChanged;
				}

			}
		}

		private void M_CmpDNxHD_SelectedIndexChanged(object sender, EventArgs e)
		{
			int v = m_CmpDNxHD.SelectedIndex;
			if (v < 0) v = 0;
			if (m_DNxHD_STYLE != (DNxHD_STYLE)v)
			{
				m_DNxHD_STYLE = (DNxHD_STYLE)v;
			}
		}

		// *********************************************************
		public void ClearTarget()
		{
			m_TargetList.Clear();
			if (m_TargetListBox != null) m_TargetListBox.Items.Clear();
		}
		public void DeleteTarget(int idx)
		{
			if ((idx < 0) || (idx >= m_TargetList.Count)) return;

			m_TargetList.RemoveAt(idx);
			if(m_TargetListBox!=null)
			{
				m_TargetListBox.Items.RemoveAt(idx);

				if (idx >= m_TargetListBox.Items.Count)
				{
					idx = m_TargetListBox.Items.Count - 1;
				}
				m_TargetListBox.SelectedIndex = idx;
			}

		}
		// *********************************************************
		private int FindMovie(string p)
		{
			int ret = -1;
			int cnt = m_TargetList.Count;
			if ((cnt <=0)||(p=="")) return ret;
			for (int i = 0; i < cnt; i++)
			{
				if (string.Equals(p,m_TargetList[i],StringComparison.OrdinalIgnoreCase)==true)
				{
					ret = i;
					break;
				}
				
			}
			return ret;

		}
		// *********************************************************
		public bool AddMovie(string p)
		{
			bool ret = false;
			if (File.Exists(p) == false) return ret;
			string e = Path.GetExtension(p).ToLower();
			if((e==".mov")||(e==".avi")||(e==".mpeg")||(e==".qt"))
			{
				int idx = FindMovie(p);
				if(idx < 0)
				{
					m_TargetList.Add(p);
					if(m_TargetListBox!=null)
					{
						m_TargetListBox.Items.Add(p);
					}
					ret = true;
				}
			}
			return ret;

		}
		// *********************************************************
		private string MakeCmd(string s)
		{
		//private readonly string cmdStr = "\"{0}\" -i \"{1}\" -movflags faststart -y -vcodec libx264 -vf format=yuv420p -crf {2} -acodec libmp3lame \"{3}\"";

		//private readonly string cmdStrDNxHD ="\"{0}\" -i \"{1}\" -c:v dnxhd -vf \"scale=1920:1080,fps=24000/1001,format=yuv422p\" -b:v 90M -c:a pcm_s16le \"{2}\"";
		//private readonly string cmdStrDNxHD2 ="\"{0}\" -i \"{1}\" -c:v dnxhd -vf \"scale=1920:1080,fps=24000/1001,format=yuv422p10le\" -b:v 175M -c:a pcm_s16le \"{2}\"";

			string p = "";

			string n = Path.GetFileNameWithoutExtension(s) + ".mp4";
			if(m_IsDNxHD==true)
			{
				n = Path.GetFileNameWithoutExtension(s) + ".mov";
			}


			if ((m_IsSameDir == true)&&(m_IsDNxHD==false))
			{
				string pp = Path.GetDirectoryName(s);
				n = Path.Combine(pp, n);

			}
			else
			{
				n = Path.Combine(m_OutputPath, n);
			}
			if (m_IsDNxHD == true)
			{
				switch(m_DNxHD_STYLE)
				{
					case DNxHD_STYLE.LB:
						p = string.Format(cmdStrDNxHD, m_FFMPEG_Path, s, n);
						break;
					case DNxHD_STYLE.HQX:
						p = string.Format(cmdStrDNxHD2, m_FFMPEG_Path, s, n);
						break;
				}
			}
			else
			{
				p = string.Format(cmdStr, m_FFMPEG_Path, s, m_CRF, n);
			}
			if (s==n)
			{
				p = "rem " + p;
			}
			return p;

		}
		// *********************************************************
		private string[] MakeBatch()
		{
			int cnt = m_TargetList.Count;
			if (cnt <= 0) return new string[0];
			string[] ret = new string[cnt];
			for (int i=0; i<cnt;i++)
			{
				ret[i] = MakeCmd(m_TargetList[i]);
			}
			return ret;
		}
		// *********************************************************
		public bool Exec()
		{
			bool ret = false;

			if(File.Exists(m_FFMPEG_Path)==false)
			{
				MessageBox.Show("ffmpeg.exeが見つかりません。");
				return ret;
			}


			int cnt = m_TargetList.Count;
			if (cnt <= 0) return ret;
			int cntA = cnt / m_JobCount;

			string[] cmds = MakeBatch();
			List<string> cmd = new List<string>();
			int idx = 0;
			int idx2 = 0;
			string s = "";
			do
			{
				if (s == "") s = "echo off\r\n";
				s += cmds[idx] + "\r\n";
				idx++;
				idx2++;
				if (idx2 >= cntA)
				{
					cmd.Add(s);
					s = "";
					idx2 = 0;
				}


			} while (idx < cnt);
			if (s != "")
			{
				cmd.Add(s);
			}
			for (int i=0; i<cmd.Count;i++)
			{
				string bat = Path.Combine(Path.GetTempPath(), i.ToString("000") + ".bat");
				if (File.Exists(bat)) File.Delete(bat);
				File.WriteAllText(bat, cmd[i], Encoding.GetEncoding("shift_jis"));
				if (File.Exists(bat))
				{
					string ex = "cmd /c" + " \"" + bat + "\""; 

					System.Diagnostics.Process p = new System.Diagnostics.Process();
					p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
					p.StartInfo.Arguments = "/c \"" + ex + "\"";

					//起動
					p.Start();
				}
			}

			return true;

		}

	}
}
