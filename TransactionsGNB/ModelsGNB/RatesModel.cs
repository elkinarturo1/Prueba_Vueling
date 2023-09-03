using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsGNB
{
    public class RatesModel
    {   
        private string from { get; set; }
        private string to { get; set; }
        private string rate { get; set; }

        public string getFrom()
        {
            return this.from;
        }

        public string getTo()
        {
            return this.to;
        }

        public string getRate()
        {
            return this.rate;
        }

    }
}
