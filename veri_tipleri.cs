/*
Veri Tipleri
tam sayı = byte, short, integer, long
ondalıklı sayı = float, double, decimal
true-false veya tek karakter = char, boolean, struct
true = 1, false = 0

Referans Tipleri
String, Class, Array, Interface
*/

int sayi = 200;
double kdv1 = 1.18;
float kdv2 = 1.18f;
decimal kdv3 = 1.18m;
char cinsiyet1 = 'E';
string cinsiyet2 = "Erkek";


/*
Veri tipi dönüşümü
Readline console daki değeri okur
Sadece write yazarsak console bi alt satıra inmez 
Veri tipi dönüşümü büyükten küçüğe(int to byte) olursa düzeltmemiz lazım
değilse C# otomatikmen dönüşümü yapar
*/

Console.Write("1. sayıyı giriniz: ");
var sayi1 = Convert.ToInt32(Console.ReadLine()); //string to int

Console.Write("2. sayıyı giriniz: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

var toplam = sayi1 + sayi2;
Console.WriteLine(toplam);

int a = 10;
long b = a; //implicit casting => bilinçsiz tür dönüşümü

long d = 20;
int e = d; //explicit casting => bilinçli tür dönüşümü

long j = 20;
int k = (int)j; //dönüşümü yaptık

int x = 10;
string z = x.ToString();
*/

//Nullable Types

int? maas = null;

Console.WriteLine(maas.HasValue); //false
Console.WriteLine(maas.GetValueOrDefault()); //0