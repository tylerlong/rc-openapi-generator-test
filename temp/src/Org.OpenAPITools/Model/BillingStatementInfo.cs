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
    /// Billing information. Returned for device update request if &#x60;prestatement&#x60; query parameter is set to &#39;true&#39;
    /// </summary>
    [DataContract]
    public partial class BillingStatementInfo :  IEquatable<BillingStatementInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingStatementInfo" /> class.
        /// </summary>
        /// <param name="currency">Currency code complying with [ISO-4217](https://en.wikipedia.org/wiki/ISO_4217) standard.</param>
        /// <param name="charges">charges.</param>
        /// <param name="fees">fees.</param>
        /// <param name="totalCharged">totalCharged.</param>
        /// <param name="totalCharges">totalCharges.</param>
        /// <param name="totalFees">totalFees.</param>
        /// <param name="subtotal">subtotal.</param>
        /// <param name="totalFreeServiceCredit">totalFreeServiceCredit.</param>
        public BillingStatementInfo(string currency = default(string), List<BillingStatementCharges> charges = default(List<BillingStatementCharges>), List<BillingStatementFees> fees = default(List<BillingStatementFees>), decimal totalCharged = default(decimal), decimal totalCharges = default(decimal), decimal totalFees = default(decimal), decimal subtotal = default(decimal), decimal totalFreeServiceCredit = default(decimal))
        {
            this.Currency = currency;
            this.Charges = charges;
            this.Fees = fees;
            this.TotalCharged = totalCharged;
            this.TotalCharges = totalCharges;
            this.TotalFees = totalFees;
            this.Subtotal = subtotal;
            this.TotalFreeServiceCredit = totalFreeServiceCredit;
        }

        /// <summary>
        /// Currency code complying with [ISO-4217](https://en.wikipedia.org/wiki/ISO_4217) standard
        /// </summary>
        /// <value>Currency code complying with [ISO-4217](https://en.wikipedia.org/wiki/ISO_4217) standard</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Charges
        /// </summary>
        [DataMember(Name="charges", EmitDefaultValue=false)]
        public List<BillingStatementCharges> Charges { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public List<BillingStatementFees> Fees { get; set; }

        /// <summary>
        /// Gets or Sets TotalCharged
        /// </summary>
        [DataMember(Name="totalCharged", EmitDefaultValue=false)]
        public decimal TotalCharged { get; set; }

        /// <summary>
        /// Gets or Sets TotalCharges
        /// </summary>
        [DataMember(Name="totalCharges", EmitDefaultValue=false)]
        public decimal TotalCharges { get; set; }

        /// <summary>
        /// Gets or Sets TotalFees
        /// </summary>
        [DataMember(Name="totalFees", EmitDefaultValue=false)]
        public decimal TotalFees { get; set; }

        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public decimal Subtotal { get; set; }

        /// <summary>
        /// Gets or Sets TotalFreeServiceCredit
        /// </summary>
        [DataMember(Name="totalFreeServiceCredit", EmitDefaultValue=false)]
        public decimal TotalFreeServiceCredit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingStatementInfo {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  TotalCharged: ").Append(TotalCharged).Append("\n");
            sb.Append("  TotalCharges: ").Append(TotalCharges).Append("\n");
            sb.Append("  TotalFees: ").Append(TotalFees).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  TotalFreeServiceCredit: ").Append(TotalFreeServiceCredit).Append("\n");
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
            return this.Equals(input as BillingStatementInfo);
        }

        /// <summary>
        /// Returns true if BillingStatementInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingStatementInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingStatementInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Charges == input.Charges ||
                    this.Charges != null &&
                    input.Charges != null &&
                    this.Charges.SequenceEqual(input.Charges)
                ) && 
                (
                    this.Fees == input.Fees ||
                    this.Fees != null &&
                    input.Fees != null &&
                    this.Fees.SequenceEqual(input.Fees)
                ) && 
                (
                    this.TotalCharged == input.TotalCharged ||
                    (this.TotalCharged != null &&
                    this.TotalCharged.Equals(input.TotalCharged))
                ) && 
                (
                    this.TotalCharges == input.TotalCharges ||
                    (this.TotalCharges != null &&
                    this.TotalCharges.Equals(input.TotalCharges))
                ) && 
                (
                    this.TotalFees == input.TotalFees ||
                    (this.TotalFees != null &&
                    this.TotalFees.Equals(input.TotalFees))
                ) && 
                (
                    this.Subtotal == input.Subtotal ||
                    (this.Subtotal != null &&
                    this.Subtotal.Equals(input.Subtotal))
                ) && 
                (
                    this.TotalFreeServiceCredit == input.TotalFreeServiceCredit ||
                    (this.TotalFreeServiceCredit != null &&
                    this.TotalFreeServiceCredit.Equals(input.TotalFreeServiceCredit))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Charges != null)
                    hashCode = hashCode * 59 + this.Charges.GetHashCode();
                if (this.Fees != null)
                    hashCode = hashCode * 59 + this.Fees.GetHashCode();
                if (this.TotalCharged != null)
                    hashCode = hashCode * 59 + this.TotalCharged.GetHashCode();
                if (this.TotalCharges != null)
                    hashCode = hashCode * 59 + this.TotalCharges.GetHashCode();
                if (this.TotalFees != null)
                    hashCode = hashCode * 59 + this.TotalFees.GetHashCode();
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.TotalFreeServiceCredit != null)
                    hashCode = hashCode * 59 + this.TotalFreeServiceCredit.GetHashCode();
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
