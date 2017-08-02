namespace MyApp.Server.App_Start
{
  using AutoMapper;
  using MyApp.Models;
  using MyApp.Server.Models.ViewModels;
  using System;

  public static class MapperConfig
	{
		public static void Configure()
		{
			ConfigureMapper();
		}

		private static void ConfigureMapper()
		{
			Mapper.Initialize(cfg =>
			{
        cfg.CreateMap<Electrometer, ConciseElectrometerViewModel>()
            .ForMember(model => model.Model, opt => opt.MapFrom(src => src.Model.Replace(".Schneider", "")));

        cfg.CreateMap<HourlyRecord, ShortHourRecordViewModel>()
            .ForMember(model => model.ActiveEnergy, opt => opt.MapFrom(src => Math.Round(src.ActiveEnergy, 3)))
            .ForMember(model => model.ReactiveEnergy, opt => opt.MapFrom(src => Math.Round(src.ReactiveEnergy, 3)))
            .ForMember(model => model.KW, opt => opt.MapFrom(src => Math.Round(src.KW, 3)))
            .ForMember(model => model.KVA, opt => opt.MapFrom(src => Math.Round(src.KVA, 3)))
            .ForMember(model => model.DateTime, opt => opt.MapFrom(src => src.DateTime.ToString("dd-MM-yyyy HH:mm")));

        cfg.CreateMap<Electrometer, DetailedElectrometerViewModel>()
            .ForMember(model => model.Model, opt => opt.MapFrom(src => src.Model.Replace("Schneider.", "")));

        cfg.CreateMap<Electrometer, ElectrometerModel>()
            .ForMember(model => model.Name, opt => opt.MapFrom(src => src.Model));

        cfg.CreateMap<Electrometer, ElectrometerConnectionType>()
            .ForMember(model => model.Name, opt => opt.MapFrom(src => src.ConnectionType));
			});
		}
	}
}