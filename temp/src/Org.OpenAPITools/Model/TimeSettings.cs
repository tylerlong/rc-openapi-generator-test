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
    /// Date-time range for the calls. The call is considered to be within time range if it started within time range. Both borders are inclusive
    /// </summary>
    [DataContract]
    public partial class TimeSettings :  IEquatable<TimeSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSettings" /> class.
        /// </summary>
        /// <param name="timeZone">Name of the timezone that will be used for &#x60;includeDays&#x60; and &#x60;includeHours&#x60; filters and aggregation intervals. For example &#39;America/Los_Angeles&#39;, &#39;Europe/Zurich&#39;. See also *[Time Zones](https://www.iana.org/time-zones)*. Value in this field doesn&#39;t affect interpretation of time in &#x60;timeRange&#x60;, as it already includes offset from UTC (required).</param>
        /// <param name="timeRange">timeRange (required).</param>
        /// <param name="advancedTimeSettings">advancedTimeSettings.</param>
        public TimeSettings(string timeZone = default(string), TimeRange timeRange = default(TimeRange), AdvancedTimeSettings advancedTimeSettings = default(AdvancedTimeSettings))
        {
            // to ensure "timeZone" is required (not null)
            if (timeZone == null)
            {
                throw new InvalidDataException("timeZone is a required property for TimeSettings and cannot be null");
            }
            else
            {
                this.TimeZone = timeZone;
            }

            // to ensure "timeRange" is required (not null)
            if (timeRange == null)
            {
                throw new InvalidDataException("timeRange is a required property for TimeSettings and cannot be null");
            }
            else
            {
                this.TimeRange = timeRange;
            }

            this.AdvancedTimeSettings = advancedTimeSettings;
        }

        /// <summary>
        /// Name of the timezone that will be used for &#x60;includeDays&#x60; and &#x60;includeHours&#x60; filters and aggregation intervals. For example &#39;America/Los_Angeles&#39;, &#39;Europe/Zurich&#39;. See also *[Time Zones](https://www.iana.org/time-zones)*. Value in this field doesn&#39;t affect interpretation of time in &#x60;timeRange&#x60;, as it already includes offset from UTC
        /// </summary>
        /// <value>Name of the timezone that will be used for &#x60;includeDays&#x60; and &#x60;includeHours&#x60; filters and aggregation intervals. For example &#39;America/Los_Angeles&#39;, &#39;Europe/Zurich&#39;. See also *[Time Zones](https://www.iana.org/time-zones)*. Value in this field doesn&#39;t affect interpretation of time in &#x60;timeRange&#x60;, as it already includes offset from UTC</value>
        [DataMember(Name="timeZone", EmitDefaultValue=true)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets TimeRange
        /// </summary>
        [DataMember(Name="timeRange", EmitDefaultValue=true)]
        public TimeRange TimeRange { get; set; }

        /// <summary>
        /// Gets or Sets AdvancedTimeSettings
        /// </summary>
        [DataMember(Name="advancedTimeSettings", EmitDefaultValue=false)]
        public AdvancedTimeSettings AdvancedTimeSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSettings {\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(input as TimeSettings);
        }

        /// <summary>
        /// Returns true if TimeSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
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
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
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