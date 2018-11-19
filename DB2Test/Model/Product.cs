using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Product model
 * 
 * 
 */

namespace DB2Test
{
    class Product
    {
        public String materialId; // nome do material
        public String materialDesc; // descrição do material
        
        public Product(ArrayList arrayProductList) 
        {
            this.materialId = arrayProductList[0].ToString(); // Produto
            this.materialDesc = arrayProductList[1].ToString(); // Descrição
        }
    }
}
