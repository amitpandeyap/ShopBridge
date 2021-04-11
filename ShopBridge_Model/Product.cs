using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopBridge_Model
{
    #region Product Model Class
    [Table("tblProductDetails")]
    public class Product
    {
        [Key]
        public  int Id { get; set; }

        //Name of the Product/item
        [Required]
        public string Name { get; set; }

        //Name of the Product Description
        [Required]
        public string Description { get; set; }

        //Name of the Product Price
        [Required]
        public string Price { get; set; }
    }
    #endregion
}
