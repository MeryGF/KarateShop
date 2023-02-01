using System;

namespace Entities.Entities 
{ 
	public class KarateProducts
	{
        public KarateProducts()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ProductName { get; set; }
        public string TypeProduct { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
   
    }
}