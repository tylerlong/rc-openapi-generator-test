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
    /// UpdateUnifiedPresenceTelephony
    /// </summary>
    [DataContract]
    public partial class UpdateUnifiedPresenceTelephony :  IEquatable<UpdateUnifiedPresenceTelephony>, IValidatableObject
    {
        /// <summary>
        /// Telephony DND status
        /// </summary>
        /// <value>Telephony DND status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityEnum
        {
            /// <summary>
            /// Enum TakeAllCalls for value: TakeAllCalls
            /// </summary>
            [EnumMember(Value = "TakeAllCalls")]
            TakeAllCalls = 1,

            /// <summary>
            /// Enum DoNotAcceptAnyCalls for value: DoNotAcceptAnyCalls
            /// </summary>
            [EnumMember(Value = "DoNotAcceptAnyCalls")]
            DoNotAcceptAnyCalls = 2,

            /// <summary>
            /// Enum DoNotAcceptQueueCalls for value: DoNotAcceptQueueCalls
            /// </summary>
            [EnumMember(Value = "DoNotAcceptQueueCalls")]
            DoNotAcceptQueueCalls = 3

        }

        /// <summary>
        /// Telephony DND status
        /// </summary>
        /// <value>Telephony DND status</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public AvailabilityEnum? Availability { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUnifiedPresenceTelephony" /> class.
        /// </summary>
        /// <param name="availability">Telephony DND status.</param>
        public UpdateUnifiedPresenceTelephony(AvailabilityEnum? availability = default(AvailabilityEnum?))
        {
            this.Availability = availability;
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUnifiedPresenceTelephony {\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
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
            return this.Equals(input as UpdateUnifiedPresenceTelephony);
        }

        /// <summary>
        /// Returns true if UpdateUnifiedPresenceTelephony instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUnifiedPresenceTelephony to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUnifiedPresenceTelephony input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
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
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
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
