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
    /// Aggregation of calls count by queue SLA (InSLA, OutSLA). This counter is only applicable to Queues grouping
    /// </summary>
    [DataContract]
    public partial class AggregationResponseOptionsCountersCallsByQueueSla :  IEquatable<AggregationResponseOptionsCountersCallsByQueueSla>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AggregationType
        /// </summary>
        [DataMember(Name="aggregationType", EmitDefaultValue=true)]
        public AggregationType AggregationType { get; set; }
        /// <summary>
        /// Gets or Sets AggregationInterval
        /// </summary>
        [DataMember(Name="aggregationInterval", EmitDefaultValue=false)]
        public AggregationInterval? AggregationInterval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationResponseOptionsCountersCallsByQueueSla" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AggregationResponseOptionsCountersCallsByQueueSla() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationResponseOptionsCountersCallsByQueueSla" /> class.
        /// </summary>
        /// <param name="aggregationType">aggregationType (required).</param>
        /// <param name="aggregationInterval">aggregationInterval.</param>
        public AggregationResponseOptionsCountersCallsByQueueSla(AggregationType aggregationType = default(AggregationType), AggregationInterval? aggregationInterval = default(AggregationInterval?))
        {
            // to ensure "aggregationType" is required (not null)
            if (aggregationType == null)
            {
                throw new InvalidDataException("aggregationType is a required property for AggregationResponseOptionsCountersCallsByQueueSla and cannot be null");
            }
            else
            {
                this.AggregationType = aggregationType;
            }

            this.AggregationInterval = aggregationInterval;
        }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregationResponseOptionsCountersCallsByQueueSla {\n");
            sb.Append("  AggregationType: ").Append(AggregationType).Append("\n");
            sb.Append("  AggregationInterval: ").Append(AggregationInterval).Append("\n");
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
            return this.Equals(input as AggregationResponseOptionsCountersCallsByQueueSla);
        }

        /// <summary>
        /// Returns true if AggregationResponseOptionsCountersCallsByQueueSla instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregationResponseOptionsCountersCallsByQueueSla to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationResponseOptionsCountersCallsByQueueSla input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregationType == input.AggregationType ||
                    (this.AggregationType != null &&
                    this.AggregationType.Equals(input.AggregationType))
                ) && 
                (
                    this.AggregationInterval == input.AggregationInterval ||
                    (this.AggregationInterval != null &&
                    this.AggregationInterval.Equals(input.AggregationInterval))
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
                if (this.AggregationType != null)
                    hashCode = hashCode * 59 + this.AggregationType.GetHashCode();
                if (this.AggregationInterval != null)
                    hashCode = hashCode * 59 + this.AggregationInterval.GetHashCode();
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
