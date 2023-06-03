namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class RemoveProductCommand
    {
        public RemoveProductCommand(int iD)
        {
            ID = iD;
        }

        public int ID { get; set; }
    }
}
