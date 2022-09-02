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
    /// Allows more granular control over time included in the report
    /// </summary>
    [DataContract]
    public partial class AdvancedTimeSettings :  IEquatable<AdvancedTimeSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedTimeSettings" /> class.
        /// </summary>
        /// <param name="includeDays">Days of the week for which the report is calculated.</param>
        /// <param name="includeHours">Hours of the day for which the report is calculated.</param>
        public AdvancedTimeSettings(List<DayOfWeek> includeDays = default(List<DayOfWeek>), List<HoursInterval> includeHours = default(List<HoursInterval>))
        {
            this.IncludeDays = includeDays;
            this.IncludeHours = includeHours;
        }

        /// <summary>
        /// Days of the week for which the report is calculated
        /// </summary>
        /// <value>Days of the week for which the report is calculated</value>
        [DataMember(Name="includeDays", EmitDefaultValue=false)]
        public List<DayOfWeek> IncludeDays { get; set; }

        /// <summary>
        /// Hours of the day for which the report is calculated
        /// </summary>
        /// <value>Hours of the day for which the report is calculated</value>
        [DataMember(Name="includeHours", EmitDefaultValue=false)]
        public List<HoursInterval> IncludeHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedTimeSettings {\n");
            sb.Append("  IncludeDays: ").Append(IncludeDays).Append("\n");
            sb.Append("  IncludeHours: ").Append(IncludeHours).Append("\n");
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
            return this.Equals(input as AdvancedTimeSettings);
        }

        /// <summary>
        /// Returns true if AdvancedTimeSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedTimeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedTimeSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeDays == input.IncludeDays ||
                    this.IncludeDays != null &&
                    input.IncludeDays != null &&
                    this.IncludeDays.SequenceEqual(input.IncludeDays)
                ) && 
                (
                    this.IncludeHours == input.IncludeHours ||
                    this.IncludeHours != null &&
                    input.IncludeHours != null &&
                    this.IncludeHours.SequenceEqual(input.IncludeHours)
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
                if (this.IncludeDays != null)
                    hashCode = hashCode * 59 + this.IncludeDays.GetHashCode();
                if (this.IncludeHours != null)
                    hashCode = hashCode * 59 + this.IncludeHours.GetHashCode();
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