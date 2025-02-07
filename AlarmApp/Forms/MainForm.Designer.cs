namespace AlarmApp.Forms
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			flowLayoutPanel1 = new FlowLayoutPanel();
			alarmuc1 = new UserControls.AlarmUC();
			alarmuc2 = new UserControls.AlarmUC();
			alarmuc3 = new UserControls.AlarmUC();
			alarmuc4 = new UserControls.AlarmUC();
			groupBox2 = new GroupBox();
			DateFilterpnl = new Panel();
			label7 = new Label();
			EndDatedtp = new DateTimePicker();
			label6 = new Label();
			BeginDatedtp = new DateTimePicker();
			Filterbtn = new Button();
			FilterTypecmb = new ComboBox();
			groupBox1 = new GroupBox();
			Warninglbl = new Label();
			DaysBeforeAlarmtxt = new TextBox();
			label5 = new Label();
			Addbtn = new Button();
			label4 = new Label();
			DueDatedtp = new DateTimePicker();
			Tagcmb = new ComboBox();
			label3 = new Label();
			label2 = new Label();
			Descriptiontxt = new TextBox();
			label1 = new Label();
			Titletxt = new TextBox();
			timer1 = new System.Windows.Forms.Timer(components);
			flowLayoutPanel1.SuspendLayout();
			groupBox2.SuspendLayout();
			DateFilterpnl.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flowLayoutPanel1.Controls.Add(alarmuc1);
			flowLayoutPanel1.Controls.Add(alarmuc2);
			flowLayoutPanel1.Controls.Add(alarmuc3);
			flowLayoutPanel1.Controls.Add(alarmuc4);
			flowLayoutPanel1.Location = new Point(543, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(1281, 1210);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// alarmuc1
			// 
			alarmuc1.Location = new Point(3, 3);
			alarmuc1.Name = "alarmuc1";
			alarmuc1.Size = new Size(627, 182);
			alarmuc1.TabIndex = 0;
			// 
			// alarmuc2
			// 
			alarmuc2.Location = new Point(636, 3);
			alarmuc2.Name = "alarmuc2";
			alarmuc2.Size = new Size(627, 182);
			alarmuc2.TabIndex = 1;
			// 
			// alarmuc3
			// 
			alarmuc3.Location = new Point(3, 191);
			alarmuc3.Name = "alarmuc3";
			alarmuc3.Size = new Size(627, 182);
			alarmuc3.TabIndex = 2;
			// 
			// alarmuc4
			// 
			alarmuc4.Location = new Point(636, 191);
			alarmuc4.Name = "alarmuc4";
			alarmuc4.Size = new Size(627, 182);
			alarmuc4.TabIndex = 3;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(DateFilterpnl);
			groupBox2.Controls.Add(Filterbtn);
			groupBox2.Controls.Add(FilterTypecmb);
			groupBox2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			groupBox2.Location = new Point(12, 746);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(525, 477);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "Filtrele";
			// 
			// DateFilterpnl
			// 
			DateFilterpnl.Controls.Add(label7);
			DateFilterpnl.Controls.Add(EndDatedtp);
			DateFilterpnl.Controls.Add(label6);
			DateFilterpnl.Controls.Add(BeginDatedtp);
			DateFilterpnl.Location = new Point(27, 126);
			DateFilterpnl.Name = "DateFilterpnl";
			DateFilterpnl.Size = new Size(464, 329);
			DateFilterpnl.TabIndex = 12;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 11F);
			label7.Location = new Point(10, 99);
			label7.Name = "label7";
			label7.Size = new Size(102, 30);
			label7.TabIndex = 13;
			label7.Text = "Son Tarih";
			// 
			// EndDatedtp
			// 
			EndDatedtp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
			EndDatedtp.Location = new Point(129, 93);
			EndDatedtp.Name = "EndDatedtp";
			EndDatedtp.Size = new Size(332, 37);
			EndDatedtp.TabIndex = 12;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11F);
			label6.Location = new Point(10, 36);
			label6.Name = "label6";
			label6.Size = new Size(87, 30);
			label6.TabIndex = 11;
			label6.Text = "İlk Tarih";
			// 
			// BeginDatedtp
			// 
			BeginDatedtp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
			BeginDatedtp.Location = new Point(129, 30);
			BeginDatedtp.Name = "BeginDatedtp";
			BeginDatedtp.Size = new Size(332, 37);
			BeginDatedtp.TabIndex = 10;
			// 
			// Filterbtn
			// 
			Filterbtn.BackColor = Color.SteelBlue;
			Filterbtn.FlatStyle = FlatStyle.Flat;
			Filterbtn.ForeColor = SystemColors.Control;
			Filterbtn.Location = new Point(305, 63);
			Filterbtn.Name = "Filterbtn";
			Filterbtn.Size = new Size(186, 42);
			Filterbtn.TabIndex = 11;
			Filterbtn.Text = "Filtrele";
			Filterbtn.UseVisualStyleBackColor = false;
			// 
			// FilterTypecmb
			// 
			FilterTypecmb.Font = new Font("Segoe UI", 11F);
			FilterTypecmb.FormattingEnabled = true;
			FilterTypecmb.Items.AddRange(new object[] { "Tarihe Göre", "Etikete Göre", "Kelimeye Göre" });
			FilterTypecmb.Location = new Point(27, 65);
			FilterTypecmb.Name = "FilterTypecmb";
			FilterTypecmb.Size = new Size(245, 38);
			FilterTypecmb.TabIndex = 7;
			FilterTypecmb.Text = "Tarihe Göre";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(Warninglbl);
			groupBox1.Controls.Add(DaysBeforeAlarmtxt);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(Addbtn);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(DueDatedtp);
			groupBox1.Controls.Add(Tagcmb);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(Descriptiontxt);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(Titletxt);
			groupBox1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(525, 728);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Hatırlatıcı Ekle";
			// 
			// Warninglbl
			// 
			Warninglbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
			Warninglbl.ForeColor = Color.Red;
			Warninglbl.Location = new Point(27, 625);
			Warninglbl.Name = "Warninglbl";
			Warninglbl.Size = new Size(272, 82);
			Warninglbl.TabIndex = 13;
			// 
			// DaysBeforeAlarmtxt
			// 
			DaysBeforeAlarmtxt.BorderStyle = BorderStyle.FixedSingle;
			DaysBeforeAlarmtxt.Font = new Font("Segoe UI", 11F);
			DaysBeforeAlarmtxt.Location = new Point(305, 572);
			DaysBeforeAlarmtxt.Name = "DaysBeforeAlarmtxt";
			DaysBeforeAlarmtxt.Size = new Size(186, 37);
			DaysBeforeAlarmtxt.TabIndex = 12;
			DaysBeforeAlarmtxt.TextChanged += DaysBeforeAlarmtxt_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11F);
			label5.Location = new Point(27, 576);
			label5.Name = "label5";
			label5.Size = new Size(243, 30);
			label5.TabIndex = 11;
			label5.Text = "Kaç Gün Önce Uyaracak";
			// 
			// Addbtn
			// 
			Addbtn.BackColor = Color.SteelBlue;
			Addbtn.FlatStyle = FlatStyle.Flat;
			Addbtn.ForeColor = SystemColors.Control;
			Addbtn.Location = new Point(305, 634);
			Addbtn.Name = "Addbtn";
			Addbtn.Size = new Size(186, 57);
			Addbtn.TabIndex = 10;
			Addbtn.Text = "Ekle";
			Addbtn.UseVisualStyleBackColor = false;
			Addbtn.Click += Addbtn_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11F);
			label4.Location = new Point(27, 502);
			label4.Name = "label4";
			label4.Size = new Size(102, 30);
			label4.TabIndex = 9;
			label4.Text = "Son Tarih";
			// 
			// DueDatedtp
			// 
			DueDatedtp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
			DueDatedtp.Location = new Point(156, 496);
			DueDatedtp.Name = "DueDatedtp";
			DueDatedtp.Size = new Size(335, 37);
			DueDatedtp.TabIndex = 7;
			// 
			// Tagcmb
			// 
			Tagcmb.Font = new Font("Segoe UI", 11F);
			Tagcmb.FormattingEnabled = true;
			Tagcmb.Location = new Point(118, 425);
			Tagcmb.Name = "Tagcmb";
			Tagcmb.Size = new Size(373, 38);
			Tagcmb.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11F);
			label3.Location = new Point(27, 425);
			label3.Name = "label3";
			label3.Size = new Size(66, 30);
			label3.TabIndex = 5;
			label3.Text = "Etiket";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F);
			label2.Location = new Point(27, 155);
			label2.Name = "label2";
			label2.Size = new Size(65, 30);
			label2.TabIndex = 3;
			label2.Text = "İçerik";
			// 
			// Descriptiontxt
			// 
			Descriptiontxt.BorderStyle = BorderStyle.FixedSingle;
			Descriptiontxt.Font = new Font("Segoe UI", 11F);
			Descriptiontxt.Location = new Point(118, 152);
			Descriptiontxt.Multiline = true;
			Descriptiontxt.Name = "Descriptiontxt";
			Descriptiontxt.Size = new Size(373, 231);
			Descriptiontxt.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F);
			label1.Location = new Point(27, 86);
			label1.Name = "label1";
			label1.Size = new Size(67, 30);
			label1.TabIndex = 1;
			label1.Text = "Başlık";
			// 
			// Titletxt
			// 
			Titletxt.BackColor = Color.White;
			Titletxt.BorderStyle = BorderStyle.FixedSingle;
			Titletxt.Font = new Font("Segoe UI", 11F);
			Titletxt.Location = new Point(118, 83);
			Titletxt.Name = "Titletxt";
			Titletxt.Size = new Size(373, 37);
			Titletxt.TabIndex = 0;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(235, 235, 235);
			ClientSize = new Size(1836, 1237);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(flowLayoutPanel1);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Hatırlatıcı Uygulama";
			Load += MainForm_Load;
			flowLayoutPanel1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			DateFilterpnl.ResumeLayout(false);
			DateFilterpnl.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private FlowLayoutPanel flowLayoutPanel1;
		private GroupBox groupBox2;
		private GroupBox groupBox1;
		private TextBox DaysBeforeAlarmtxt;
		private Label label5;
		private Button Addbtn;
		private Label label4;
		private DateTimePicker DueDatedtp;
		private ComboBox Tagcmb;
		private Label label3;
		private Label label2;
		private TextBox Descriptiontxt;
		private Label label1;
		private TextBox Titletxt;
		private ComboBox FilterTypecmb;
		private Button Filterbtn;
		private Panel DateFilterpnl;
		private Label label7;
		private DateTimePicker EndDatedtp;
		private Label label6;
		private DateTimePicker BeginDatedtp;
		private Label Warninglbl;
		private UserControls.AlarmUC alarmuc1;
		private UserControls.AlarmUC alarmuc2;
		private UserControls.AlarmUC alarmuc3;
		private UserControls.AlarmUC alarmuc4;
		private System.Windows.Forms.Timer timer1;
	}
}