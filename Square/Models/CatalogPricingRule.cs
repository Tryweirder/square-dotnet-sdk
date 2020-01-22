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
    public class CatalogPricingRule 
    {
        public CatalogPricingRule(string name = null,
            IList<string> timePeriodIds = null,
            string discountId = null,
            string matchProductsId = null,
            string applyProductsId = null,
            string excludeProductsId = null,
            string validFromDate = null,
            string validFromLocalTime = null,
            string validUntilDate = null,
            string validUntilLocalTime = null,
            string excludeStrategy = null)
        {
            Name = name;
            TimePeriodIds = timePeriodIds;
            DiscountId = discountId;
            MatchProductsId = matchProductsId;
            ApplyProductsId = applyProductsId;
            ExcludeProductsId = excludeProductsId;
            ValidFromDate = validFromDate;
            ValidFromLocalTime = validFromLocalTime;
            ValidUntilDate = validUntilDate;
            ValidUntilLocalTime = validUntilLocalTime;
            ExcludeStrategy = excludeStrategy;
        }

        /// <summary>
        /// User-defined name for the pricing rule. For example, "Buy one get one
        /// free" or "10% off".
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// A list of unique IDs for the catalog time periods when
        /// this pricing rule is in effect. If left unset, the pricing rule is always
        /// in effect.
        /// </summary>
        [JsonProperty("time_period_ids")]
        public IList<string> TimePeriodIds { get; }

        /// <summary>
        /// Unique ID for the `CatalogDiscount` to take off
        /// the price of all matched items.
        /// </summary>
        [JsonProperty("discount_id")]
        public string DiscountId { get; }

        /// <summary>
        /// Unique ID for the `CatalogProductSet` that will be matched by this rule.
        /// A match rule matches within the entire cart.
        /// A match rule can match multiple times in the cart.
        /// If no `ProductSet` is present, the rule will match all products.
        /// </summary>
        [JsonProperty("match_products_id")]
        public string MatchProductsId { get; }

        /// <summary>
        /// __Deprecated__: Please use the `exclude_products_id` field to apply
        /// an exclude set instead. Exclude sets allow better control over quantity
        /// ranges and offer more flexibility for which matched items receive a discount.
        /// `CatalogProductSet` to apply the pricing to.
        /// An apply rule matches within the subset of the cart that fits the match rules (the match set).
        /// An apply rule can only match once in the match set.
        /// If not supplied, the pricing will be applied to all products in the match set.
        /// Other products retain their base price, or a price generated by other rules.
        /// </summary>
        [JsonProperty("apply_products_id")]
        public string ApplyProductsId { get; }

        /// <summary>
        /// `CatalogProductSet` to exclude from the pricing rule.
        /// An exclude rule matches within the subset of the cart that fits the match rules (the match set).
        /// An exclude rule can only match once in the match set.
        /// If not supplied, the pricing will be applied to all products in the match set.
        /// Other products retain their base price, or a price generated by other rules.
        /// </summary>
        [JsonProperty("exclude_products_id")]
        public string ExcludeProductsId { get; }

        /// <summary>
        /// Represents the date the Pricing Rule is valid from. Represented in RFC3339 full-date format (YYYY-MM-DD).
        /// </summary>
        [JsonProperty("valid_from_date")]
        public string ValidFromDate { get; }

        /// <summary>
        /// Represents the local time the pricing rule should be valid from. Represented in RFC3339 partial-time format
        /// (HH:MM:SS). Partial seconds will be truncated.
        /// </summary>
        [JsonProperty("valid_from_local_time")]
        public string ValidFromLocalTime { get; }

        /// <summary>
        /// Represents the date the Pricing Rule is valid until. Represented in RFC3339 full-date format (YYYY-MM-DD).
        /// </summary>
        [JsonProperty("valid_until_date")]
        public string ValidUntilDate { get; }

        /// <summary>
        /// Represents the local time the pricing rule should be valid until. Represented in RFC3339 partial-time format
        /// (HH:MM:SS). Partial seconds will be truncated.
        /// </summary>
        [JsonProperty("valid_until_local_time")]
        public string ValidUntilLocalTime { get; }

        /// <summary>
        /// Indicates which products matched by a CatalogPricingRule
        /// will be excluded if the pricing rule uses an exclude set.
        /// </summary>
        [JsonProperty("exclude_strategy")]
        public string ExcludeStrategy { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Name(Name)
                .TimePeriodIds(TimePeriodIds)
                .DiscountId(DiscountId)
                .MatchProductsId(MatchProductsId)
                .ApplyProductsId(ApplyProductsId)
                .ExcludeProductsId(ExcludeProductsId)
                .ValidFromDate(ValidFromDate)
                .ValidFromLocalTime(ValidFromLocalTime)
                .ValidUntilDate(ValidUntilDate)
                .ValidUntilLocalTime(ValidUntilLocalTime)
                .ExcludeStrategy(ExcludeStrategy);
            return builder;
        }

        public class Builder
        {
            private string name;
            private IList<string> timePeriodIds = new List<string>();
            private string discountId;
            private string matchProductsId;
            private string applyProductsId;
            private string excludeProductsId;
            private string validFromDate;
            private string validFromLocalTime;
            private string validUntilDate;
            private string validUntilLocalTime;
            private string excludeStrategy;

            public Builder() { }
            public Builder Name(string value)
            {
                name = value;
                return this;
            }

            public Builder TimePeriodIds(IList<string> value)
            {
                timePeriodIds = value;
                return this;
            }

            public Builder DiscountId(string value)
            {
                discountId = value;
                return this;
            }

            public Builder MatchProductsId(string value)
            {
                matchProductsId = value;
                return this;
            }

            public Builder ApplyProductsId(string value)
            {
                applyProductsId = value;
                return this;
            }

            public Builder ExcludeProductsId(string value)
            {
                excludeProductsId = value;
                return this;
            }

            public Builder ValidFromDate(string value)
            {
                validFromDate = value;
                return this;
            }

            public Builder ValidFromLocalTime(string value)
            {
                validFromLocalTime = value;
                return this;
            }

            public Builder ValidUntilDate(string value)
            {
                validUntilDate = value;
                return this;
            }

            public Builder ValidUntilLocalTime(string value)
            {
                validUntilLocalTime = value;
                return this;
            }

            public Builder ExcludeStrategy(string value)
            {
                excludeStrategy = value;
                return this;
            }

            public CatalogPricingRule Build()
            {
                return new CatalogPricingRule(name,
                    timePeriodIds,
                    discountId,
                    matchProductsId,
                    applyProductsId,
                    excludeProductsId,
                    validFromDate,
                    validFromLocalTime,
                    validUntilDate,
                    validUntilLocalTime,
                    excludeStrategy);
            }
        }
    }
}