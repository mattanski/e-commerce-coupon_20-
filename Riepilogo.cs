using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Ecommerce2.Ecommerce
{
    public class Riepilogo
    {
        private readonly Carrello _carrello;

        public Riepilogo(Carrello carrello)
        {
            _carrello = carrello;
        }


        public string StampaScontrino()
        {
            /*
            string messaggio = "";
            foreach (var selezione in _carrello.Selezioni)
            {
                messaggio += $"{selezione.Prodotto.Descrizione}\n{selezione.Prodotto.Prezzo}\tX" +
                             $"\t{selezione.Quantita}\t{selezione.Prodotto.Prezzo * selezione.Quantita}";
            }

            decimal totale = _carrello.CalcolaTotale();
            messaggio += $"\nTotale: {totale}";
            return messaggio;*/


            List<string> riepiloghi = OttieniRiepilogoSelezioni();
            decimal totale = _carrello.CalcolaTotale();
            return CreaScontrino(riepiloghi, totale);

        }

        public string StampaScontrino2()
        {
            


            List<string> riepiloghi = OttieniRiepilogoSelezioni2();
            decimal totale2 = _carrello.CalcolaTotale2();
            return CreaScontrino2(riepiloghi, totale2);

        }

        private string CreaScontrino2(List<string> riepiloghi, decimal totale )
        {
            StringBuilder builder = new StringBuilder();
            foreach (var stringa in riepiloghi)
            {
                builder.Append(stringa);
            }
            
            builder.Append($"\n  Totale prezzo sul prodotto corrente con coupon del 20%  {totale}\n");
            return builder.ToString();

        }
        
        



    private string CreaScontrino(List<string> riepiloghi, decimal totale)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var stringa in riepiloghi)
            {
                builder.Append(stringa);
            }
            builder.Append($"\nTotale euro {totale}");
            return builder.ToString();
        }
        
        
        

        private List<string> OttieniRiepilogoSelezioni()
        {
            List<string> riepiloghi = new List<string>();
            foreach (var selezione in _carrello.Selezioni)
            {
                riepiloghi.Add(selezione.ToString()); 
            }

            return riepiloghi;
        }
        
        private List<string> OttieniRiepilogoSelezioni2()
        {
            List<string> riepiloghi = new List<string>();
            foreach (var selezione in _carrello.Selezioni)
            {
                riepiloghi.Add(selezione.ToString()); 
            }

            return riepiloghi;
        }
        
        
        
        



        
    }
}