namespace MyApp.Server.Controllers
{
  using AutoMapper;
  using Models.BagViewModels;
  using Models.BindingModels;
  using Models.ViewModels;
  using MyApp.Data.UnitOfWork;
  using MyApp.Models;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web.Mvc;

  public class ElectrometersController : BaseController
  {
    public ElectrometersController(IMyAppData data) : base(data) { }
    
    [HttpGet]
    public ActionResult Add()
    {
      LoadModelsAndConnTypesInView();

      return View();
    }

    [HttpPost]
    public ActionResult Add(AddElectroBindingModel BindingModel)
    {
      if (!this.ModelState.IsValid)
      {
        LoadModelsAndConnTypesInView();
        return View(BindingModel);
      }

      try
      {
        Electrometer newElectro = new Electrometer
        {
          Name = BindingModel.Name,
          Model = BindingModel.Model,
          IsStopped = false,
          ConnectionType = BindingModel.ConnectionType,
          DeviceId = BindingModel.DeviceId,
          DeviceIp = BindingModel.DeviceIp,
          DevicePort = BindingModel.DevicePort
        };
        this.Data.Electrometers.Add(newElectro);
        this.Data.SaveChanges();

        return RedirectToAction("index", "home", null);
      }
      catch(Exception ex)
      {
        ModelState.AddModelError("", "An error occured");
        return View(BindingModel);
      }
    }

    [HttpGet]
    public ActionResult Manage()
    {
      var electros = this.Data.Electrometers.All();

      return View(Mapper.Map<IEnumerable<ConciseElectrometerViewModel>>(electros));
    }

    [HttpPost]
    public JsonResult Delete(string id)
    {
      Electrometer electro = this.Data.Electrometers.Find(int.Parse(id));
      try
      {
        this.Data.Electrometers.Remove(electro);
        this.Data.SaveChanges();
        return Json(new
        {
          success = true
        });
      }
      catch(Exception ex)
      {
        return Json(new
        {
          success = false,
          message = ex.Message
        });
      }
    }

    [HttpGet]
    public ActionResult Edit(int id)
    {
      var electro = this.Data.Electrometers.Find(id);

      LoadModelsAndConnTypesInView();

      return View(Mapper.Map<DetailedElectrometerViewModel>(electro));
    }

    [HttpPost]
    public ActionResult Edit(int id, DetailedElectrometerViewModel BindingModel)
    {
      Electrometer electro = this.Data.Electrometers.Find(id);
      try
      {
        electro.ConnectionType = BindingModel.ConnectionType;
        electro.Model = BindingModel.Model;
        electro.DeviceId = BindingModel.DeviceId;
        electro.DeviceIp = BindingModel.DeviceIp;
        electro.DevicePort = BindingModel.DevicePort;
        electro.Name = BindingModel.Name;
        this.Data.Electrometers.Update(electro);
        this.Data.SaveChanges();

        return this.RedirectToAction("manage", "electrometers", null);
      }      
      catch(Exception ex)
      {
        return this.View(BindingModel);
      }
      return View(BindingModel);
    }

    private void LoadModelsAndConnTypesInView()
    {
      var models = this.Data.Electrometers.All().GroupBy(el => el.Model, (key, g) => g.FirstOrDefault());
      var connTypes = this.Data.Electrometers.All().GroupBy(el => el.ConnectionType, (key, g) => g.FirstOrDefault());

      this.ViewBag.Models = Mapper.Map<IEnumerable<ElectrometerModel>>(models);
      this.ViewBag.ConnectionTypes = Mapper.Map<IEnumerable<ElectrometerConnectionType>>(connTypes);
    }
  }
}