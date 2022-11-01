<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace PCStore.Models
{
    public class brandsModel
    {
        [Key]
        public int brand_id { get; set; }
        public string brand_name { get; set; }
       
=======
﻿namespace PCStore.Models
{
    public class brandsModel
    {



        public int product_id { get; set; }
        public string product_name { get; set; }
        public string model_year { get; set; }
        public int list_price { get; set; }

>>>>>>> 08e829bc27e7c8f48bfe9df118c6c2ff3dafa3d5
    }
}
