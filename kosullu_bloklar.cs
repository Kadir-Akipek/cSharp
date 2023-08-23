//if/else bloğu

string username = "kadirakipek";
string password = "12345";

if (username == "kadirakipek") {

    if (password == "12345") {
        Console.WriteLine(":)");
    } else {
        Console.WriteLine("Parola yanlış");
    }
}
else {
    Console.WriteLine("username yanlış");
}

if (username != "kadirakipek") {
    Console.WriteLine("username yanlış");
} else if (password != "12345") { //else if te ekstra bir soru sorarız
    Console.WriteLine("parola yanılş");
} 
else {
    Console.WriteLine("username yanlış");
}

int x = 10;
int y = 20;

if(x > y) {
    Console.WriteLine("x y deb büyük");
}
else if(x == y) {
    Console.WriteLine("x y e eşit");
}
else if(x < y) {
    Console.WriteLine("x y den büyük");
}
else {
    Console.WriteLine("x y den büyük");
}

//switch-case

int gun = (int)DateTime.Now.DayOfWeek;

switch(gun) { //gun için case'ler(durumlar) tanımlarız
    case 0:
        Console.WriteLine("pazar");
        break;
    case 1:
        Console.WriteLine("pazartesi");
        break;
    case 2:
        Console.WriteLine("salı");
        break;
    case 3:
        Console.WriteLine("çarşamba");
        break;
    case 4:
        Console.WriteLine("perşembe");
        break;
    case 5:
        Console.WriteLine("cuma");
        break;
    case 6:
        Console.WriteLine("cumartesi");
        break;

    default: //hiçbir durum karşılanmazsa
        Console.WriteLine("hatalı gün");
        break;
}

//ternary