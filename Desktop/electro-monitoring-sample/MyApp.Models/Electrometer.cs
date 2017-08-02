namespace MyApp.Models
{
  using System.Collections;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;

  public class Electrometer
  {
    public Electrometer()
    {
      this.HourlyRecords = new HashSet<HourlyRecord>();
    }

    [Key]
    public int Id { get; set; }

    public string Model { get; set; }

    public string Name { get; set; }

    public string DeviceIp { get; set; }

    public int DevicePort { get; set; }

    public int DeviceId { get; set; }

    public string ConnectionType { get; set; }

    public bool IsStopped { get; set; }

    public virtual ICollection<HourlyRecord> HourlyRecords { get; set; }
  }
}
