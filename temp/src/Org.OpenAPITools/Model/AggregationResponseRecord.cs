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
    /// AggregationResponseRecord
    /// </summary>
    [DataContract]
    public partial class AggregationResponseRecord :  IEquatable<AggregationResponseRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationResponseRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AggregationResponseRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationResponseRecord" /> class.
        /// </summary>
        /// <param name="key">Grouping key (required).</param>
        /// <param name="info">info.</param>
        /// <param name="timers">timers.</param>
        /// <param name="counters">counters.</param>
        public AggregationResponseRecord(string key = default(string), KeyInfo info = default(KeyInfo), CallsTimers timers = default(CallsTimers), CallsCounters counters = default(CallsCounters))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for AggregationResponseRecord and cannot be null");
            }
            else
            {
                this.Key = key;
            }

            this.Info = info;
            this.Timers = timers;
            this.Counters = counters;
        }

        /// <summary>
        /// Grouping key
        /// </summary>
        /// <value>Grouping key</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public KeyInfo Info { get; set; }

        /// <summary>
        /// Gets or Sets Timers
        /// </summary>
        [DataMember(Name="timers", EmitDefaultValue=false)]
        public CallsTimers Timers { get; set; }

        /// <summary>
        /// Gets or Sets Counters
        /// </summary>
        [DataMember(Name="counters", EmitDefaultValue=false)]
        public CallsCounters Counters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregationResponseRecord {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Timers: ").Append(Timers).Append("\n");
            sb.Append("  Counters: ").Append(Counters).Append("\n");
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
            return this.Equals(input as AggregationResponseRecord);
        }

        /// <summary>
        /// Returns true if AggregationResponseRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregationResponseRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationResponseRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.Timers == input.Timers ||
                    (this.Timers != null &&
                    this.Timers.Equals(input.Timers))
                ) && 
                (
                    this.Counters == input.Counters ||
                    (this.Counters != null &&
                    this.Counters.Equals(input.Counters))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Timers != null)
                    hashCode = hashCode * 59 + this.Timers.GetHashCode();
                if (this.Counters != null)
                    hashCode = hashCode * 59 + this.Counters.GetHashCode();
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
