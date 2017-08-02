namespace MyApp.Server.Controllers
{
  using AutoMapper;
  using Data.UnitOfWork;
  using Models.ViewModels;
  using MyApp.Models;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web.Mvc;

  public class InquiryController : BaseController
  {
    public InquiryController(IMyAppData data) : base(data) { }
    
    public JsonResult Daily(string id)
    {
      Electrometer electro = this.Data.Electrometers.Find(int.Parse(id));

      return Json(Mapper.Map<IEnumerable<ShortHourRecordViewModel>>(electro.HourlyRecords.Take(25)), JsonRequestBehavior.AllowGet);
    }
  }
}