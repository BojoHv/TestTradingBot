using System.ComponentModel.DataAnnotations;

namespace TestTradingBot1.Models
{
    public class Bot
    {
        [Key]
        public int id { get; set; } // bot instance id
        [Required]
        public double initAmount { get; set; } // start balance
        //[Required]
        //public int leverage { get; set; }
        [Required]
        public double currAmount { get; set; }  // current balance
        [Required]
        [Range(0, 1)]
        public double tradePercent { get; set; }
        [Required]
        public DateTime dateOfCreation { get; set; }
        //public bool activePosition { get; set; }
        //public bool Status { get; set; }


        public void Buy(double initAmount, double currAmount)
        {
            //currAmount = currAmount - (*price*);
        }
        public void Sell(double initAmount, double currAmount)
        {
            //currAmount = currAmount + (*price*);
        }
        public void Status()
        {

        }


        public Bot(int id, int initAmount, double tradePercent, DateTime dateOfCreation)
        {
            this.id = id;
            this.initAmount = initAmount;
            this.currAmount = currAmount;
            //this.leverage = leverage;
            this.tradePercent = tradePercent;
            this.dateOfCreation = dateOfCreation;
        }
        public Bot()
        {

        }
    }
}
