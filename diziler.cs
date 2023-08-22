//arrays

var Ad = "Kadir Akipek";
Console.WriteLine(Ad[1]);

var Ad1 = "Kadir Akipek".Split(" ");
Console.WriteLine(Ad1[1]);

string[] isimler = new string[5]; //5 elemanlı boş bir string dizisi oluşturduk

isimler[0] = "Kadir";
isimler[1] = "Mustafa";
isimler[2] = "Tolga";
isimler[3] = "İbrahim";
isimler[0] = "Kadir";

Console.WriteLine(isimler[2]);

int[] numaralar = {100,200,300,400,500};

Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");

//array methods

string[] sehirler = {"İstanbul","Rize","Kocaeli"};
int[] plakalar = {34,53,41};

//sehirler[0] = "Sakarya";
sehirler.SetValue("Sakarya",0);

//Console.WriteLine(sehirler[0]);
Console.WriteLine(sehirler.GetValue(0));

Console.WriteLine(sehirler.Length);
Console.WriteLine(Array.IndexOf(sehirler, "Rize")); //sehirler dizisi içinde Rize yi arar

Array.Sort(sehirler); //sehirler dizisini alfabetik olarak sıralar
Array.Sort(plakalar);

Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(plakalar.GetValue(0));

Array.Reverse(plakalar); //listeyi ters çevirir

Array.Clear(sehirler); //tüm elemanları siler
Array.Clear(plakalar);

Array.Clear(plakalar, 0, 1); //plakalar dizisinde 0. index ten itibaren 1 tane sil

Console.WriteLine(sehirler.GetValue(0)); //stringde default değer null dur
Console.WriteLine(plakalar.GetValue(0)); //int de default değer 0 dır

//array slicing

string[] sehirler2 = {"İstanbul","Rize","Kocaeli","Elazığ","Yalova"};

//var sonuc = sehirler2[0..3];

foreach(var i in sehirler2[..3]) { //sehirler içerisindeki her elemanı bir bir i ye kopyalar
    Console.WriteLine(i);
}

foreach(var i in sehirler2[1..]) { 
    Console.WriteLine(i);
}

string ad = "Kadir";
Console.WriteLine(ad[..]);


//çok boyutlu diziler

int[,] notlar = new int[3,3];

notlar[0,0] = 50;
notlar[0,1] = 50;
notlar[0,2] = 50;

notlar[1,0] = 60;
notlar[1,1] = 60;
notlar[1,2] = 60;

notlar[2,0] = 70;
notlar[2,1] = 70;
notlar[2,2] = 70;

Console.WriteLine(notlar[0,1]);


//referans tipleri

int x = 10;
int y = x;

Console.WriteLine(x);
Console.WriteLine(y);

x = 20;

Console.WriteLine(x);
Console.WriteLine(y);

int[] array = {10,20};
int[] array2 = array;

Console.WriteLine(array[0]);
Console.WriteLine(array2[0]);

array[0] = 20;

Console.WriteLine(array[0]);
Console.WriteLine(array2[0]);