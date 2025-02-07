using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmApp.Model.Entities;

namespace AlarmApp.Managers
{
	public class NotificationManager
	{
		public NotifyIcon CreateWindowsNotification(Alarm alarm)
		{
			NotifyIcon notification = new NotifyIcon();
			notification.BalloonTipText = alarm.Description;
			notification.BalloonTipTitle = alarm.Title;
			notification.BalloonTipIcon = ToolTipIcon.Info;
			notification.Icon = SystemIcons.Application;
			return notification;
		}
	}
}
