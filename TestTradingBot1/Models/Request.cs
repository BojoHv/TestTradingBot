using System.ComponentModel.DataAnnotations;

namespace TestTradingBot1.Models
{
    public class Request
    {
        [Key]
        public int id { get; set; } // bot instance id
        [Required]
        public double initAmount { get; set; } // start balance
        //[Required]
        //public int leverage { get; set; }
        [Required]
        [Range(0, 1)]
        public double tradePercent { get; set; }
    }
}
