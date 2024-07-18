// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz");

Console.Write("T.C. Kimlik Numarasi: ");
long tc = Convert.ToInt64(Console.ReadLine());

Console.Write("Adi: ");
string ad = Console.ReadLine();

Console.Write("Soyadi: ");
string soyad = Console.ReadLine();

Console.Write("Telefon Numarasi: ");
long tel = Convert.ToInt64(Console.ReadLine());// Tel no sayısı integer sayısından buyuk oldugu icin Long yaptım, 32 bitten buyuk oldu ıcın 64 bite convert ettim.

Console.Write("Yas: ");
byte yas = Convert.ToByte(Console.ReadLine());// Yas 250'yi gecemeyecegı icin cok yer kaplamasın diye byte'i tercih ettim.

Console.Write("Ilk adigi urunun fiyati: ");
int urun1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ikinci adigi urunun fiyati: ");
int urun2 = Convert.ToInt32(Console.ReadLine());// urun fiyatı 32 bitten buyuk olmayacagı icin 32 bite convert ettim.

int toplam = urun1 + urun2;

Console.WriteLine("-------------------------------------------------");

Console.WriteLine(tc + " " + "Tc numarali" + " " + ad + " " + soyad + " " + "isimli kisi icin kayit olusturulmustur.");
Console.WriteLine(tel + " " + "telefon numrasina bildirim mesaji gonderilmistir.");
Console.WriteLine((toplam) + " " + "toplam harcama karsiligi kazanilan %10 patika puan miktari ->" + " " + (toplam * 0.1) + "TL'dir");