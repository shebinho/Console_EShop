using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Entity
{
    public class ProductCatalog
    {

        public string ProductCode { get; private set; }

        public string ProductName { get; private set; }

        public int Price { get; private set; }

        

        public Dictionary<string, List<ProductCatalog>> ProductItems { get; private set; }

        public ProductCatalog(string productCode,string productName,int price)
        {
            ProductCode = productCode;
            ProductName = productName;
            Price = price;

            ProductItems = new Dictionary<string, List<ProductCatalog>>();
            ProductItems.Add("nike", new List<ProductCatalog>()
            {
                new ProductCatalog("US-BSEMBQX","LEBRON 15 LOW SUPERNOVA",150),
                new ProductCatalog("US-NLPNEK","NIKE AIR MAX 90 PREMIUM",130),
                new ProductCatalog("US-NLEZHX","NIKE AIR MAX 270 FLYKNIT",170),
                new ProductCatalog("US-SSCMKQ","NIKE MERCURIAL SUPERFLY 360 ELITE CR7 FG",300),
                new ProductCatalog("US-BSHFWL","KOBE A.D. THE MOMENT",150),
            });


            ProductItems.Add("adidas", new List<ProductCatalog>()
            {
                new ProductCatalog("A-US-AOR-W","DEERUPT RUNNER SHOES",100),
                new ProductCatalog("A-US-AOL-M","PHARRELL WILLIAMS TENNIS HU PRIMEKNIT SHOES",130),
                new ProductCatalog("A-US-BH2-M","HARDEN VOL. 2 SHOES",150),
                new ProductCatalog("A-US-AOW-W","EQT BASKETBALL ADV SHOES",120),
                new ProductCatalog("A-US-ARW-W","ADIZERO UBERSONIC 3.0 SHOES",120),
            });

        }

        public ProductCatalog()
        {

        }

        
    }
}
