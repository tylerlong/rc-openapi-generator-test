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
    /// AnalyticsLegacyPerformanceCallsSegments
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyPerformanceCallsSegments :  IEquatable<AnalyticsLegacyPerformanceCallsSegments>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=true)]
        public AnalyticsLegacyValueTypes ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsSegments" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyPerformanceCallsSegments() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsSegments" /> class.
        /// </summary>
        /// <param name="valueType">valueType (required).</param>
        /// <param name="values">values (required).</param>
        public AnalyticsLegacyPerformanceCallsSegments(AnalyticsLegacyValueTypes valueType = default(AnalyticsLegacyValueTypes), AnalyticsLegacyCallsSegments values = default(AnalyticsLegacyCallsSegments))
        {
            // to ensure "valueType" is required (not null)
            if (valueType == null)
            {
                throw new InvalidDataException("valueType is a required property for AnalyticsLegacyPerformanceCallsSegments and cannot be null");
            }
            else
            {
                this.ValueType = valueType;
            }

            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new InvalidDataException("values is a required property for AnalyticsLegacyPerformanceCallsSegments and cannot be null");
            }
            else
            {
                this.Values = values;
            }

        }


        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=true)]
        public AnalyticsLegacyCallsSegments Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyPerformanceCallsSegments {\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyPerformanceCallsSegments);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyPerformanceCallsSegments instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyPerformanceCallsSegments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyPerformanceCallsSegments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.Values == input.Values ||
                    (this.Values != null &&
                    this.Values.Equals(input.Values))
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
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
