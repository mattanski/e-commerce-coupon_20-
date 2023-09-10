using System;

namespace Ecommerce2.Ecommerce
{
    public class EcommerceController
    {
        private Carrello _carrello;
        private Catalogo _catalogo;


        public EcommerceController()
        {
            _catalogo = new Catalogo();
            _carrello = new Carrello();
        }

        public Catalogo Catalogo => _catalogo;

        public Carrello Carrello => _carrello;

        public string StampaScontrino()
        {
            Riepilogo riepilogo = new Riepilogo(_carrello);
            return riepilogo.StampaScontrino();
        }
        public string StampaScontrino2()
        {
            Riepilogo riepilogo = new Riepilogo(_carrello);
            
            return riepilogo.StampaScontrino2();
        }
        
        
        
     
       
    }
}