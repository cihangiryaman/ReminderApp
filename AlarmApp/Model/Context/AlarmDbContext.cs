using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmApp.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlarmApp.Model.Context
{
	public class AlarmDbContext:DbContext
	{
		public DbSet<Alarm> Alarms { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite(
				"Data Source=C:\\Users\\Cihangir\\source\\repos\\AlarmApp\\AlarmApp\\Model\\Database.db");
		}
	}
}
