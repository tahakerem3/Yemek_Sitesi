using System.ComponentModel.DataAnnotations;

namespace Ahtapot_Recipe.Models;

public class KullaniciModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Isim { get; set; }

    [Required]
    public string Soyisim { get; set; }

    [EmailAddress]
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Eposta { get; set; }

    [Required]
    public string Sifre { get; set; }
}