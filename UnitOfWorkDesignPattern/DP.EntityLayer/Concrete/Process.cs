namespace DP.EntityLayer.Concrete
{
    public class Process
    {
        public int ProcessID { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public decimal Amount { get; set; }
    }
}
