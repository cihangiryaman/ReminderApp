using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmApp.Managers;
using AlarmApp.Model.Context;
using AlarmApp.Model.Entities;
using AlarmApp.UserControls;

namespace AlarmApp.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			timer1.Interval = 3_600_000;
			timer1.Start();
			CheckAlarms();
		}

		private void CheckAlarms()
		{
			AlarmManager manager = new AlarmManager();
			List<Alarm> dueAlarms = manager.GetAll().Where(a => a.DueDateTime.Date.AddDays(-3) <= DateTime.Now.Date).ToList();
			manager = null;
			GC.Collect();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			AlarmManager manager = new AlarmManager();
			List<Alarm> alarms = manager.GetAll();
			foreach (Alarm alarm in alarms)
			{
				AlarmUC alarmUc = new AlarmUC();
				alarmUc.Descriptiontxt.Text = alarm.Description;
				//alarmUc.
			}
			manager = null;
			GC.Collect();
		}

		private void Addbtn_Click(object sender, EventArgs e)
		{
			string title = Titletxt.Text == String.Empty ? "Hatırlatıcı" : Titletxt.Text;
			string description = Descriptiontxt.Text;
			string tag = Tagcmb.Text;
			DateTime dueDateTime = DueDatedtp.Value;
			List<int> daysBeforeAlarm = new List<int>();
			try
			{
				if (DaysBeforeAlarmtxt.Text.Contains(","))
					DaysBeforeAlarmtxt.Text.Split(",").ToList().ForEach(d =>
					{
						d = d.Trim();
						daysBeforeAlarm.Add(Convert.ToInt32(d));
					});
				else
					daysBeforeAlarm.Add(Convert.ToInt32(DaysBeforeAlarmtxt.Text));
			}
			catch
			{
				MessageBox.Show("Kaç gün önce hatırlatacağı kısmına yalnızca sayı giriniz ve sayıların arasına virgül koyunuz.", "İşlem Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			AlarmManager manager = new AlarmManager();
			manager.Add(new Alarm
			{
				CreateTime = DateTime.Now,
				DaysBeforeAlarm = daysBeforeAlarm,
				Title = title,
				Description = description,
				DueDateTime = dueDateTime,
				Tags = [tag]
			});

		}

		private void DaysBeforeAlarmtxt_TextChanged(object sender, EventArgs e)
		{//bitmedi. sadece sayı ve virgül girileceğini garanti et buradan.
			if (DaysBeforeAlarmtxt.Text.Contains("0") && DaysBeforeAlarmtxt.Text.Contains("1") && DaysBeforeAlarmtxt.Text.Contains("2") && DaysBeforeAlarmtxt.Text.Contains("3") && DaysBeforeAlarmtxt.Text.Contains("4") && DaysBeforeAlarmtxt.Text.Contains("5") && DaysBeforeAlarmtxt.Text.Contains("6") && DaysBeforeAlarmtxt.Text.Contains("7") && DaysBeforeAlarmtxt.Text.Contains("8") && DaysBeforeAlarmtxt.Text.Contains("9") && DaysBeforeAlarmtxt.Text.Contains(","))
			{

			}
			else
			{

			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			CheckAlarms();//devam et buradan
		}
	}
}
