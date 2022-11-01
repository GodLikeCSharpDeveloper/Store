<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace PCStore.Models
{
    public class orderModel
    {
        [Key]
=======
﻿namespace PCStore.Models
{
    public class orderModel
    {
>>>>>>> 08e829bc27e7c8f48bfe9df118c6c2ff3dafa3d5
        public int order_id { get; set; }
        public string order_status { get; set; }
        public string order_date { get; set; }
        public string required_date { get; set; }
        public string shipped_date { get; set; }

    }
}
