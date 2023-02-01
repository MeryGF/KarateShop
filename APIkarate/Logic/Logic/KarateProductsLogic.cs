using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic.Logic
{
    public class KarateProductsLogic : BaseContextLogic, KarateProductsILogic
    {
        public KarateProductsLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertKarateProducts(KarateProducts KarateProducts)
        {
            _serviceContext.KarateProducts.Add(KarateProducts);
            _serviceContext.SaveChanges();
            return KarateProducts.Id;
        }
    }
}
