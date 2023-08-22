/*
int a = 2;
int b = a++;
a = 3, b = 2
int parse ile convertTo32 aynı metodlardır
*/

//aritmetik operatörler

var a = 10;
var b  = 3;
var c = 2;

var sonuc = a + b;
var sonuc = a - b;
var sonuc = a * b;
var sonuc = (float)a / (float)b;
var sonuc = (a + b) * c;
var sonuc = a % b;
var sonuc = a++;

Console.WriteLine(sonuc);


//uygulama

int a = 10;
int b = 5;
int c = 20;

var sonuc = (c - a) * b;

Console.WriteLine(sonuc);

int? a = null;
int b = 20;

var sonuc = (a ?? 0) + b; //a null ise a ya 0 ata

Console.WriteLine(sonuc);

int a = 10;
int b = 20;

a = b--;

Console.WriteLine(a);
Console.WriteLine(b);

Console.Write("sayı gir: ");
int sayi = Convert.ToInt32(Console.ReadLine() ?? "0");

var sonuc = sayi % 2;

Console.WriteLine(sonuc); //1 ise tek, 0 ise çift

//atama operatörleri

var a = 5;
var b = 10;
 
a += b; 
a += 5;
a -= b;
a *= b;
a /= b;
a %= b;

//math

double sonuc; //büyük bir değer tutabildiği için double ı kullandık

sonuc = Math.Pow(2,3); //2 üzeri 3
sonuc = Math.Sqrt(25); //karekök alır
sonuc = Math.Abs(-10); //mutlak değer alır
sonuc = Math.Round(4.5);  //yuvarlama işlemi yapar, sonuç 4 tür
sonuc = Math.Round(4.6);  //yuvarlama işlemi yapar, sonuç 5 tür
sonuc = Math.Ceiling(4.1); //direk yukarı yuvalar, sonuç 5 tir
sonuc = Math.Floor(4.8); //direk aşağı yuvalar, sonuç 4 tür
sonuc = Math.Max(10, 20); //büyük olan değeri verir
sonuc = Math.Min(10, 20); //küçük olan değeri verir


using System.ComponentModel;

int a = 5, b = 5, c = 10, d = 3;
string username = "kadir";
string parola = "1234";

var sonuc = (a == b); //true  
sonuc = (c == d); // false
sonuc = (username == "kadir"); //true
sonuc = (parola == "12345"); //false

sonuc = (a != b); //false
sonuc = (a > c); //false
sonuc = (a < c); //true
sonuc = (a >= b); //true

//ternary
var sonuc2 = (a > b) ? "a büyük":"b büyük"; //önce true durumu sonra false durumu yazarız

Console.WriteLine(sonuc);

//mantıksal operatörler

var a = true;
var b = true;
var c = false;

var sonuc = (a && b);
var sonuc = (a && c);

var sonuc = (a || b);
var sonuc = (a || c);

var sonuc = !a; //false
var sonuc = !c; //true

Console.WriteLine(sonuc);

//random

Random rnd = new Random(); //or var rnd = new Random();

string[] takimlar = {"Beşiktaş","Galatasaray","Fenerbahçe","Trabzon"};

int sayi = rnd.Next(0,4); //0 dan 4 e kadar bir sayı üretir (4 dahil değil)

Console.WriteLine(takimlar[sayi]);