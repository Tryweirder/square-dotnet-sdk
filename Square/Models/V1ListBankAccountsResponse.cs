using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class V1ListBankAccountsResponse 
    {
        public V1ListBankAccountsResponse(IList<Models.V1BankAccount> items = null)
        {
            Items = items;
        }

        /// <summary>
        /// Getter for items
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.V1BankAccount> Items { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Items(Items);
            return builder;
        }

        public class Builder
        {
            private IList<Models.V1BankAccount> items;



            public Builder Items(IList<Models.V1BankAccount> items)
            {
                this.items = items;
                return this;
            }

            public V1ListBankAccountsResponse Build()
            {
                return new V1ListBankAccountsResponse(items);
            }
        }
    }
}