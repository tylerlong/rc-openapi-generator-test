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
    /// AnalyticsLegacyTimelineDataPoint
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyTimelineDataPoint :  IEquatable<AnalyticsLegacyTimelineDataPoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyTimelineDataPoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyTimelineDataPoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyTimelineDataPoint" /> class.
        /// </summary>
        /// <param name="time">time (required).</param>
        /// <param name="timers">timers.</param>
        /// <param name="counters">counters.</param>
        public AnalyticsLegacyTimelineDataPoint(DateTime time = default(DateTime), AnalyticsLegacyPerformanceCallsTimers timers = default(AnalyticsLegacyPerformanceCallsTimers), AnalyticsLegacyPerformanceCallsCounters counters = default(AnalyticsLegacyPerformanceCallsCounters))
        {
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for AnalyticsLegacyTimelineDataPoint and cannot be null");
            }
            else
            {
                this.Time = time;
            }

            this.Timers = timers;
            this.Counters = counters;
        }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=true)]
        public DateTime Time { get; set; }

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
            sb.Append("class AnalyticsLegacyTimelineDataPoint {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyTimelineDataPoint);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyTimelineDataPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyTimelineDataPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyTimelineDataPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
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
