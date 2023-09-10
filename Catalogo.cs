using System.Collections.Generic;
using System.Linq;

namespace Ecommerce2.Ecommerce
{
    public class Catalogo
    {
        private List<Prodotto> _prodotti = new List<Prodotto>();
        public Catalogo()
        {
            Prodotto p1 = new Prodotto(1, "Trebbiatrice", 400000,50,20);
            Prodotto p2 = new Prodotto(2, "Trattore", 150000,50,20);
            Prodotto p3 = new Prodotto(3, "Scuotitore", 300000,50,20);
            
            _prodotti.Add(p1);
            _prodotti.Add(p2);
            _prodotti.Add(p3);
            
        }

        public IReadOnlyList<Prodotto> Prodotti => _prodotti.AsReadOnly();


        public bool EsisteProdottoConCodice(int codice)
        {
            //return _prodotti.Any(a => a.Codice == codice);
            foreach (var prodotto in _prodotti)
            {
                if (prodotto.Codice == codice)
                    return true;
            }

            return false;
        }

        public Prodotto RecuperaProdottoPerCodice(int codice)
        {
            return _prodotti.First(a => a.Codice == codice);
        }
    }
}