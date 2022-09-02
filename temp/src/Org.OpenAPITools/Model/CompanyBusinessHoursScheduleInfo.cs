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
    /// Schedule when an answering rule is applied
    /// </summary>
    [DataContract]
    public partial class CompanyBusinessHoursScheduleInfo :  IEquatable<CompanyBusinessHoursScheduleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyBusinessHoursScheduleInfo" /> class.
        /// </summary>
        /// <param name="weeklyRanges">weeklyRanges.</param>
        public CompanyBusinessHoursScheduleInfo(WeeklyScheduleInfo weeklyRanges = default(WeeklyScheduleInfo))
        {
            this.WeeklyRanges = weeklyRanges;
        }

        /// <summary>
        /// Gets or Sets WeeklyRanges
        /// </summary>
        [DataMember(Name="weeklyRanges", EmitDefaultValue=false)]
        public WeeklyScheduleInfo WeeklyRanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyBusinessHoursScheduleInfo {\n");
            sb.Append("  WeeklyRanges: ").Append(WeeklyRanges).Append("\n");
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
            return this.Equals(input as CompanyBusinessHoursScheduleInfo);
        }

        /// <summary>
        /// Returns true if CompanyBusinessHoursScheduleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyBusinessHoursScheduleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyBusinessHoursScheduleInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WeeklyRanges == input.WeeklyRanges ||
                    (this.WeeklyRanges != null &&
                    this.WeeklyRanges.Equals(input.WeeklyRanges))
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
                if (this.WeeklyRanges != null)
                    hashCode = hashCode * 59 + this.WeeklyRanges.GetHashCode();
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
