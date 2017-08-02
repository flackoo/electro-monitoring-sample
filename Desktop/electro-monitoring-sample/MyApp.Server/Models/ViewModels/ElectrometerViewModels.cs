using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Server.Models.ViewModels
{
  public class ConciseElectrometerViewModel
  {
    public int Id { get; set; }

    public string Name { get; set; }
    
    public string Model { get; set; }
  }

  public class DetailedElectrometerViewModel
  {
    public int Id { get; set; }

    public string Model { get; set; }
    
    public string Name { get; set; }

    public string DeviceIp { get; set; }

    public int DevicePort { get; set; }

    public int DeviceId { get; set; }

    public string ConnectionType { get; set; }
  }

  public class ElectrometerModel
  {
    public string Name { get; set; }
  }
  
  public class ElectrometerConnectionType
  {
    public string Name { get; set; }
  }
}