using System;
using System.Collections.Generic;
using System.Text;

namespace Procuct_Assignement

{
    /*
     * this serializable class models product data that includes product id, product name, price and in-stock status
     */

    public class Product
    {
        /*
         * define properties for Product model attributes 
         */

        public int ProductId;
        public string ProductName;
        public int Price;
        public bool Instock;


        /*
         * Override ToString() method to return string equivalent of product object containing product details
         * 
         */
        public override string ToString()
        {
            return @$"Product Id :{ProductId} 
Product Name :{ProductName}
Product Price : {Price}
InStock :{Instock}
";
        }
    }
}
