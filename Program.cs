using Ecommerce2.Ecommerce;

namespace Ecommerce2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EcommerceInterface ecommerce = new EcommerceInterface();
            ecommerce.AvviaEcommerce();
            
            do
            {
                SelezioneDto dto = ecommerce.SelezionaProdottoEQuantita();
                ecommerce.AggiungiAlCarrello(dto);
                if (ecommerce.ChiediSeApplicareCoupon() == true)
                {
                    ecommerce.MostraRiepilogo2();
                }
                
            } while (ecommerce.ChiediSeContinueare());

            ecommerce.MostraRiepilogo2();
            

        }
    }
}