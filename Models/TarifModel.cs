using System.ComponentModel.DataAnnotations;

namespace Ahtapot_Recipe.Models;

public class TarifModel
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string YemekAdi { get; set; }
    [Required]
    public string Malzemeler { get; set; }
    [Required]
    public string Yapilisi { get; set; }
    public DateTime OlusturulmaTarihi { get; set; }
    public int Olusturan { get; set; }

    public string YemekFoto { get; set; }
}