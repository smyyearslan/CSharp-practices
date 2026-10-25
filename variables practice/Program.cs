using System;

class Price
{
    static void Main()
    {
        var kdvOrani = 1.08;
        var UrunA = 5000;
        var UrunB = 6000;


        Console.WriteLine(UrunA * kdvOrani);  //urun A
        Console.WriteLine(UrunB * kdvOrani);  //urun B


        var sayi = 20;
        var urunAdi = "Samsung A27";


        Console.WriteLine(sayi);
        Console.WriteLine(urunAdi);
    }
}

