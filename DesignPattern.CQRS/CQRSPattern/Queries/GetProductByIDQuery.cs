namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public GetProductByIDQuery(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
