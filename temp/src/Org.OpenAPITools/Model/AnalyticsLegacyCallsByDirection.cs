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
    /// AnalyticsLegacyCallsByDirection
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyCallsByDirection :  IEquatable<AnalyticsLegacyCallsByDirection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyCallsByDirection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyCallsByDirection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyCallsByDirection" /> class.
        /// </summary>
        /// <param name="inbound">inbound (required).</param>
        /// <param name="outbound">outbound (required).</param>
        public AnalyticsLegacyCallsByDirection(double inbound = default(double), double outbound = default(double))
        {
            // to ensure "inbound" is required (not null)
            if (inbound == null)
            {
                throw new InvalidDataException("inbound is a required property for AnalyticsLegacyCallsByDirection and cannot be null");
            }
            else
            {
                this.Inbound = inbound;
            }

            // to ensure "outbound" is required (not null)
            if (outbound == null)
            {
                throw new InvalidDataException("outbound is a required property for AnalyticsLegacyCallsByDirection and cannot be null");
            }
            else
            {
                this.Outbound = outbound;
            }

        }

        /// <summary>
        /// Gets or Sets Inbound
        /// </summary>
        [DataMember(Name="inbound", EmitDefaultValue=true)]
        public double Inbound { get; set; }

        /// <summary>
        /// Gets or Sets Outbound
        /// </summary>
        [DataMember(Name="outbound", EmitDefaultValue=true)]
        public double Outbound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyCallsByDirection {\n");
            sb.Append("  Inbound: ").Append(Inbound).Append("\n");
            sb.Append("  Outbound: ").Append(Outbound).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyCallsByDirection);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyCallsByDirection instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyCallsByDirection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyCallsByDirection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Inbound == input.Inbound ||
                    (this.Inbound != null &&
                    this.Inbound.Equals(input.Inbound))
                ) && 
                (
                    this.Outbound == input.Outbound ||
                    (this.Outbound != null &&
                    this.Outbound.Equals(input.Outbound))
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
                if (this.Inbound != null)
                    hashCode = hashCode * 59 + this.Inbound.GetHashCode();
                if (this.Outbound != null)
                    hashCode = hashCode * 59 + this.Outbound.GetHashCode();
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