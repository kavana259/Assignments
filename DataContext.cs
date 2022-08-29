using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;

namespace Procuct_Assignement
{
    public class DataContext
    {// declare field for filename with path
     // declare field for list of products


        List<Product> lp = new List<Product>();

        // the constructor should accept filename and path strings
        public DataContext(string name, string path)
        {
            // the constructor code should open file if it exists else create new
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            Stream stream = new FileStream(@"C:\Users\kahr\Documents\Product_Project\P1",FileMode.OpenOrCreate);
            stream.Close();

            // the code should read data from file if it contains any data

            // the data read should populate the list of products field

            // if no data is present an empty list should be created 

        }

        // this method should return the list of products read from file
       

        // this method should add the product data passed as parameter to the list of products
        public void AddProduct(Product p)
        {
            //p.ProductId = "001";
            //p.ProductName = C"Comb";
            //StreamWriter fileWrite = new StreamWriter(@"C:\Users\kahr\Documents\Product_Project");
            //fileWrite.WriteLine(lp.ProductId);
            //fileWrite.WriteLine(lp.Name);

            lp.Add(p);

        }
        public List<Product> ReadProducts()
        {
            // return data of the product list
            return lp;
        }

        // this method should write the data from list of products to file and make data persistent
        public void  SaveChanges(List<Product> lf)
        {
            // implement serialization

            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            Stream stream = new FileStream(@"C:\Users\kahr\Documents\Product_Project\p2",FileMode.OpenOrCreate);
            xml.Serialize(stream, lf);
            stream.Close();

        }

        // this method should delete the file if exists
        //public List<Product> CleanUp()
        //{

        //}
    }
}


    

