namespace _47RealEstatePolymorphism
{
    class Arsa
    {
        public int En { get; set; }
        public int Boy { get; set; }

        public virtual int AlanHesapla()
        {
            //throw new Exception("Şekli belli olmayan arsanın alanı hesaplanamaz.");
            return 0;
        }
    }

    class DortgenArsa : Arsa
    {
        public override int AlanHesapla()
        {
            return En * Boy;
        }
    }

    class UcgenArsa : Arsa
    {
        public override int AlanHesapla()
        {

            return En * Boy / 2;
        }
    }
}
