/*
 * RingCentral Connect Platform API
 *
 * RingCentral Connect Platform API
 *
 * The version of the OpenAPI document: 1.0.48
 * Contact: platform@ringcentral.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// BillingStatementCharges
    /// </summary>
    [DataContract]
    public partial class BillingStatementCharges :  IEquatable<BillingStatementCharges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingStatementCharges" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="amount">amount.</param>
        /// <param name="feature">feature.</param>
        /// <param name="freeServiceCredit">freeServiceCredit.</param>
        public BillingStatementCharges(string description = default(string), decimal amount = default(decimal), string feature = default(string), decimal freeServiceCredit = default(decimal))
        {
            this.Description = description;
            this.Amount = amount;
            this.Feature = feature;
            this.FreeServiceCredit = freeServiceCredit;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets Feature
        /// </summary>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public string Feature { get; set; }

        /// <summary>
        /// Gets or Sets FreeServiceCredit
        /// </summary>
        [DataMember(Name="freeServiceCredit", EmitDefaultValue=false)]
        public decimal FreeServiceCredit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingStatementCharges {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  FreeServiceCredit: ").Append(FreeServiceCredit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillingStatementCharges);
        }

        /// <summary>
        /// Returns true if BillingStatementCharges instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingStatementCharges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingStatementCharges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Feature == input.Feature ||
                    (this.Feature != null &&
                    this.Feature.Equals(input.Feature))
                ) && 
                (
                    this.FreeServiceCredit == input.FreeServiceCredit ||
                    (this.FreeServiceCredit != null &&
                    this.FreeServiceCredit.Equals(input.FreeServiceCredit))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Feature != null)
                    hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.FreeServiceCredit != null)
                    hashCode = hashCode * 59 + this.FreeServiceCredit.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
