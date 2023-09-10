namespace Ecommerce2.Ecommerce
{
    public class Selezione
    {
        private readonly Prodotto _prodotto;
        private readonly int _quantita;

        public Selezione(Prodotto prodotto, int quantita)
        {
            _prodotto = prodotto;
            _quantita = quantita;
        }

        public Prodotto Prodotto => _prodotto;

        public int Quantita => _quantita;

        public override string ToString()
        {
            string messaggio = $"\n{Prodotto.Descrizione}\n{Prodotto.Prezzo}\tX" +
                               $"\t{Quantita}\t{CalcolaTotaleSenzaSconto()}"+
                               $"\tSconto -{Prodotto.Sconto}%\t{CalcolaTotaleParziale()}";
            return messaggio;
        }

        private decimal CalcolaTotaleSenzaSconto()
        {
            return Prodotto.Prezzo * Quantita;
        }

        public decimal CalcolaTotaleParziale()
        {    
            return Prodotto.Prezzo * Quantita * Prodotto.Sconto / 100;
        }
        
        

        
        public decimal CalcolaTotaleParzialeConCouponApplicato()
        {
            return  Prodotto.Prezzo * Quantita * Prodotto.Sconto / 100 - Prodotto.Prezzo * Quantita * Prodotto.Sconto / 100 * Quantita  * Prodotto.Coupon / 100;
        }
        
    }
}