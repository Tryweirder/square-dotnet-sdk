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
    public class UpdateItemTaxesRequest 
    {
        public UpdateItemTaxesRequest(IList<string> itemIds,
            IList<string> taxesToEnable = null,
            IList<string> taxesToDisable = null)
        {
            ItemIds = itemIds;
            TaxesToEnable = taxesToEnable;
            TaxesToDisable = taxesToDisable;
        }

        /// <summary>
        /// IDs for the CatalogItems associated with the CatalogTax objects being updated.
        /// </summary>
        [JsonProperty("item_ids")]
        public IList<string> ItemIds { get; }

        /// <summary>
        /// IDs of the CatalogTax objects to enable.
        /// </summary>
        [JsonProperty("taxes_to_enable", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> TaxesToEnable { get; }

        /// <summary>
        /// IDs of the CatalogTax objects to disable.
        /// </summary>
        [JsonProperty("taxes_to_disable", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> TaxesToDisable { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder(ItemIds)
                .TaxesToEnable(TaxesToEnable)
                .TaxesToDisable(TaxesToDisable);
            return builder;
        }

        public class Builder
        {
            private IList<string> itemIds;
            private IList<string> taxesToEnable;
            private IList<string> taxesToDisable;

            public Builder(IList<string> itemIds)
            {
                this.itemIds = itemIds;
            }

            public Builder ItemIds(IList<string> itemIds)
            {
                this.itemIds = itemIds;
                return this;
            }

            public Builder TaxesToEnable(IList<string> taxesToEnable)
            {
                this.taxesToEnable = taxesToEnable;
                return this;
            }

            public Builder TaxesToDisable(IList<string> taxesToDisable)
            {
                this.taxesToDisable = taxesToDisable;
                return this;
            }

            public UpdateItemTaxesRequest Build()
            {
                return new UpdateItemTaxesRequest(itemIds,
                    taxesToEnable,
                    taxesToDisable);
            }
        }
    }
}