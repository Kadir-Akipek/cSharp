//string concat(birleştirme)

Console.Write("Adınız: ");
var ad = Console.ReadLine();

Console.Write("Soyadınız: ");
var soyad = Console.ReadLine();

Console.Write("Yaşınız: ");
var yas = Console.ReadLine();

string mesaj1 = ad + " " + soyad + " isimli kişi " + yas + " yaşındadır";
Console.WriteLine(mesaj1);

//string interpolation
string mesaj2 = $"{ad} {soyad} isimli kişi {yas} yaşındadır";
Console.WriteLine(mesaj2);


//string metodhs

string mesaj = "Kadir Akipek isimli kişi 20 yaşındadır";

int adet = mesaj.Length;
var sonuc = mesaj.ToLower();
var sonuc2 = mesaj.ToUpper();
var sonuc3 = mesaj.Trim();

var sonuc4 = mesaj.Split(" ")[3];
var sonuc5 = mesaj[3];

var sonuc6 = mesaj.StartsWith("K");
var sonuc7 = mesaj.EndsWith("d");

var sonuc8 = mesaj.Contains(" ");
var sonuc9 = mesaj.IndexOf("Kadir"); //if result -1 mean no found
var sonuc10 = mesaj.Substring(6, 5);

var sonuc11 = mesaj.Replace("Kadir","Mustafa");


Console.WriteLine(sonuc11);


//datetime

DateTime simdi = DateTime.Now; //or var simdi = DateTime.Now;

Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Hour);
Console.WriteLine(simdi.DayOfWeek);

DateTime dt = new DateTime(2018, 6, 10, 14, 30, 45);
DateTime dt2 = dt.AddYears(1);

Console.WriteLine(dt);
Console.WriteLine(dt2.Year);

var fark = simdi - dt;
Console.WriteLine(fark.TotalDays);