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
	public class CombFrameRate :ComboBox
	{
		public CombFrameRate()
		{
			this.DropDownStyle = ComboBoxStyle.DropDownList;

		}
		protected override void InitLayout()
		{
			this.Items.Clear();
			this.Items.AddRange(SequenceFileTo.FpsStr);
			this.SelectedIndex = 0;
		}

		public FRAME_RATE FRAME_RATE
		{
			get
			{
				int si = this.SelectedIndex;
				if ((si < 0) || (si > 3)) si = 0;
				return (FRAME_RATE)si;
			}
			set
			{
				int v = (int)value;
				if (this.SelectedIndex != v)
				{
					if (this.Items.Count > 0)
					{
						this.SelectedIndex = v;
					}
				}
			}
		}
	}
}
