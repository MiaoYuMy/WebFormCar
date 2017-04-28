using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepo
{
    public class Class1
    {
        List<Brand> brandList = new List<Brand>()
        {
            new Brand() {BrandId=0,BrandName="Select" },
            new Brand() {BrandId=1,BrandName="Nissan" },
            new Brand() {BrandId=2,BrandName="Toyota" },
            new Brand() {BrandId=3,BrandName="BMW" },
            new Brand() {BrandId=4,BrandName="Benz" }
        };
        List<Model> modelList = new List<Model>()
        {
            new Model() {ModelId=0,ModelName="Select",BrandId=0,Price=0 },
            new Model() {ModelId=101,ModelName="Rogue",BrandId=1,Price=25000M },
            new Model() {ModelId=102,ModelName="Pathfinder",BrandId=1,Price=35000M },
            new Model() {ModelId=103,ModelName="Maxima",BrandId=1,Price=45000M },
            new Model() {ModelId=201,ModelName="FJ Cruiser",BrandId=2,Price=50000M },
            new Model() {ModelId=202,ModelName="RAV4",BrandId=2,Price=25000 },
            new Model() {ModelId=203,ModelName="Camry",BrandId=2,Price=20000 },
            new Model() {ModelId=301,ModelName="X6",BrandId=3,Price=70000 },
            new Model() {ModelId=302,ModelName="R4",BrandId=3,Price=50000 },
            new Model() {ModelId=401,ModelName="G630",BrandId=4,Price=90000 },
            new Model() {ModelId=402,ModelName="GLK500",BrandId=4,Price=60000 }
        };
        public Dictionary<string,int> GetAllBrands()
        {
            Dictionary<string, int> brandDic = new Dictionary<string, int>();
            foreach(var item in brandList)
            {
                brandDic.Add(item.BrandName, item.BrandId);
            }
            return brandDic;
        }
        //Dictionary<string,int> brandDic=
        //public Dictionary<string,int> GetSpecificModels(int brandId)
        //{
        //    foreach (var item in brandList)
        //    {
                
        //    }
        //}
        public Dictionary<string,int> GetAllModels(int brandId)
        {
            Dictionary<string, int> modelDic = new Dictionary<string, int>();
            foreach (var item in modelList.Where(x => x.BrandId == brandId))
            {
                //modelList.Where(x=>x.BrandId==brandId)
                
                modelDic.Add(item.ModelName, item.ModelId);
            }
            return modelDic;
        }
        public decimal GetPriceById(int id)
        {
            return modelList.Where(x => x.ModelId == id).FirstOrDefault().Price;
        }
        public decimal GetTotal(int id, int qty)
        {
            return GetPriceById(id) * qty;
        }
    }

}
