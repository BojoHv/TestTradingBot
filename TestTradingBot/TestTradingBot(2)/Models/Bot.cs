namespace TestTradingBot_2_.Models
{
    public class Bot
    {
        public int id { get; set; }
        public double initAmount { get; set; }
        //public int leverage { get; set; }
        public double tradePercent { get; set; }
        public DateTime dateOfCreation { get; set; }

        public Bot(int id, int initAmount, double tradePercent, DateTime dateOfCreation)
        {
            this.id = id;
            this.initAmount = initAmount;
            //this.leverage = leverage;
            this.tradePercent = tradePercent;
            this.dateOfCreation = dateOfCreation;
        }

        public Bot()
        {

        }
    }
}
