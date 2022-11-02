using System.ComponentModel.DataAnnotations;

namespace PCStore.Models
{
    public class orderModel
    {
        [Key]
        public int order_id { get; set; }
        public string order_status { get; set; }
        public string order_date { get; set; }
        public string required_date { get; set; }
        public string shipped_date { get; set; }

    }
}
