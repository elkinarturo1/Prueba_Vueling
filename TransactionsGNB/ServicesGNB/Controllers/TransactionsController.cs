using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsGNB;
using BussinesGNB.BL;
using BussinesGNB.Interfaces;

namespace ServicesGNB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {

        ITransactionsBL servicioBL = new TransactionsServicesBL();

        [HttpGet]
        [Route("viewAllTransactions")]
        public List<TransactionModel> viewAllTransactions()
        {
          return servicioBL.viewAllTransactions();
        }


        [HttpGet]
        [Route("viewTransaction")]
        public TransactionModel viewTransactions(string SKU)
        {
            return servicioBL.viewTransaction(SKU);
        }

    }
}
