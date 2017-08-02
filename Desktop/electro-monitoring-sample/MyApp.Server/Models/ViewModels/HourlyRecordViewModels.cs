using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Server.Models.ViewModels
{
  public class ShortHourRecordViewModel
  {
    public int Id { get; set; }

    public string DateTime { get; set; }

    public double KW { get; set; }

    public double KVA { get; set; }

    public double ActiveEnergy { get; set; }

    public double ReactiveEnergy { get; set; }
  }
}