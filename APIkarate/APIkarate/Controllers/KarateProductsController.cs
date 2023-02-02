using APIService.IServices;
//using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
//using System.Xml.Linq;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KarateProductsController : ControllerBase
    {
        private readonly ILogger<KarateProductsController> _logger;
        private readonly IKarateProductsServices _KarateProductsServices;
        public KarateProductsController(ILogger<KarateProductsController> logger, IKarateProductsServices KarateProductsServices)
        {
            _logger = logger;
            _KarateProductsServices = KarateProductsServices;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] KarateProducts KarateProducts)
        {
            //     _userService.ValidateCredentials(userItem);
            return _KarateProductsServices.InsertKarateProducts(KarateProducts);
        }
        [HttpGet(Name = "GetAllProducts")]
        public List<KarateProducts> GetAllKarateProducts()
        {
            //_KarateProductsServices.ValidateCredentials(KarateProducts);
            return _KarateProductsServices.GetAllKarateProducts();
        }
        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromBody] KarateProducts karateProducts)
        {
            _KarateProductsServices.UpdateKarateProducts(karateProducts);
        }
        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromQuery] int id)
        {
            _KarateProductsServices.DeleteKarateProducts(id);
        }
    }
}



 