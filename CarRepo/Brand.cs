using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepo
{
    class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        
    }
    class Model
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public int BrandId { get; set; }
    }
}
