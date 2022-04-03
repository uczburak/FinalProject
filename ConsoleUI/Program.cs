﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

            GetDetailsDtoTest();
        }

        private static void GetDetailsDtoTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if(result.Success)
            {
                foreach (var detail in result.Data)
                {
                    Console.WriteLine(detail.ProductName + " / " + detail.CategoryName);
                }
            }else
                Console.WriteLine(result.Message);
            
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(50, 100).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
