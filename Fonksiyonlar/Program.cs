namespace Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)//Özel ve gömülü bir metot
        {
            Console.WriteLine("Hello, World!");

            //5 Metod Türü bulunmakta

            //1. Değer almayan değer döndürmeye metot (void)
            //2. Değer alan değer döndürmeyen metot (void)
            //3. Değer almayan değer döndüren motot (return - değişken adı)
            //4. Değer alan değer döndüren metot (return - değişken adı)
            //5. Constructor metot (Class metodu)

            //Metot Erişimleri
            //1. Public metot erişimi
            //Genel kullanıma açık ve class nesnesi oluşan her yerde erişim sağlanan metot
            //2. Private metot erişimi
            //Özel metot olarak geçer. sadece kendi classı içerinde çalışır
            //3. Protected metot erişimi
            //Sınırl erişime sahip metot türüdür. Class kalıtım (miras) yöntemi ile erişim sağlanabilir

            //Bonus: static erişim türü (Çakılı-gömülü metot)
            //Class nesnesi oluşturmadan class adı ile çağırılabilen metot türü > user.adduser()

            //user newuser = new user();
            //newuser.adduser();//public metot

            //user.adduser();//public static metot

            //AClass newA = new AClass();

            //newA.m1();
            //newA.m5();
            //newA.m2();

            //BClass newB = new BClass();

            //newB.m4();
            //BClass.m3();

            metot2();//metot2 static bir metot olduğu için static bir metot içerisinde direkt çağırılabilir

            Program program = new Program();//static bir metot içerisine public void yapısında metot olduğu gibi çağırılamaz
            program.metot1();//çağırılması için metotun class nesnesi oluşturulup class adı.metot adı ile çağırılabilir

            metot3("Erhan"); //içine parametre atamadan çalıştıramazsın

            int deger = metot4(); //değer döndüren metotlar değişken gibi kullanılabilir.
                                  //Bir değişkene aktarılabilir,
                                  //işleme girebilir ya da consola yazdırılabilir
            int sonuc = deger * 5;
            Console.WriteLine(sonuc);

            double dc = dikdortgenCevreHesabi(26.9, 11.94);
            Console.WriteLine("Dikdörtgenin Çevresi: " + Math.Round(dc,2));
        }


        public void metot1()//değer almayan değer döndürmeye metot
        {
            int a = 5;
            int b = 15;
            int sonuc = a+ b;
            Console.WriteLine(sonuc);
        }
        public static void metot2()//değer almayan değer döndürmeye metot
        {
            int a = 5;
            int b = 15;
            int sonuc = a+ b;
            Console.WriteLine(sonuc);
        }

        public static void metot3(string name) //değer alan değer döndürmeyen metot
        {
            Console.WriteLine("Gelen İsim: " + name);
        }

        public static int metot4() //değer almayan değer döndüren metot
        {
            int a = 5;
            return a;
        }

        public static double dikdortgenCevreHesabi(double uzunKenar, double kisaKenar)//değer alan değer döndüren metot
        {
            double sonuc = 2 * (uzunKenar + kisaKenar);
            return sonuc;
        }
    }
}