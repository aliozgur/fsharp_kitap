public class Program
{
    public static void Main()
    {
        int sayaç = 10;
        while(sayaç != 0 )
        {
            Console.WriteLine($"While -> Sayaç = {sayaç}");
            sayaç = sayaç - 1;
        }
        
        sayaç = 10;
        for(;sayaç!=0;)
        {
            Console.WriteLine($"For -> Sayaç = {sayaç}");
            sayaç = sayaç - 1;
		}
        
        var liste = new List<string>{"A","B","C"};
        for(;liste.Count > 0 ;)
        {
            Console.WriteLine($"For -> Liste = {liste[0]}");
            liste.RemoveAt(0);
        }
    }
}