using System;
using Ecommerce2.Ecommerce;

namespace Ecommerce2
{
    public class EcommerceInterface
    {
        private EcommerceController controller;
        public void AvviaEcommerce()
        {
            controller = new EcommerceController();

            foreach (var prodotto in controller.Catalogo.Prodotti)
            {
                Console.WriteLine($"{prodotto.Descrizione} ({prodotto.Codice}) al prezzo di " +
                                  $"{prodotto.Prezzo}");
            }
        }

        public SelezioneDto SelezionaProdottoEQuantita()
        {
           
            int codice = DammiCodiceProdotto();
            int quantita = DammiQuantitaProdotto();

            return new SelezioneDto()
            {
                Quantita = quantita,
                CodiceProdotto = codice
            };
        }

        private int DammiQuantitaProdotto()
        {
            Console.WriteLine("Dammi la quantità del prodotto prescelto:");
            
            int input = 0;
            bool continua = false;
            
            do
            {
               string inputStringa = Console.ReadLine();

               try
               {
                  input = int.Parse(inputStringa);
                  if (input <= 0)
                  {
                      Console.WriteLine("Il valore inserito è negativo. Inserisci un valore positivo");
                      continua = true;
                  }
                  else
                  {
                      continua = false;
                  }
                  
               }
               catch (Exception e)
               {
                   Console.WriteLine("Attenzione il valore inserito non è corretto");
                   continua = true;
               }
               
            } while (continua);

            return input;
        }

        private int DammiCodiceProdotto()
        {
            Console.WriteLine("Dammi il codice del prodotto");

            int codice = 0;

            bool continua = false;

            do
            {
                string inputstinga = Console.ReadLine();
                
                try
                {

                    codice = int.Parse(inputstinga);
                    if (!controller.Catalogo.EsisteProdottoConCodice(codice))
                    {
                        Console.WriteLine("Il prodotto selezionato non esiste. Selezionane un altro!");
                        continua = true;
                    }
                    else
                    {
                        continua = false;
                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine("Attenzione il valore inserito non è corretto");
                    continua = true;
                }
                
                
                
            } while (continua);

            return codice;

        }


        public void AggiungiAlCarrello(SelezioneDto dto)
        {
            Prodotto p = controller.Catalogo.RecuperaProdottoPerCodice(dto.CodiceProdotto);
            controller.Carrello.AggiungiSelezione(p, dto.Quantita);
        }
        
        public bool ChiediSeApplicareCoupon()
        {
            Console.WriteLine("Vuoi Applicare il 20 % di sconto con il coupon? (S/N)");
            string result = Console.ReadLine();
            return result == "S";
        }


        public bool ChiediSeContinueare()
        {
            Console.WriteLine("Vuoi acquistare altro? (S/N)");
            string result = Console.ReadLine();
            return result == "S";
            
        }

        public void MostraRiepilogo()
        {
            Console.WriteLine(controller.StampaScontrino());
        }
        
        public void MostraRiepilogo2()
        {
            Console.WriteLine(controller.StampaScontrino2() );
        }

        
        
        
    }
}