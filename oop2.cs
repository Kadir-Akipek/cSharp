namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            var soru1 = new Soru(1,"Hangisi programlama dili değildir", new string[4] {"Python","C#","Java","Html"}, "Html"); //parametrelerle doldurduk
            var soru2 = new Soru(2,"Hangisi en popüler programlama dilidir", new string[4] {"Python","C#","Java","Html"}, "Html"); 
            var soru3 = new Soru(3,"Hangisi en popüler web programlama platformudur", new string[4] {"Python","C#","Java","Html"}, "Html"); 
            /*
            var soru1 = new SOru(){
                SoruMetni = "Hangisi programlama dili değildir",
                Secenekler = new string[4] {"Python","C#","Java","Html"},
                Cevap = "Html"
            };
            var soru2 = new Soru() 
            {
                SoruMetni = "Hangisi en popüler programlama dilidir",
                Secenekler = new string[4] {"Python","C#","Java","Html"},
                Cevap = "C#"
            };
            var soru3 = new Soru() 
            {
                SoruMetni = "Hangisi en popüler web programlama platformudur",
                Secenekler = new string[4] {"Dhango","ASP.NET","Python","Spring"},
                Cevap = "Python"
            };*/
            var soru4 = new Soru(10); //parametre verdik

            Console.WriteLine(soru4.SoruId);
            
            Console.WriteLine(soru1.SoruYazdir());
            Console.WriteLine(soru1.cevapKontrol("html"));

            Console.WriteLine(soru2.SoruYazdir());
            Console.WriteLine(soru2.cevapKontrol("html"));

            Console.WriteLine(soru3.SoruYazdir());
            Console.WriteLine(soru3.cevapKontrol("html"));

            

            var sorular = new Soru[] {soru1,soru2,soru3,soru4};

             foreach (var soru in sorular)
             {
                 Console.WriteLine(soru.SoruMetni);
                 foreach (var secenek in soru.Secenekler) //alt döngü kurduk
                 {
                    Console.WriteLine(secenek);
                 }
                 //kullanıcıdan cevap alalım
                 Console.Write("cevabınız: ");
                var cevap = Console.ReadLine();

                 if(soru.cevapKontrol(cevap)) {
                    Console.WriteLine("Doğru cevap");
                 } else{
                     Console.WriteLine("Maalesef bilemediniz");
                 }
             }
        }
}
    
    class Soru {
        //properties
       
        private int SoruId { get; set; } 
        private string SoruMetni { get; set; }
        private string[] Secenekler { get; set; }
        private string Cevap { get; set; }
        //methods
        public bool cevapKontrol(string cevap) { //parametre kullandık
            return this.Cevap.ToLower() == cevap.ToLower();
        }
        /*constructor method, her bir obje için oluşturulan özellik çalıştırlır
        sen yinede bi int den bak
        bir nesne oluşturulma aşamasındayken biz direk cevap seçeneklerini yüklüyoruz(yani bir kalıba bağlı tutuyoruz)*/
        public Soru() //class ismiyle aynı bir metod tanımlarız
        {
            Console.WriteLine("constructor 1");
            this.SoruId = (new Random()).Next(11111,99999);
        }
        public Soru(int SoruId) //ctor yaz ve tab yap
        {
            Console.WriteLine("constructor 2");
            this.SoruId = SoruId;
        }
        public Soru(int SoruId, string SoruMetni, string[] secenekler, string cevap)
        {
            this.SoruId = SoruId; //dışardan gönderdiğimiz soru ıd
            this.SoruMetni = SoruMetni;
            this.Cevap = cevap;
        }
        /*access modifiers(propertilere veya metodlara sınıf dışından
        erişebilmemizi sağlar, public'e her yerden erişilebilir. Erişilmesini
        istemediğimiz property'leri private yaparız(sadece kendi metodu ve sınıfı
        içerisinde erişilebilir)*/
        public string SoruYazdir() {
            string soru = "";
            soru += this.SoruMetni + "\n";

            foreach (var secenek in this.Secenekler)
            {
                soru += secenek + "\n";
            }
            return soru;
        }
}
}