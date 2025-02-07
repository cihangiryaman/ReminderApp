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
			Editbtn = new Button();
			Deletebtn = new Button();
			Descriptiontxt = new TextBox();
			DueDatelbl = new Label();
			Taglbl = new Label();
			Titlelbl = new Label();
			SuspendLayout();
			// 
			// Editbtn
			// 
			Editbtn.BackColor = Color.SkyBlue;
			Editbtn.FlatStyle = FlatStyle.Flat;
			Editbtn.Location = new Point(145, 138);
			Editbtn.Name = "Editbtn";
			Editbtn.Size = new Size(122, 34);
			Editbtn.TabIndex = 11;
			Editbtn.Text = "button2";
			Editbtn.UseVisualStyleBackColor = false;
			// 
			// Deletebtn
			// 
			Deletebtn.BackColor = Color.LightCoral;
			Deletebtn.FlatStyle = FlatStyle.Flat;
			Deletebtn.ForeColor = Color.Black;
			Deletebtn.Location = new Point(11, 138);
			Deletebtn.Name = "Deletebtn";
			Deletebtn.Size = new Size(122, 34);
			Deletebtn.TabIndex = 10;
			Deletebtn.Text = "button1";
			Deletebtn.UseVisualStyleBackColor = false;
			// 
			// Descriptiontxt
			// 
			Descriptiontxt.BackColor = Color.FromArgb(192, 255, 192);
			Descriptiontxt.BorderStyle = BorderStyle.FixedSingle;
			Descriptiontxt.Location = new Point(273, 10);
			Descriptiontxt.Multiline = true;
			Descriptiontxt.Name = "Descriptiontxt";
			Descriptiontxt.Size = new Size(345, 154);
			Descriptiontxt.TabIndex = 9;
			// 
			// DueDatelbl
			// 
			DueDatelbl.AutoSize = true;
			DueDatelbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			DueDatelbl.Location = new Point(151, 5);
			DueDatelbl.Name = "DueDatelbl";
			DueDatelbl.Size = new Size(116, 28);
			DueDatelbl.TabIndex = 8;
			DueDatelbl.Text = "06/02/2025";
			// 
			// Taglbl
			// 
			Taglbl.AutoSize = true;
			Taglbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
			Taglbl.Location = new Point(6, 5);
			Taglbl.Name = "Taglbl";
			Taglbl.Size = new Size(104, 28);
			Taglbl.TabIndex = 7;
			Taglbl.Text = "Kredi Kartı";
			// 
			// Titlelbl
			// 
			Titlelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			Titlelbl.Location = new Point(6, 46);
			Titlelbl.Name = "Titlelbl";
			Titlelbl.Size = new Size(261, 92);
			Titlelbl.TabIndex = 6;
			Titlelbl.Text = "label1";
			// 
			// AlarmUC
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 192);
			Controls.Add(Editbtn);
			Controls.Add(Deletebtn);
			Controls.Add(Descriptiontxt);
			Controls.Add(DueDatelbl);
			Controls.Add(Taglbl);
			Controls.Add(Titlelbl);
			Name = "AlarmUC";
			Size = new Size(625, 176);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public Button Editbtn;
		public Button Deletebtn;
		public TextBox Descriptiontxt;
		public Label DueDatelbl;
		public Label Taglbl;
		public Label Titlelbl;
	}
}
