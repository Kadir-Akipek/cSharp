/*
for döngüsünde sırasıyla
kontrol değişkeni
kontrol mekanizması
değişkenin güncellenmesi
*/

for(var i = 1; i < 20; i++) {
    Console.WriteLine(i);
    i++;
}

//uygulama

int toplam = 0;

for (int i = 1; i <=10; i++) {
    if(i % 2 == 1) {
        toplam += i;
    }
}

Console.WriteLine(toplam);

int toplam = 0;

Console.Write("başlangıç değerini gir");
var start = Convert.ToInt32(Console.ReadLine());

Console.Write("bitiş değerini gir");
var finish = Convert.ToInt32(Console.ReadLine());

Console.Write("artış değerini gir");
var plus = Convert.ToInt32(Console.ReadLine());

for(int i = start; i <= finish; i += plus) {
    toplam += i;
    Console.WriteLine(toplam);
}

string[] isimler = {"kadir","mustafa","tolga","ibrahim"};

for(int i = 0; i < isimler.Length; i++) {
    Console.WriteLine(isimler[i]);
}

int[] sayilar = {1,2,3};

for(int i = 0; i < sayilar.Length; i++) {
    if(sayilar[i] % 3 == 0) {
        Console.WriteLine(sayilar[i]);
    }
}


//while döngüsü

int i = 0;

while (i < 10) {
    Console.WriteLine(i);
    i++;
}

int i = 0;

string[] isimler = {"kadir","mustafa","tolga"};

while (i < isimler.Length) {
    Console.WriteLine(isimler[i]);
    i++;
}

var secim = "e";
var sayac = 1;
var toplam = 0;

while (secim == "e") {
    Console.Write($"{sayac}. sayıyı giriniz: ");
    toplam += Convert.ToInt32(Console.ReadLine());

    Console.Write("devam etmek istiyor musunuz? (e/h)");
    secim = Console.ReadLine();

    sayac++;
}

Console.WriteLine($"{sayac-1} adet sayının toplamı: {toplam}");


//break&continue

string isim = "Kadır";

for(int i = 0; i < isim.Length; i++) {
    if(isim[i] == 'ı') { //char a dikkat et tek tırnak kullanılacak
        break; //döngüyü başa alır
    }
    Console.WriteLine(isim[i]);
}

int x = 0;

while (x < 5) {
    x++;
    if(x == 3) {
        continue; //sağlanan şartı atlar ve döngüyü başa alır
    }
    Console.WriteLine(x);
}

using System.Diagnostics;

var rnd = new Random();
int tutulan = rnd.Next(1,10);
int hak = 3;

while(hak > 0) {
    Console.Write("sayı giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    hak--;

    if(tutulan == sayi) {
        Console.WriteLine("tebrikler bildiniz");
        break;
    } else {
        if (hak == 0) {
            Console.WriteLine("haklarınız bitti, tekrar deneyiniz...");
        }
        else if(tutulan > sayi) {
            Console.Write("daha büyük bir sayı giriniz: ");
        } else{
            Console.Write("daha küçük bir sayı giriniz: ");
        }
    }
}

Console.WriteLine("oyun bitti");


/*do-while döngüsü
while den farkı, do kısmındaki kodlar en az bir 
kere işlenir*/

int i = 1;

do {
    Console.WriteLine(i);
    i++;
} while (i < 1);


//foreach döngüsü

string ad = "kadir";

for(var i = 0; i < ad.Length; i++) {
    Console.WriteLine(ad[i]);
}

foreach(var harf in ad) {
    Console.WriteLine(harf);
}