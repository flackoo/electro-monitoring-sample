namespace MyApp.Data.UnitOfWork
{
	using MyApp.Data.Repositories;
	using MyApp.Models;

	public interface IMyAppData
	{
		IRepository<User> Users { get; }

    IRepository<Electrometer> Electrometers { get; }

    IRepository<HourlyRecord> HourlyRecords { get; }

    IRepository<DailyRecord> DailyRecords { get; }

    IRepository<CurrentRecord> CurrentRecords { get; }

		void SaveChanges();
	}
}