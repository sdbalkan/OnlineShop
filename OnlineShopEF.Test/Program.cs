using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShopEF.DAL;

namespace OnlineShopEF.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UnitOfWorkEF uow = new UnitOfWorkEF())
            {
                Category category = new Category()
                {
                    CategoryName = "Cep Telefonu",
                };
                uow.Repository<Category>().Add(category);

                Product product = new Product()
                {
                    ProductName = "IPhone 5",
                    CategoryID = category.CategoryID,
                };
                uow.Repository<Product>().Add(product);

                product = new Product()
                {
                    ProductName = "Samsung S4",
                    CategoryID = category.CategoryID,
                };
                uow.Repository<Product>().Add(product);

                uow.Save();
            }
        }
    }
}
