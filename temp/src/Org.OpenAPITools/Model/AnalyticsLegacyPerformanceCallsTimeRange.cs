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
    /// AnalyticsLegacyPerformanceCallsTimeRange
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyPerformanceCallsTimeRange :  IEquatable<AnalyticsLegacyPerformanceCallsTimeRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsTimeRange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyPerformanceCallsTimeRange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsTimeRange" /> class.
        /// </summary>
        /// <param name="timeFrom">The start date-time for resulting records in RFC 3339 format including offset between local time and UTC, for example 2016-03-15T18:07:52.534Z (required).</param>
        /// <param name="timeTo">The end date-time for resulting records in RFC 3339 format including offset between local time and UTC, for example 2016-03-15T18:07:52.534Z (required).</param>
        public AnalyticsLegacyPerformanceCallsTimeRange(DateTime timeFrom = default(DateTime), DateTime timeTo = default(DateTime))
        {
            // to ensure "timeFrom" is required (not null)
            if (timeFrom == null)
            {
                throw new InvalidDataException("timeFrom is a required property for AnalyticsLegacyPerformanceCallsTimeRange and cannot be null");
            }
            else
            {
                this.TimeFrom = timeFrom;
            }

            // to ensure "timeTo" is required (not null)
            if (timeTo == null)
            {
                throw new InvalidDataException("timeTo is a required property for AnalyticsLegacyPerformanceCallsTimeRange and cannot be null");
            }
            else
            {
                this.TimeTo = timeTo;
            }

        }

        /// <summary>
        /// The start date-time for resulting records in RFC 3339 format including offset between local time and UTC, for example 2016-03-15T18:07:52.534Z
        /// </summary>
        /// <value>The start date-time for resulting records in RFC 3339 format including offset between local time and UTC, for example 2016-03-15T18:07:52.534Z</value>
        [DataMember(Name="timeFrom", EmitDefaultValue=true)]
        public DateTime TimeFrom { get; set; }

        /// <summary>
        /// The end date-time for resulting records in RFC 3339 format including offset between local time and UTC, for example 2016-03-15T18:07:52.534Z
        /// </summary>
        /// <value>The end date-time for resulting records in RFC 3339 format including offset between local time and UTC, for example 2016-03-15T18:07:52.534Z</value>
        [DataMember(Name="timeTo", EmitDefaultValue=true)]
        public DateTime TimeTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyPerformanceCallsTimeRange {\n");
            sb.Append("  TimeFrom: ").Append(TimeFrom).Append("\n");
            sb.Append("  TimeTo: ").Append(TimeTo).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyPerformanceCallsTimeRange);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyPerformanceCallsTimeRange instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyPerformanceCallsTimeRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyPerformanceCallsTimeRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeFrom == input.TimeFrom ||
                    (this.TimeFrom != null &&
                    this.TimeFrom.Equals(input.TimeFrom))
                ) && 
                (
                    this.TimeTo == input.TimeTo ||
                    (this.TimeTo != null &&
                    this.TimeTo.Equals(input.TimeTo))
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
                if (this.TimeFrom != null)
                    hashCode = hashCode * 59 + this.TimeFrom.GetHashCode();
                if (this.TimeTo != null)
                    hashCode = hashCode * 59 + this.TimeTo.GetHashCode();
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