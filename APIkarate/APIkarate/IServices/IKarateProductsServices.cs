﻿
using Entities.Entities;

namespace APIService.IServices
{
    public interface IKarateProductsServices
    {
        int InsertKarateProducts(KarateProducts KarateProducts);
        List<KarateProducts> GetAllKarateProducts();
        void DeleteKarateProducts(int id);
        void UpdateKarateProducts(KarateProducts karateProducts);
    }
}