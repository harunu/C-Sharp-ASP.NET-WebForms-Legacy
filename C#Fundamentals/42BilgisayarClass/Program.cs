using System;

namespace _42BilgisayarClass
{
    class Program
    {
        /*•	Bilgisayar isimli bir sinif olsun ve şu özelliklere sahip olsun
o	Islemci Saat Hizi (HZ) int
o	Ram Boyutu (2 nin katlari) int // 2 nin katı değilse 2 nin katı olacak şekilde artırsın
o	Disk boyutu (2 nin katlari) long// 2 nin katı değilse 2 nin katı olacak şekilde artırsın;
o	 
o	Bir bilgisayar oluşturabilmek için işlemci ve ram i tanımlamak zorunlu olsun. İşlemci ve ram tanımlanmadan bilgisayar nesnesi oluşturulamasın. Ancak bilgisayar sınıfından bir örnek oluşturulurken disk boyutu da ihtiyari olarak tanımlanabilsin. 
o	Bilgisayarın IslemYap isimli bir metodu olsun ve int miktar seklinde bir parametre alsin. 
•	1 Hz islemciye sahip bir islemci 1 birim islemi 1 ms de yaptigina gore islemin ne kadar surecegini geriye dondursun. Ayrıca birim miktari kadar ram in bulunup bulunmadigi kontrol edilsin ve ram yetmiyorsa 0 degeri geriye donsun.
•	Diske yaz isimli bir metodu olsun ve diske yazmak için bir string degisken verilsin. Eğer disk boyutu stringing boyutundan küçükse false değilse true değeri geriye dönsün.e3

*/


        static void Main(string[] args)
        {
            Bilgisayar b = new Bilgisayar(500, 64001);
            Console.WriteLine(b.IslemYap(8000));
            Console.WriteLine(b.DiskeYaz("Merhaba dünya"));
            Console.Read();
        }
    }
}
