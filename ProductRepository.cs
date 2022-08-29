using System;
using System.Collections.Generic;
using System.Text;

namespace Procuct_Assignement
{
    public class ProductRepository
    {
        List<Product> pro= new List<Product>();

        public ProductRepository(Product p)
        {
            p.ProductId = 1;
            p.ProductName = "Joe";
            p.Price = 100;
            p.Instock = true;
           
        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public  void AddProduct(Product p)
        {
            //// code to add product to file, ensuring that product is not null

            ////Console.WriteLine("Give Product ID and name");
            //p.ProductId = "001";
            //p.ProductName = C"Comb";
            //StreamWriter fileWrite = new StreamWriter(@"C:\Users\kahr\Documents\Product_Project");
            //fileWrite.WriteLine(lp.ProductId);
            //fileWrite.WriteLine(lp.Name);
            pro.Add(p);
        }


        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public void RemoveProduct(Product p,int removeId)
        {
            // code to remove product by the id provided from file as parameter

            if (removeId == p.ProductId)
            {
                pro.Remove(p);
            }
        }

        /*
         * this method should search and return product by product name from the file 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product name
         */
        //public <return_type> GetProduct(<parameter>)
        //{

        //}

        /*
         * this method should search and return product by product id from the collection 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product id
         */
        //public <return_type> GetProduct(<parameter>)
        //{

        //}


        /*
         * this method should return all items from the product collection
         */
        public List<Product> GetAllProducts()
        {
            return pro;
        }
    }
}
