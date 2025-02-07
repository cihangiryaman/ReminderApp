using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.UserComponents
{
	public class RoundButton : Button
	{
		// Properties for customization
		public int CornerRadius { get; set; } = 20; // Default corner radius
		public Color HoverColor { get; set; } = Color.Gray; // Color when hovered
		public Color NormalColor { get; set; } = Color.LightGray; // Normal color

		public RoundButton()
		{
			this.FlatStyle = FlatStyle.Flat; // Remove default button styling
			this.FlatAppearance.BorderSize = 0; // Remove border
			this.BackColor = NormalColor;
			this.ForeColor = Color.White; // Text color
			this.Size = new Size(100, 40); // Default size
			this.MouseEnter += RoundButton_MouseEnter;
			this.MouseLeave += RoundButton_MouseLeave;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			// Draw rounded rectangle
			using (GraphicsPath path = new GraphicsPath())
			{
				path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Top-left corner
				path.AddArc(this.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90); // Top-right corner
				path.AddArc(this.Width - CornerRadius, this.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90); // Bottom-right corner
				path.AddArc(0, this.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90); // Bottom-left corner
				path.CloseAllFigures();

				this.Region = new Region(path); // Set the button's region to the rounded rectangle
				using (SolidBrush brush = new SolidBrush(this.BackColor))
				{
					e.Graphics.FillPath(brush, path); // Fill the rounded rectangle
				}
			}

			// Draw button text
			using (StringFormat sf = new StringFormat())
			{
				sf.Alignment = StringAlignment.Center;
				sf.LineAlignment = StringAlignment.Center;
				e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.ClientRectangle, sf);
			}
		}

		private void RoundButton_MouseEnter(object sender, EventArgs e)
		{
			this.BackColor = HoverColor; // Change color on hover
			this.Invalidate(); // Redraw the button
		}

		private void RoundButton_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = NormalColor; // Revert to normal color
			this.Invalidate(); // Redraw the button
		}
	}
}
