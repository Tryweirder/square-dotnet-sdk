using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square.Http.Client;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class CreateOrderResponse 
    {
        public CreateOrderResponse(Models.Order order = null,
            IList<Models.Error> errors = null)
        {
            Order = order;
            Errors = errors;
        }

        [JsonIgnore]
        public HttpContext Context { get; internal set; }

        /// <summary>
        /// Contains all information related to a single order to process with Square,
        /// including line items that specify the products to purchase. Order objects also
        /// include information on any associated tenders, refunds, and returns.
        /// All Connect V2 Transactions have all been converted to Orders including all associated
        /// itemization data.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Order Order { get; }

        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Error> Errors { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Order(Order)
                .Errors(Errors);
            return builder;
        }

        public class Builder
        {
            private Models.Order order;
            private IList<Models.Error> errors;



            public Builder Order(Models.Order order)
            {
                this.order = order;
                return this;
            }

            public Builder Errors(IList<Models.Error> errors)
            {
                this.errors = errors;
                return this;
            }

            public CreateOrderResponse Build()
            {
                return new CreateOrderResponse(order,
                    errors);
            }
        }
    }
}