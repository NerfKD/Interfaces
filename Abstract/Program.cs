using System;

namespace Abstract
{
    class Program 
    {
        //Abstract - Soyut
        static void Main(string[] args)
        {
            String SinifAdi;
            int SinifNo;
            String SinifAdi2;
            int SinifNo2;
            //Ders sınıfından türetilen Matematik sınıfını üretiyoruz.
            Matematik matematik = new Matematik();
            //Matematik sınıfı üzerinden Ders sınıfında ki soyut ve soyut olmayan iki sınıfıda çağırabiliyoruz.
            SinifAdi = matematik.getAd();
            SinifNo = matematik.getSinifNo();
            //Direkt gene ders sınıfında oluşturduğumuz public olan değişkenleride çağırabiliyoruz.
            SinifAdi2 = matematik.ad;
            SinifNo2 = matematik.sinifNo;

            Console.WriteLine("Sınıf Adı : " + SinifAdi);
            Console.WriteLine("Sınıf No : " + SinifNo);

            //1 gelmesinin sebebi getSınıfno metodu içinde private olan ek değişkenini eklememiz.
            //SinifNo2 direkt Ders sınıfında ki değişkeni çekiyor.
            Console.WriteLine("Sınıf Adı : " + SinifAdi2);
            Console.WriteLine("Sınıf No : " + SinifNo2);
        }
    }

    //Abstract sınıf oluşturuyoruz.
    public abstract class Ders
    {
        //sadece Ders classı içinde kullanılacak bir değişken
        private int ek = 1;
 
        //hem bu classda hemde türetildiği sınıfda kullanılabilen değişkenler.
        public String ad = "12-A " ;
        public int sinifNo = 1;

        //soyut metot - gövdesiz olur.
        public abstract String getAd();
        //soyut olmayan metot - gövdeli olmak zorunda.
        public int getSinifNo()
        {
            return this.sinifNo + ek;
        }

        
    }

    //Matematik sınıfını Ders sınıfından türetiyoruz.
    public class Matematik : Ders
    {
        //soyut metotlar türetildiği sınıfta override edilmek zorundadır.
        public override string getAd()
        {
            //Ders sınıfında ki ad değişkenini geri dönüyoruz.
            return ad;
        }

        

    }

}
