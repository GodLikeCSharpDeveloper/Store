using System.ComponentModel.DataAnnotations;

namespace PCStore.Models
{
    public class categoryModel
    {
        [Key]
        public int category_id { get; set; }
        public string category_name { get; set; }
    }
}
