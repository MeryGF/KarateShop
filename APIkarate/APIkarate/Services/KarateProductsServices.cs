
using APIkarate.IServices;
using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace APIService.Services
{
    public class KarateProductsServices: IKarateProductsServices
    {
        private readonly IKarateProductsLogic _KarateProductsLogic;
        public KarateProductsServices(IKarateProductsLogic KarateProductsLogic) {
            _KarateProductsLogic = KarateProductsLogic;
        }        

        int IKarateProductsServices.InsertKarateProducts(KarateProducts KarateProducts)
        {
            _KarateProductsLogic.InsertKarateProducts(KarateProducts);
            return KarateProducts.Id;
        }
        public List<KarateProducts> GetAllKarateProducts()
        {
            return _KarateProductsLogic.GetAllKarateProducts();
        }
        public void DeleteKarateProducts(int id)
        {
            _KarateProductsLogic.DeleteKarateProducts(id);
        }
        public void UpdateKarateProducts(KarateProducts karateProducts)
        {
            _KarateProductsLogic.UpdateKarateProducts(karateProducts);
        }
        //public List<KarateProducts> GetProductsByCriteria(KarateProductsFilter karateProductsFilter)
        //{
        //    return _KarateProductsLogic.GetProductsByCriteria(karateProductsFilter);
        //}
    }
}



