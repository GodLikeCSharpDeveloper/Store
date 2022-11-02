using System.ComponentModel.DataAnnotations;

namespace PCStore.Models
{
    public class brandsModel
    {
        [Key]
        public int brand_id { get; set; }
        public string brand_name { get; set; }
        
    }
}
