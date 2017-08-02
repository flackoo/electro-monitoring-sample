namespace MyApp.Data
{
  using Microsoft.AspNet.Identity.EntityFramework;
  using Migrations;
  using Models;
  using System.Data.Entity;

  public class MyAppDbContext : IdentityDbContext<User>
  {
    public MyAppDbContext() : base("ElectroMonitoring", throwIfV1Schema: false)
    {
      Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyAppDbContext, Configuration>());
    }

    public virtual IDbSet<HourlyRecord> HourlyRecords { get; set; }

    public virtual IDbSet<DailyRecord> DailyRecords { get; set; }

    public virtual IDbSet<CurrentRecord> CurrentRecords { get; set; }

    public virtual IDbSet<Electrometer> Electrometers { get; set; }

    public static MyAppDbContext Create()
    {
      return new MyAppDbContext();
    }

    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{       
    //  base.OnModelCreating(modelBuilder);
    //}
  }
}