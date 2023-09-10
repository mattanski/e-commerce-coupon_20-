using System.Collections.Generic;
using System.Linq;

namespace Ecommerce2.Ecommerce
{
    public class Carrello
    {
        private List<Selezione> _selezioni = new List<Selezione>();

        public Carrello()
        {

        }

        public IReadOnlyList<Selezione> Selezioni => _selezioni.AsReadOnly();

        public void AggiungiSelezione(Prodotto prodotto, int quantita)
        {
            Selezione s = new Selezione(prodotto, quantita);
            _selezioni.Add(s);
        }

        public decimal CalcolaTotale()
        {
            decimal totale = 0;
            foreach (var selezione in _selezioni)
            {
                totale += selezione.CalcolaTotaleParziale();

            }

            return totale;
            // return _selezioni.Sum(selezione => selezione.Quantita * selezione.Prodotto.Prezzo);





        }

        public decimal CalcolaTotale2()
        {
            decimal totale2 = 0;
            foreach (var selezione2 in _selezioni)
            {
                totale2 += selezione2.CalcolaTotaleParzialeConCouponApplicato();

            }

            return totale2;
            // return _selezioni.Sum(selezione => selezione.Quantita * selezione.Prodotto.Prezzo);
        }
    }
}