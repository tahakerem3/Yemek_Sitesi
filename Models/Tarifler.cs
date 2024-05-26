namespace Ahtapot_Recipe.Models;

public class TarifleriModel
{
    public int Id { get; set; }
    public string YemekAdi { get; set; }
    public string Malzemeler { get; set; }
    public string Yapilisi { get; set; }
    public string OlusturulmaTarihi { get; set; }
    public string Olusturan { get; set; }
}