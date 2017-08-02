namespace MyApp.Data.Migrations
{
  using Microsoft.AspNet.Identity;
  using Microsoft.AspNet.Identity.EntityFramework;
  using Models;
  using System;
  using System.Data.Entity.Migrations;
  using System.Linq;

  public sealed class Configuration : DbMigrationsConfiguration<MyAppDbContext>
  {
    public Configuration()
    {
      this.AutomaticMigrationsEnabled = true;
      this.AutomaticMigrationDataLossAllowed = true;
    }

    protected override void Seed(MyAppDbContext context)
    {
      if (!context.Roles.Any(r => r.Name == "Admin"))
      {
        var store = new RoleStore<IdentityRole>(context);
        var manager = new RoleManager<IdentityRole>(store);
        var adminRole = new IdentityRole { Name = "UserAdministrator" };

        manager.Create(adminRole);
      }

      if(!context.Users.Any())
      {
        User admin = new User() { UserName = "Admin", FirstName = "Admin", LastName = "Admin", Email = "admin@myapp.com" };
        var store = new UserStore<User>(context);
        var manager = new UserManager<User>(store);
        manager.Create(admin, "adminPass123");
      }

      if (!context.Electrometers.Any())
      {
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "КОМП. 4 Test[kWh]", DeviceId = 1, DeviceIp = "192.168.2.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false, });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "КОМП. 5  [kWh]", DeviceId = 2, DeviceIp = "192.168.2.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "КОТ. 1", DeviceId = 3, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "КОТ. 2", DeviceId = 4, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "МАС.", DeviceId = 5, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "FKS4", DeviceId = 7, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "FKS6", DeviceId = 8, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕКИП", DeviceId = 9, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ОСВ. 1", DeviceId = 10, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ОСВ. 2", DeviceId = 11, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ПАЛЕТ.", DeviceId = 12, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "АДМИН.", DeviceId = 13, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "НОВ 1", DeviceId = 14, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "НОВ 2", DeviceId = 15, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Тунелна пещ  1", DeviceId = 27, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Шатъл 1", DeviceId = 28, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Шатъл 2", DeviceId = 29, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 1", DeviceId = 1, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 3", DeviceId = 3, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 5", DeviceId = 5, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 6", DeviceId = 6, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 7", DeviceId = 7, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 8", DeviceId = 8, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 9", DeviceId = 9, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 10", DeviceId = 10, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 11", DeviceId = 11, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 12", DeviceId = 12, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 13", DeviceId = 13, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 14", DeviceId = 14, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 15", DeviceId = 15, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 16", DeviceId = 16, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 17", DeviceId = 17, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 18", DeviceId = 18, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 19", DeviceId = 19, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 20", DeviceId = 20, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 41", DeviceId = 41, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 42", DeviceId = 42, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "ЕЛ. 43", DeviceId = 43, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM500", Name = "ТРАФО-1", DeviceId = 25, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM500", Name = "ТРАФО-2", DeviceId = 24, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM500", Name = "ТРАФО-3", DeviceId = 26, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.ShniderPM3250_PM3255", Name = "Нова адм. +гипсово", DeviceId = 1, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Изпичане ТП2", DeviceId = 2, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Склад ГП", DeviceId = 3, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Машини ВН", DeviceId = 4, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Глазиране", DeviceId = 5, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Сушене-тунелна", DeviceId = 6, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Сортиране", DeviceId = 7, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Ледотопене", DeviceId = 8, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "КТП 2", DeviceId = 1, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Фоертон 1 РТ1", DeviceId = 2, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Фоертон 2 РТ2", DeviceId = 3, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.SchneiderPM9", Name = "Ново бар.", DeviceId = 4, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.Electrometers.Add(new Electrometer { Model = "Schneider.WAGOSimulator", Name = "WAGO", DeviceId = 1, DeviceIp = "192.1682.13", DevicePort = 50000, ConnectionType = "Modbus_RTU_Over_TCP", IsStopped = false });
        context.SaveChanges();
      }

      if (context.HourlyRecords.Count() < 2)
      {
        Electrometer electro = context.Electrometers.FirstOrDefault(el => el.Id == 3);
        var testRecord = new HourlyRecord()
        {
          Electrometer = electro,
          I1 = 88.16,
          I2 = 117.45,
          I3 = 119.65,
          U1 = 227.4,
          U2 = 228.3,
          U3 = 228.4,
          DateTime = DateTime.Now,
          Frequency = 50,
          PowerFactor = 0.88,
          KVA = 81.46,
          Kvar = 8.99,
          KW = 72.07,
          ActiveEnergy = 351.12,
          ReactiveEnergy = 501.019,
          ApparentEnergy = 400.59
        };

        electro.HourlyRecords.Add(testRecord);

        context.SaveChanges();

        for (int i = 0; i < 250; i++)
        {
          HourlyRecord lastRecord = context.HourlyRecords.OrderByDescending(rec => rec.Id).Take(1).Single();
          testRecord = new HourlyRecord()
          {
            Electrometer = electro,
            DateTime = DateTime.Now.AddHours(i),
            KVA = lastRecord.KVA + (i + 1) / 0.8,
            I1 = i % 2 == 0 ? lastRecord.I1 + 1 : lastRecord.I1 - 1,
            I2 = i % 2 == 0 ? lastRecord.I2 + 1 : lastRecord.I2 - 1,
            I3 = i % 2 == 0 ? lastRecord.I3 + 1 : lastRecord.I3 - 1,
            U1 = i % 2 == 0 ? lastRecord.U1 + 1 : lastRecord.I1 - 1,
            U2 = i % 2 == 0 ? lastRecord.U2 + 1 : lastRecord.U2 - 1,
            U3 = i % 2 == 0 ? lastRecord.U3 + 1 : lastRecord.U3 - 1,
            Frequency = i % 2 == 0 ? lastRecord.Frequency + i / 3 : lastRecord.Frequency - i / 2,
            Kvar = lastRecord.Kvar + i / 1.2,
            PowerFactor = lastRecord.PowerFactor,
            KW = lastRecord.KVA + i / 1.1,
            ActiveEnergy = lastRecord.ActiveEnergy + i / 1.2,
            ReactiveEnergy = lastRecord.ReactiveEnergy + i / 1.2,
            ApparentEnergy = lastRecord.ApparentEnergy + i / 1.2
          };

          electro.HourlyRecords.Add(testRecord);
        }
      }
    }
  }
}