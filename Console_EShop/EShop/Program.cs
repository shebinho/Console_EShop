using System;
using System.Collections.Generic;
using EShop.Entity;


namespace EShop
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Login();
        }

        public static void Login()
        {
            var brandCatalog = new BrandCatalog().BrandItems;
            var productCatalog = new ProductCatalog().ProductItems;

            Console.WriteLine("Enter your username: ");
            var userName = Console.ReadLine();
            var user = new User(userName);
            var userOrders = new User().UserOrder;
            var userShopping = true;

            while (userShopping)
            {
                Console.WriteLine("1. See the list for Vendors");
                Console.WriteLine("2. Search by Vendor Name");
                Console.WriteLine("3. Create a Order");
                Console.WriteLine("4. My Current Order ");
                Console.WriteLine("5. Remove Order");
                Console.WriteLine("6. My Final Order");
                Console.WriteLine("7. Exit the app");


                int userInput = 0;
                bool validInput = Int32.TryParse(Console.ReadLine(), out userInput);
                if (validInput == false || userInput > 8 || userInput < 1)
                {
                    Console.WriteLine("Your Input is Invalid!");
                }

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("List of Vendors: ");
                        foreach (var vendor in brandCatalog)
                        {
                            Console.WriteLine(vendor);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Adidas or Nike");
                        var productBrand = Console.ReadLine().ToLower();
                        foreach (var product in productCatalog[productBrand])
                        {
                            Console.WriteLine($"Product Code Product Name Product Price\n{product.ProductCode} {product.ProductName} {product.Price} ");
                        }
                        break;

                    case 3:

                        bool activeOrder = true;
                        while (activeOrder)
                        {
                            Console.WriteLine("Enter your Product Code");
                            var inputProductCode = Console.ReadLine().ToUpper();
                            Console.WriteLine("Enter Quantity");
                            var inputQuantity = int.Parse(Console.ReadLine());

                            foreach (var product in productCatalog)
                            {
                                var productCode = product.Value.Find(c => c.ProductCode == inputProductCode);

                                if (productCode != null)
                                {
                                    double totalProductPrice = inputQuantity * productCode.Price;

                                    var newOrder = new Order(new ProductCatalog(
                                        productCode.ProductCode,
                                        productCode.ProductName,
                                        productCode.Price),
                                        inputQuantity, totalProductPrice);
                                    userOrders.Add(newOrder);

                                }
                            }

                            Console.WriteLine("If you are finished enter \"yes\" or enter \"no\" ");
                            activeOrder = Console.ReadLine() == "yes" ? true : false;

                        }
                        break;

                    case 4:

                        if (userOrders.Count == 0)
                        {
                            Console.WriteLine("You don't have orders");
                        }

                        else
                        {
                            Console.WriteLine("Your current Order:");

                            foreach (var orderedProduct in userOrders)
                            {
                                Console.WriteLine($"Product Code Product Name Product Price Quantity Total Price\n{orderedProduct.Product.ProductCode} {orderedProduct.Product.ProductName} {orderedProduct.Product.Price} {orderedProduct.Quantity} {orderedProduct.TotalProductPrice} ");
                            }
                        }
                        break;





                }


            }

        }
    }
}
