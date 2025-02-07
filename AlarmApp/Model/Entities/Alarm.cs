using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.Model.Entities
{
	public class Alarm
	{
		public int Id { get; set; }
		public string Title { get; set; } = "Alarm Başlığı";
		public string Description { get; set; } = "Açıklama";
		public DateTime DueDateTime { get; set; }
		public DateTime CreateTime { get; set; } = DateTime.Now;
		public List<DateTime> UpdateTimes { get; set; } = new List<DateTime>();
		public List<string> Tags { get; set; }
		public List<int> DaysBeforeAlarm { get; set; }
		/// <summary>
		///List<int> of how many hours before the DueDateTime alarm will ring
		/// </summary>
		public bool IsVisible { get; set; } = true;

	}
}
