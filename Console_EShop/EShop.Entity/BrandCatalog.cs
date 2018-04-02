using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Entity
{
    public class BrandCatalog
    {
        public List<string> BrandItems { get; private set; }


        public BrandCatalog()
        {
            BrandItems = new List<string>() { "Nike", "Adidas" };
            
        }
    }
}
