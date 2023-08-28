/*
try {
    int a = 5;
    int b = 0;
    int sonuc = a/b;
}
catch (System.DivideByZeroException) {
    Console.WriteLine("yazdığınız sayı 0'a bölünemez");
}
catch (Exception ex) {
    Console.WriteLine("bir hata oluştu");
    Console.WriteLine(ex.Message); //karşılaştığımız hatayı yazdırır
}



//hata fırlatma, kendimize özel hatalar oluştururken kullanırız

int sayi = 10;

if(sayi > 5) {
    throw new Exception("sayı 5'den büyük olamaz");
}
*/
static void parola_kontrol(string password) { //fonksiyon yazdık
    if(password.Length < 6 || password.Length > 10) {
        throw new Exception("parola 6-10 karakter aralığında olmalıdır");
    }

    /*aradığımız karakter var mı yok mu diye kontrol ederiz buna göre true ya da false dönderir
    IsDigit gönderilen karakterin sayısal olup olmadığını kontrol eder.*/

    if(!password.Any(char.IsDigit)) {
        throw new Exception("parola en az bir rakam içermelidir");
    }

    if(!password.Any(char.IsLetter)) {
        throw new Exception("parola en az bir harf içermelidir");
    }
}

static void Main(string[] args) {
    Console.Write("parola: ");
    string parola = Console.ReadLine();

    try {
        parola_kontrol(parola);
        Console.WriteLine("parola geçerli");
    }
    catch(Exception e) {
        Console.WriteLine(e.Message);
    }
}




