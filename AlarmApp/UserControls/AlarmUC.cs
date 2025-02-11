using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmApp.Model.Entities;
using AlarmApp.Properties;
using AlarmApp.UserComponents;

namespace AlarmApp.UserControls
{
	public partial class AlarmUC : UserControl
	{
		public RoundButton Deletebtn { get; set; }
		public RoundButton Editbtn { get; set; }
		public Alarm LinkedAlarm { get; set; }

		public AlarmUC()
		{
			InitializeComponent();
			Deletebtn = new RoundButton();
			Deletebtn.BackColor = Color.Tomato;
			Deletebtn.NormalColor = Color.Tomato;
			Deletebtn.HoverColor = Color.OrangeRed;
			Deletebtn.Location = new Point(11, 138);
			Deletebtn.Size = new Size(122, 34);
			Deletebtn.Text = "Sil";
			Editbtn = new RoundButton();
			Editbtn.BackColor = Color.DeepSkyBlue;
			Editbtn.NormalColor = Color.DeepSkyBlue;
			Editbtn.HoverColor = Color.DodgerBlue;
			Editbtn.Location = new Point(145, 138);
			Editbtn.Size = new Size(122, 34);
			Editbtn.Text = "Düzenle";
			this.Controls.Add(Deletebtn);
			this.Controls.Add(Editbtn);
		}

		private int cornerRadius = 40;

		private void RoundCorner(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			using (GraphicsPath path = new GraphicsPath())
			{
				path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
				path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
				path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
				path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
				path.CloseAllFigures();

				this.Region = new Region(path);
				using (SolidBrush brush = new SolidBrush(this.BackColor))
				{
					e.Graphics.FillPath(brush, path);
				}
			}
		}

		private void AlarmUC_Paint(object sender, PaintEventArgs e)
		{
			RoundCorner(e);
		}

		private void AlarmUC_Resize(object sender, EventArgs e)
		{
			this.Invalidate();
		}
	}
}
