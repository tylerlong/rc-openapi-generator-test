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
    /// UserBusinessHoursUpdateRequest
    /// </summary>
    [DataContract]
    public partial class UserBusinessHoursUpdateRequest :  IEquatable<UserBusinessHoursUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBusinessHoursUpdateRequest" /> class.
        /// </summary>
        /// <param name="schedule">schedule.</param>
        public UserBusinessHoursUpdateRequest(UserBusinessHoursScheduleInfo schedule = default(UserBusinessHoursScheduleInfo))
        {
            this.Schedule = schedule;
        }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public UserBusinessHoursScheduleInfo Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBusinessHoursUpdateRequest {\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(input as UserBusinessHoursUpdateRequest);
        }

        /// <summary>
        /// Returns true if UserBusinessHoursUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserBusinessHoursUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBusinessHoursUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
