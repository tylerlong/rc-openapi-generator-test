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
    /// Date-time range for which the calls are aggregated. The call is considered to be within time range if it started within time range. Both borders are inclusive
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyPerformanceCallsTimeSettings :  IEquatable<AnalyticsLegacyPerformanceCallsTimeSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsTimeSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyPerformanceCallsTimeSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsTimeSettings" /> class.
        /// </summary>
        /// <param name="timeRange">timeRange (required).</param>
        /// <param name="advancedTimeSettings">advancedTimeSettings.</param>
        public AnalyticsLegacyPerformanceCallsTimeSettings(AnalyticsLegacyPerformanceCallsTimeRange timeRange = default(AnalyticsLegacyPerformanceCallsTimeRange), AnalyticsLegacyPerformanceCallsAdvancedTimeSettings advancedTimeSettings = default(AnalyticsLegacyPerformanceCallsAdvancedTimeSettings))
        {
            // to ensure "timeRange" is required (not null)
            if (timeRange == null)
            {
                throw new InvalidDataException("timeRange is a required property for AnalyticsLegacyPerformanceCallsTimeSettings and cannot be null");
            }
            else
            {
                this.TimeRange = timeRange;
            }

            this.AdvancedTimeSettings = advancedTimeSettings;
        }

        /// <summary>
        /// Gets or Sets TimeRange
        /// </summary>
        [DataMember(Name="timeRange", EmitDefaultValue=true)]
        public AnalyticsLegacyPerformanceCallsTimeRange TimeRange { get; set; }

        /// <summary>
        /// Gets or Sets AdvancedTimeSettings
        /// </summary>
        [DataMember(Name="advancedTimeSettings", EmitDefaultValue=false)]
        public AnalyticsLegacyPerformanceCallsAdvancedTimeSettings AdvancedTimeSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyPerformanceCallsTimeSettings {\n");
            sb.Append("  TimeRange: ").Append(TimeRange).Append("\n");
            sb.Append("  AdvancedTimeSettings: ").Append(AdvancedTimeSettings).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyPerformanceCallsTimeSettings);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyPerformanceCallsTimeSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyPerformanceCallsTimeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyPerformanceCallsTimeSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeRange == input.TimeRange ||
                    (this.TimeRange != null &&
                    this.TimeRange.Equals(input.TimeRange))
                ) && 
                (
                    this.AdvancedTimeSettings == input.AdvancedTimeSettings ||
                    (this.AdvancedTimeSettings != null &&
                    this.AdvancedTimeSettings.Equals(input.AdvancedTimeSettings))
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
                if (this.TimeRange != null)
                    hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                if (this.AdvancedTimeSettings != null)
                    hashCode = hashCode * 59 + this.AdvancedTimeSettings.GetHashCode();
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
