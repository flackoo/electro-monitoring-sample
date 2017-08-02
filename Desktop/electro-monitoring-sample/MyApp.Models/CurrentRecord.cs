namespace MyApp.Models
{
  using System;
  using System.ComponentModel.DataAnnotations;

  public class CurrentRecord
  {
    [Key]
    public int Id { get; set; }

    //public int ElectrometerId { get; set; }

    public virtual Electrometer Electrometer { get; set; }

    public DateTime DateTime { get; set; }

    public double U1 { get; set; }

    public double U2 { get; set; }

    public double U3 { get; set; }

    public double I1 { get; set; }

    public double I2 { get; set; }

    public double I3 { get; set; }

    public double KW { get; set; }

    public double Kvar { get; set; }

    public double KVA { get; set; }

    public double PowerFactor { get; set; }

    public double Frequency { get; set; }

    public double ActiveEnergy { get; set; }

    public double ReactiveEnergy { get; set; }

    public double ApparentEnergy { get; set; }
  }
}
