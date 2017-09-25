public class Kişi
{
    public string Ad{get;set;}
    public string Soyad{get;set;}
	
    /*
        Equals Sytem.Object tipinin metodu
        C#'da System.Object tüm sınıfların atası, o nedenle
        Kişi sınıfında da Eeuals metodunu override ederek kendi
        kodumuzu yazabiliriz
    */
    public override bool Equals(object kişi)
    {
        var k = kişi as Kişi;
        return k == null 
            ? false 
            : this.Ad == k.Ad && this.Soyad == k.Soyad;
    }
}

void Main()
{
    var kişi1 = new Kişi{Ad = "Ali", Soyad = "Özgür"};
    var kişi2 = new Kişi{Ad = "Ali", Soyad = "Özgür"};
    var kişi3 = kişi1;
	
    // İçerik eşitliği
    Console.WriteLine("kişi1 == kişi2 : {0}", kişi1.Equals(kişi2));
    // Çıktı : "kişi1 == kişi2 : True"
	
    Console.WriteLine("kişi1 == kişi3 : {0}", kişi1.Equals(kişi3));
    // Çıktı : "kişi1 == kişi3 : True"

    // İşaretçi referansı eşitliği
    Console.WriteLine("kişi1 == kişi2 : {0}", kişi1 == kişi2);
    // Çıktı : "kişi1 == kişi2 : False"
    
    Console.WriteLine("kişi1 == kişi3 : {0}", kişi1 == kişi3);
    // Çıktı : "kişi1 == kişi3 : True"
}