using ModelsGNB;

namespace BussinesGNB.Interfaces
{
    public interface ITransactionsBL
    {

        public List<TransactionModel> viewAllTransactions();
        public TransactionModel viewTransaction(string SKU);

    }
}
