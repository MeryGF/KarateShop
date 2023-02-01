
using APIkarate.IServices;
using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace APIService.Services
{
    public class KarateProductsServices: KarateProductsIServices
    {
        private readonly KarateProductsILogic _KarateProductsLogic;
        public KarateProductsServices(KarateProductsILogic KarateProductsLogic) {
            _KarateProductsLogic = KarateProductsLogic;
        }
       
        

        int KarateProductsIServices.InsertKarateProducts(KarateProducts KarateProducts)
        {
            _KarateProductsLogic.InsertKarateProducts(KarateProducts);
            return KarateProducts.Id;
        }
    }
}
