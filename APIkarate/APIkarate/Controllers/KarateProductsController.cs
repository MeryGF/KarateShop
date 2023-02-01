using APIService.IServices;
using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KarateProductsController : ControllerBase
    {
        private readonly ILogger<KarateProductsController> _logger;
        private readonly KarateProductsIServices _KarateProductsServices;
        public KarateProductsController(ILogger<KarateProductsController> logger, KarateProductsServices KarateProductsServices)
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
    }
}
