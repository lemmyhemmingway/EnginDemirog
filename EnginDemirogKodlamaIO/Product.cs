namespace EnginDemirogKodlamaIO;

public class Product
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public double Fiyati { get; set; }
    public string Aciklama { get; set; }


    public override string ToString()
    {
        return $@"{Adi} {Fiyati} {Aciklama}";
    }
}