// 06_1_01.cs
using System;
using System.Collections.Generic;
                    
public class Program
{
    public static void Main()
    {
        var girdi = new List<int>{1,2,3,4,6,7,9,10,12,15,16};        
        // √a
        var sonuç1 = Utils.KareköküOlanlarıVer(girdi);
        // sonuç1 içeriği 1,4,9,16 olur
        
        //∜a
        var sonuç2 = Utils.DördüncüDereceKöküOlanlarıVer(girdi);
        // sonuç2 içeriği [] yani boş liste olur        
    }
}

public static class Utils
{
    private static List<int> _filtrele(List<int> list, Func<float,bool> predicate)
    {
        var result = new List<int>();
        var counter = 0;
        while(counter < list.Count )
        {
            var n = list[counter];
            if(predicate(n))
            {
                result.Add(n);
                list.RemoveAt(counter);
            }
            counter++;
        }
        
        return result;
    }

    public static List<int> KareköküOlanlarıVer(this List<int> list)
    {
        return _filtrele(list, (sayı) => Math.Sqrt(sayı) % 1 == 0);
    }
    
    public static List<int> DördüncüDereceKöküOlanlarıVer(this List<int> list)
    {
        return _filtrele(list, (sayı) => Math.Pow(sayı, (1.0 / 4.0)) % 1 == 0);
    }
}