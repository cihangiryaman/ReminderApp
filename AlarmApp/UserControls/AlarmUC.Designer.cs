namespace AlarmApp.UserControls
{
	partial class AlarmUC
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DueDatelbl = new Label();
			Titlelbl = new Label();
			Descriptionlbl = new Label();
			SuspendLayout();
			// 
			// DueDatelbl
			// 
			DueDatelbl.AutoSize = true;
			DueDatelbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			DueDatelbl.Location = new Point(511, 143);
			DueDatelbl.Name = "DueDatelbl";
			DueDatelbl.Size = new Size(116, 28);
			DueDatelbl.TabIndex = 8;
			DueDatelbl.Text = "06/02/2025";
			// 
			// Titlelbl
			// 
			Titlelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			Titlelbl.Location = new Point(3, 11);
			Titlelbl.Name = "Titlelbl";
			Titlelbl.Size = new Size(261, 92);
			Titlelbl.TabIndex = 6;
			Titlelbl.Text = "label1";
			// 
			// Descriptionlbl
			// 
			Descriptionlbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
			Descriptionlbl.Location = new Point(273, 11);
			Descriptionlbl.Name = "Descriptionlbl";
			Descriptionlbl.Size = new Size(336, 128);
			Descriptionlbl.TabIndex = 12;
			// 
			// AlarmUC
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 192);
			Controls.Add(Descriptionlbl);
			Controls.Add(DueDatelbl);
			Controls.Add(Titlelbl);
			Name = "AlarmUC";
			Size = new Size(625, 176);
			Paint += AlarmUC_Paint;
			Resize += AlarmUC_Resize;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		public Label DueDatelbl;
		public Label Titlelbl;
		public Label Descriptionlbl;
	}
}
