public class Kişi
{
    public string Ad{get;set;}
    public string Soyad{get;set;}
}

void Main()
{
    var kişi1 = new Kişi{Ad = "Ali", Soyad = "Özgür"};
    var kişi2 = new Kişi{Ad = "Ali", Soyad = "Özgür"};
    var kişi3 = kişi1;

    Console.WriteLine("kişi1 == kişi2 : {0}", kişi1 == kişi2);
    // Çıktı : "kişi1 == kişi2 : False"
	
    Console.WriteLine("kişi1 == kişi3 : {0}", kişi1 == kişi3);
    // Çıktı : "kişi1 == kişi3 : True"
}