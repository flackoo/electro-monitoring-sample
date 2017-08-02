using MyApp.Server.Models.BindingModels;
using MyApp.Server.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Server.Models.BagViewModels
{
  public class AddElectrometerBagViewModel
  {
    public AddElectroBindingModel ElectrometerBindingModel { get; set; }

    public IEnumerable<ElectrometerModel> ElectrometerModels { get; set; }

    public IEnumerable<ElectrometerConnectionType> ElectrometerConnectionTypes { get; set; }
  }
}