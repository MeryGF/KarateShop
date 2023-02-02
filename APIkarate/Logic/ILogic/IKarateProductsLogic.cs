using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IKarateProductsLogic
    {
        int InsertKarateProducts(KarateProducts KarateProducts);
        List<KarateProducts> GetAllKarateProducts();
        void UpdateKarateProducts(KarateProducts karateProducts);
        void DeleteKarateProducts(int id);
    }
}

