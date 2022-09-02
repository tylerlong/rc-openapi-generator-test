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
    /// Returned if *Meetings* feature is switched on
    /// </summary>
    [DataContract]
    public partial class UnifiedPresenceMeeting :  IEquatable<UnifiedPresenceMeeting>, IValidatableObject
    {
        /// <summary>
        /// Meeting status calculated from all user&#x60;s meetings
        /// </summary>
        /// <value>Meeting status calculated from all user&#x60;s meetings</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum NoMeeting for value: NoMeeting
            /// </summary>
            [EnumMember(Value = "NoMeeting")]
            NoMeeting = 1,

            /// <summary>
            /// Enum InMeeting for value: InMeeting
            /// </summary>
            [EnumMember(Value = "InMeeting")]
            InMeeting = 2

        }

        /// <summary>
        /// Meeting status calculated from all user&#x60;s meetings
        /// </summary>
        /// <value>Meeting status calculated from all user&#x60;s meetings</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedPresenceMeeting" /> class.
        /// </summary>
        /// <param name="status">Meeting status calculated from all user&#x60;s meetings.</param>
        public UnifiedPresenceMeeting(StatusEnum? status = default(StatusEnum?))
        {
            this.Status = status;
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedPresenceMeeting {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as UnifiedPresenceMeeting);
        }

        /// <summary>
        /// Returns true if UnifiedPresenceMeeting instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedPresenceMeeting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedPresenceMeeting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
