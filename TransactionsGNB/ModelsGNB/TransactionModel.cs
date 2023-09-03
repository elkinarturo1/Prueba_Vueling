using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsGNB
{
    public class TransactionModel
    {

        private string sku;
        private string amount;
        private string currency;

        public string getSku()
        {
            return this.sku;
        }

        public string getAmount()
        {
            return this.amount;
        }

        public string getCurrency()
        {
            return this.currency;
        }

    }
}
