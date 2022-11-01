<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace PCStore.Models
{
    public class customersModel
    {
        [Key]
=======
﻿namespace PCStore.Models
{
    public class customersModel
    {
>>>>>>> 08e829bc27e7c8f48bfe9df118c6c2ff3dafa3d5
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
    }
}
