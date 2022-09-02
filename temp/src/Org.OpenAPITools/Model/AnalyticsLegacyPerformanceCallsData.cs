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
    /// AnalyticsLegacyPerformanceCallsData
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyPerformanceCallsData :  IEquatable<AnalyticsLegacyPerformanceCallsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyPerformanceCallsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsData" /> class.
        /// </summary>
        /// <param name="key">Grouping key (required).</param>
        /// <param name="keyInfo">keyInfo.</param>
        /// <param name="timers">timers.</param>
        /// <param name="counters">counters.</param>
        public AnalyticsLegacyPerformanceCallsData(string key = default(string), AnalyticsLegacyKeyInfo keyInfo = default(AnalyticsLegacyKeyInfo), AnalyticsLegacyPerformanceCallsTimers timers = default(AnalyticsLegacyPerformanceCallsTimers), AnalyticsLegacyPerformanceCallsCounters counters = default(AnalyticsLegacyPerformanceCallsCounters))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for AnalyticsLegacyPerformanceCallsData and cannot be null");
            }
            else
            {
                this.Key = key;
            }

            this.KeyInfo = keyInfo;
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
        /// Gets or Sets KeyInfo
        /// </summary>
        [DataMember(Name="keyInfo", EmitDefaultValue=false)]
        public AnalyticsLegacyKeyInfo KeyInfo { get; set; }

        /// <summary>
        /// Gets or Sets Timers
        /// </summary>
        [DataMember(Name="timers", EmitDefaultValue=false)]
        public AnalyticsLegacyPerformanceCallsTimers Timers { get; set; }

        /// <summary>
        /// Gets or Sets Counters
        /// </summary>
        [DataMember(Name="counters", EmitDefaultValue=false)]
        public AnalyticsLegacyPerformanceCallsCounters Counters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyPerformanceCallsData {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  KeyInfo: ").Append(KeyInfo).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyPerformanceCallsData);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyPerformanceCallsData instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyPerformanceCallsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyPerformanceCallsData input)
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
                    this.KeyInfo == input.KeyInfo ||
                    (this.KeyInfo != null &&
                    this.KeyInfo.Equals(input.KeyInfo))
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
                if (this.KeyInfo != null)
                    hashCode = hashCode * 59 + this.KeyInfo.GetHashCode();
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