internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Atama Ve İşlemli Atama Operatorleri *****");
        //Atama Ve İşlemli Atama
        int x = 3;
        int y = 3;
        y = y+2;    //İşlemli Atama 
        Console.WriteLine(y);
        y += 2;    // İşlemli Atama  Bu iki Yazım Şekli Aynı İşlemi Yapıyorlar
        Console.WriteLine(y);
        y/=1;
        Console.WriteLine(y);
        x *=2;
        Console.WriteLine(x);

        Console.WriteLine("***** Mantıksal Operatorler *****");
        //Mantıksal Operatorler
        // ||, &&, !  --> Veya, Ve, Degil

        bool isSuccess = true;        //isSuccess ->Başarılı
        bool isCompleted = false;    // isCompleted ->Tamamlandı

        if(isSuccess && isCompleted)
           Console.WriteLine("Perfekt!");
    
        if(isSuccess || isCompleted)
           Console.WriteLine("Great!");

        if(isSuccess && !isCompleted)
           Console.WriteLine("Fine!");
           
        Console.WriteLine("***** İlişkisel Operatorler *****"); 
        //İlişkisel Operatorler
        //<, >, <=, >=, !=

        int a = 3;
        int b = 4;
        bool sonuc = a<b;

        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);

        Console.WriteLine("***** Aritmetik Operatorler *****");
        // *, /, -, +
        int sayı1 = 10;
        int sayı2 = 5;
        int sonuc1 = sayı1/sayı2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayı1*sayı2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayı1+sayı2;
        Console.WriteLine(sonuc1);
        sonuc1 = ++sayı1;           //Bende çalışmadı öğretici kendikini düzeltebildi ama benim olmadı 
        Console.WriteLine(sonuc1);

        // % : Mod alır  (operator buda)
        int sonuc2 = 20%3;
        Console.WriteLine(sonuc2);
         
    }
}