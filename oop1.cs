using System.Collections;

namespace ConsoleApp {  //namespace class ları barındırır, projeye isim verdik
    class Program {  //class oluşturduk ve class'a isim verdik
        static void Main(string[] args) {  //statik metod oluşturduk
            Console.WriteLine("kadir");

            Ogrenci ogr1 = new Ogrenci() {OgrenciNo = "100", AdSoyad = "Kadir Akipek",Sube = "6/N"}; //daha temiz bi şekilde kodladık
            //obje(nesne) oluşturuk, aynı namespace içerisinde olduğumuz için class'lar birbirini gördü
            ogr1.OgrenciNo = "100";
            ogr1.AdSoyad = "Kadir Akipek";
            ogr1.Sube = "6/N";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.OgrenciNo = "200";
            ogr2.AdSoyad = "Mustafa Akipek";
            ogr2.Sube = "6/M";

            Ogrenci ogr3 = new Ogrenci();
            ogr3.OgrenciNo = "300";
            ogr3.AdSoyad = "Kadir Tan";
            ogr3.Sube = "7/A";

            // Console.WriteLine($"{ogr1.OgrenciNo} numaralı öğrencini adı {ogr1.AdSoyad} ve şubesi {ogr1.Sube}");
            // Console.WriteLine($"{ogr2.OgrenciNo} numaralı öğrencini adı {ogr2.AdSoyad} ve şubesi {ogr2.Sube}");
            // Console.WriteLine($"{ogr3.OgrenciNo} numaralı öğrencini adı {ogr3.AdSoyad} ve şubesi {ogr3.Sube}");

            Ogrenci[] ogrenciler = new Ogrenci[3] {ogr1, ogr2, ogr3}; //3 elemanlı bir dizi tanımladık

            // ogrenciler[0] = ogr1;
            // ogrenciler[1] = ogr2;
            // ogrenciler[2] = ogr3;

            
            foreach (var ogrenci in ogrenciler)
            {   //metod tanıladık diye buraya gerek kalmadı
                //Console.WriteLine($"{ogr1.OgrenciNo} numaralı öğrencini adı {ogr1.AdSoyad} ve şubesi {ogr1.Sube}");
                //istersen metodu bir string değişkene atayıp yazdır yada direk yazdır
                Console.WriteLine(ogrenci.BilgileriYazdir());
            }

            // ogr1.BilgileriYazdir();
            // ogr2.BilgileriYazdir();
            // ogr3.BilgileriYazdir();

        }
    }

    class Ogrenci {
        //property = class'taki alt öğelerdir(string,int)
        public string OgrenciNo { get; set; } //prop yaz ve tab yap
        public string AdSoyad { get; set; }
        public string Sube { get; set; }

        /*metods = bi nevi fonksiyon tanımlarız
        geriye değer döndürmeyeceksek void tanımlıyoruz
        döndüreceksek döndüreceğemiz veri tipini yazarız*/
        public string BilgileriYazdir() { 
            //Console.WriteLine($"{this.OgrenciNo} numaralı öğrencini adı {this.AdSoyad} ve şubesi {this.Sube}"); //this ile ilerde tanımlanacak olan nesneyi tanımladık(og1,ogr2,ogr3)
            //istersen döndüreceğimiz bilgiyi bir değişkene atayıp return et yada direk return et
           return $"{this.OgrenciNo} numaralı öğrencini adı {this.AdSoyad} ve şubesi {this.Sube}"; //this ile ilerde tanımlanacak olan nesneyi tanımladık(og1,ogr2,ogr3)
        }
    }
}