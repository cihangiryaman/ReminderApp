using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmApp.Model.Context;
using AlarmApp.Model.Entities;

namespace AlarmApp.Managers
{
	public class AlarmManager
	{
		public async void Add(Alarm alarm)
		{
			using (AlarmDbContext context = new AlarmDbContext())
			{
				await context.Alarms.AddAsync(alarm);
				await context.SaveChangesAsync();
			}
		}

		public async void Delete(int id)
		{
			try
			{
				using (AlarmDbContext context = new AlarmDbContext())
				{
					Alarm alarm = context.Alarms.Where(a => a.Id == id).FirstOrDefault();
					context.Alarms.Remove(alarm);
					await context.SaveChangesAsync();
					MessageBox.Show("Kayıt başarıyla silindi", "İşlem Başarılı", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kayıt silinemedi yeniden deneyiniz.", "İşlem Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public async void Delete(Alarm alarm)
		{
			try
			{
				using (AlarmDbContext context = new AlarmDbContext())
				{
					context.Alarms.Remove(alarm);
					await context.SaveChangesAsync();
					MessageBox.Show("Kayıt başarıyla silindi", "İşlem Başarılı", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kayıt silinemedi yeniden deneyiniz.", "İşlem Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public async void Update(int id, Alarm updatedAlarm)
		{
			try
			{
				using (AlarmDbContext context = new AlarmDbContext())
				{
					Alarm existingAlarm = context.Alarms.Where(a => a.Id == id).FirstOrDefault();
					existingAlarm = updatedAlarm;
					await context.SaveChangesAsync();
					MessageBox.Show("Kayıt başarıyla güncellendi", "İşlem Başarılı", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kayıt güncellenemedi yeniden deneyiniz.", "İşlem Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public async void ChangeVisibility(int id)
		{
			try
			{
				using (AlarmDbContext context = new AlarmDbContext())
				{
					Alarm existingAlarm = context.Alarms.Where(a => a.Id == id).FirstOrDefault();
					existingAlarm.IsVisible = !existingAlarm.IsVisible;
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kayıt güncellenemedi yeniden deneyiniz.", "İşlem Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<Alarm> GetAll()
		{
			try
			{
				using (AlarmDbContext context = new AlarmDbContext())
				{
					List<Alarm> alarms = context.Alarms.ToList();
					context.SaveChanges();
					return alarms;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kayıtlar getirilemedi tarihleri değiştirip yeniden deneyiniz.", "İşlem Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new List<Alarm>();
			}
		}

		public List<Alarm> GetByDate(DateTime beginDate, DateTime endDate)
		{
			try
			{
				using (AlarmDbContext context = new AlarmDbContext())
				{
					List<Alarm> alarms = context.Alarms.Where(a => a.DueDateTime <= endDate).ToList();
					alarms = alarms.Where(a => beginDate <= a.DueDateTime).ToList();
					context.SaveChanges();
					return alarms;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kayıtlar getirilemedi tarihleri değiştirip yeniden deneyiniz.", "İşlem Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new List<Alarm>();
			}
		}
	}
}
