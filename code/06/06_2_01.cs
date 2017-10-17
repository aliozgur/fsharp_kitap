// 06_2_01.cs
public class Program
{
    public static void Main()
    {
        // Değer tipleri
        int x = 42;
        int y = x;

        x = 43;
        
        Console.WriteLine("x = {0}",x);
        Console.WriteLine("y = {0}",y);
        
        int z = 10;
        BirArttırVeEkrandaGöster(z);
        Console.WriteLine("z = {0}",z);

        // Referans tipleri
        
        Öğrenci öğrenci1 = new Öğrenci{Ad="Ad",Soyad="Soyad",Numara=1};
        Öğrenci öğrenci2 = öğrenci1;
        
        öğrenci2.Ad = "Arda";
        öğrenci2.Soyad = "Özgür";
        
        
        Console.WriteLine("öğrenci1 = {0}",öğrenci1);
        Console.WriteLine("öğrenci2 = {0}",öğrenci2);
        
    }

    public static void BirArttırVeEkrandaGöster(int değer)
    {
        değer = değer + 1;
        Console.WriteLine("Bir arttırıldı, değer = {0}",değer);        
    }
}

public class Öğrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Numara{get;set;}    
    
    public override string ToString()
    {
        return Ad + " " + Soyad + " (" + Numara + ")";
    }
}