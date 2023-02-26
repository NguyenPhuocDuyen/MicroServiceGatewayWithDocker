using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace MicoserviceAPI_Docker.Models
{
    public class Customer
    {
        [Key]
        public int cus_id { get; set; }
        public string cus_name { get; set; }
        public string cus_address { get; set; }
    }
}
