using Data;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic.Logic
{
    public class KarateProductsLogic : BaseContextLogic, IKarateProductsLogic
    {
        public KarateProductsLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertKarateProducts(KarateProducts KarateProducts)
        {
            _serviceContext.KarateProducts.Add(KarateProducts);
            _serviceContext.SaveChanges();
            return KarateProducts.Id;
        }
        public List<KarateProducts> GetAllKarateProducts() {
        return _serviceContext.Set<KarateProducts>().ToList();
        }
        public void UpdateKarateProducts(KarateProducts karateProducts)
        {
          
           _serviceContext.KarateProducts.Update(karateProducts);
           _serviceContext.SaveChanges();
            
           //Path-->MODIFICAR            
        }
        public void DeleteKarateProducts(int id)
        {
            var KarateProductsToDelete = _serviceContext.Set<KarateProducts>()
                 .Where(u => u.Id == id).First();
           KarateProductsToDelete.IsActive = false;
           _serviceContext.SaveChanges();
        }
        //public List<KarateProducts> GetProductsByCriteria(KarateProductsFilter KarateProductsFilter)
        //{
        //    //ejemplo para IsActive solamente
        //    return _serviceContext.Set<KarateProducts>()
        //        .Where(p => p.IsActive == KarateProductsFilter.IsActive)
        //        .ToList();
        //}

        //public void UpdateKarateProducts(KarateProducts karateProducts)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

  