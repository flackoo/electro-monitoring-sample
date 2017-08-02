using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyApp.Server.Models.BindingModels
{
  public class AddElectroBindingModel
  {
    //[Required]
    public string Model { get; set; }

    //[Required]
    public string Name { get; set; }

    //[Required]
    public string DeviceIp { get; set; }

    //[Required]
    public int DevicePort { get; set; }

    //[Required]
    public int DeviceId { get; set; }

    //[Required]
    public string ConnectionType { get; set; }
  }
}