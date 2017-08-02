namespace MyApp.Server.Controllers
{
	using AutoMapper;
	using Data.UnitOfWork;
	using Models.ViewModels;
	using MyApp.Models;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web.Mvc;

	public class HomeController : BaseController
{	
		public HomeController(IMyAppData data) : base(data) { }

		public ActionResult Index()
		{
      IEnumerable<ConciseElectrometerViewModel> model = Mapper.Map<IEnumerable<ConciseElectrometerViewModel>>(this.Data.Electrometers.All());

			return View(model);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}