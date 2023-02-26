using System.ComponentModel.DataAnnotations;

namespace microservice2.Models
{
    public class Product
    {
        [Key]
        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public string pro_address { get; set; }
    }
}
