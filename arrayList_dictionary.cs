using System;
using System.Collections;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            //Array
            
            int[] sayilar = new int[5]; //sabit bir kapasiteye sahibiz
            sayilar[0] = 10; //tek bir veri tipi kullanabilriz

            Soru[] sorular = new Soru[5];
            sorular[0] = new Soru();
            

            //Collections(dizilerin daha yetenekli halidir)

                //non-generic collections => object(kapasite tanımlamamıza gerek yoktur,veri tipi tanımlamamız gerekmez)
                ArrayList liste = new ArrayList();

                liste.Add(10);
                liste.Add("Kadir");
                liste.Add(true);
                liste.Add(null);

                var liste2 = new ArrayList() {
                    5,
                    "Ahmet",
                    false,
                    4.5,
                };

                int[] sayilar = {10,20,30};
                liste.AddRange(sayilar); //listenin sonuna elemanları ekler

                var eleman = (int)liste[0];
                var isim = liste[2].ToString;

                liste.Insert(1, "Sadık"); //liste'de 1. index'e Sadık'ı ekledik
                liste.InsertRange(2, liste2); //2. index'ten itibaren liste2'yi ekle

                liste.Remove(null); //remove bulduğu ilk null veri tipine sahip elemanı siler
                liste.RemoveAt(2); //2 numaralı index'i siler
                liste.RemoveRange(2, 3); //2 numaralı index'ten itibaren 3 eleman siler

                foreach (var item in liste)
                {
                    Console.WriteLine(item);
                }
                    
                //generic collections(veri tipi tanımlamamız gerekir)

                //generic list

                List<int> sayilar = new List<int>(); //tanımladığımız veri tipinin dışına çıkamayız

                sayilar.Add(10);
                sayilar.Add(20);

                List<string> isimler = new List<string>() {"kadir","mustafa","tolga"};

                List<Product> urunler = new List<Product>();

                urunler.Add(new Product() {Id = 1, Title = "Redmi 9C", Fiyat = 2700} );
                urunler.Add(new Product() {Id = 2, Title = "Redmi 10C", Fiyat = 3700} );
                urunler.Add(new Product() {Id = 3, Title = "Redmi 11C", Fiyat = 4700} );

                foreach (var urun in urunler) {
                    Console.WriteLine(urun.Title + " " + urun.Fiyat);
                }

                urunler.Insert(urunler.Count, new Product() {Id = 1, Title = "Redmi 12C", Fiyat = 5700} ); //3 numaralı index'ten itibaren değer ekliyoruz

                urunler.RemoveAt(1);
                urunler.Remove(urunler[0]); //remove'da silmek istediğimiz ürünün referansını(adresini) veririz
                
                //dictionary => key-value prensibiyle çalışır,generic bit tipdir

                Dictionary<int, string> plakalar = new Dictionary<int, string>(); //ilk veri tipi key'i, 2. veri tipi value'yi temsil eder

                plakalar.Add(41, "Kocaeli");
                plakalar.Add(23, "Elazığ");
                plakalar.Add(77, "Yalova");

                Dictionary<int, string> sayilar2 = new Dictionary<int, string>() {
                    {1, "Bir"},
                    {2, "İki"},
                    {3, "Üç"}
                };

                Console.WriteLine(plakalar[41]);
                if(plakalar.ContainsKey(61)) {
                    Console.WriteLine(plakalar[61]);
                }

                foreach (var plaka in plakalar) {
                    Console.WriteLine(plaka.Key + " " + plaka.Value);
                }

                //update

                sayilar2[1] = "12";
                sayilar2.Remove(1); //key veririz
                sayilar2.Clear(); //tüm elemanları siler

        }
    }

    class Product {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fiyat { get; set; }
    }
}


