namespace Ecommerce2.Ecommerce
{
    public class Prodotto
    {
        private readonly int _codice;
        private readonly string _descrizione;
        private readonly decimal _prezzo;
        private readonly int _sconto;
        private readonly decimal _coupon;

        public Prodotto(int codice, string descrizione, decimal prezzo,int sconto,decimal coupon)
        {
            _codice = codice;
            _descrizione = descrizione;
            _prezzo = prezzo;
            _sconto = sconto;
            _coupon = coupon;
        }

        public int Sconto => _sconto;
        public decimal Prezzo => _prezzo;

        public string Descrizione => _descrizione;

        public int Codice => _codice;

        public decimal Coupon => _coupon;
       
    }
}