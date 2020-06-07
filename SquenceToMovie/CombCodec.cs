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
	public class CombCodec :ComboBox
	{
		public CombCodec()
		{
			this.DropDownStyle = ComboBoxStyle.DropDownList;

		}
		protected override void InitLayout()
		{
			this.Items.Clear();
			this.Items.AddRange(SequenceFileTo.CodecStr);
			this.SelectedIndex = 0;
		}
		public MOVIE_CODEC MOVI_CODEC
		{
			get
			{
				int si = this.SelectedIndex;
				if ((si < 0) || (si > 3)) si = 0;
				return (MOVIE_CODEC)si;
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
