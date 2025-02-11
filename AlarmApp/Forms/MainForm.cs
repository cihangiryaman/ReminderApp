using AlarmApp.Managers;
using AlarmApp.Model.Context;
using AlarmApp.Model.Entities;
using AlarmApp.UserControls;
using System.Security.Claims;

namespace AlarmApp.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			timer1.Interval = 30000;//3_600_000;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Thread thread = new Thread(t =>
			{
				AlarmManager manager = new AlarmManager();
				CheckAlarms().ForEach(a =>
				{
					CreateWindowsNotification(a);
					manager.ChangeVisibility(a.Id);
				});
			});
			thread.Start();
		}

		public void CreateWindowsNotification(Alarm alarm)
		{
			notifyIcon1.Text = alarm.Description;
			notifyIcon1.BalloonTipText = alarm.Description;
			notifyIcon1.BalloonTipTitle = alarm.Title;
			notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
			notifyIcon1.Icon = SystemIcons.Application;
			notifyIcon1.ShowBalloonTip(0);
		}

		private List<Alarm> CheckAlarms()
		{
			AlarmManager manager = new AlarmManager();
			List<Alarm> dueAlarms = manager.GetAll().Where(a => a.DueDateTime.Date >= DateTime.Now.Date).ToList();
			List<Alarm> ringAlarms = new List<Alarm>();
			foreach (Alarm alarm in dueAlarms)
			{
				foreach (int dayBeforeAlarm in alarm.DaysBeforeAlarm)
				{
					if (alarm.DueDateTime.AddDays(-dayBeforeAlarm) < DateTime.Now && alarm.IsVisible)
					{
						ringAlarms.Add(alarm);
						break;
					}
				}
			}
			return ringAlarms;
		}

		private void FillAlarmsPanel()
		{
			AlarmManager manager = new AlarmManager();
			List<Alarm> alarms = manager.GetAll();
			foreach (Alarm alarm in alarms)
			{
				AlarmUC alarmUc = new AlarmUC();
				alarmUc.Titlelbl.Text = alarm.Title;
				alarmUc.Descriptionlbl.Text = alarm.Description;
				alarmUc.DueDatelbl.Text = alarm.DueDateTime.Date.Day + "." + alarm.DueDateTime.Date.Month + "." + alarm.DueDateTime.Date.Year;
				alarmUc.Deletebtn.Click += alarmUC_Deletebtn_Click;
				alarmUc.LinkedAlarm = alarm;
				flowLayoutPanel1.Controls.Add(alarmUc);
			}
		}

		private void alarmUC_Deletebtn_Click(object sender, EventArgs e)
		{
			Button deletebtn = sender as Button;
			AlarmUC alarmUC = deletebtn.Parent as AlarmUC;
			flowLayoutPanel1.Controls.Remove(alarmUC);
			Thread thread = new Thread(t =>
			{
				AlarmManager manager = new AlarmManager();
				manager.Delete(alarmUC.LinkedAlarm);
			});
			thread.Start();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			FillAlarmsPanel();
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
				daysBeforeAlarm.Add(Convert.ToInt32(DaysBeforeAlarmnmrc.Text));

				Thread thread = new Thread(t =>
				{
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
				});
				thread.Start();
			}
			catch
			{
				MessageBox.Show("Eklenemedi, yeniden deneyiniz.", "İşlem Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			flowLayoutPanel1.Controls.Clear();
			FillAlarmsPanel();
		}
	}
}
