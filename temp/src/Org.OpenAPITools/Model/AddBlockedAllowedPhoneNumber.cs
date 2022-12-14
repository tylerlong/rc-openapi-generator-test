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
    /// Updates either blocked or allowed phone number list with a new phone number.
    /// </summary>
    [DataContract]
    public partial class AddBlockedAllowedPhoneNumber :  IEquatable<AddBlockedAllowedPhoneNumber>, IValidatableObject
    {
        /// <summary>
        /// Status of a phone number
        /// </summary>
        /// <value>Status of a phone number</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Blocked for value: Blocked
            /// </summary>
            [EnumMember(Value = "Blocked")]
            Blocked = 1,

            /// <summary>
            /// Enum Allowed for value: Allowed
            /// </summary>
            [EnumMember(Value = "Allowed")]
            Allowed = 2

        }

        /// <summary>
        /// Status of a phone number
        /// </summary>
        /// <value>Status of a phone number</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddBlockedAllowedPhoneNumber" /> class.
        /// </summary>
        /// <param name="phoneNumber">A blocked/allowed phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format.</param>
        /// <param name="label">Custom name of a blocked/allowed phone number.</param>
        /// <param name="status">Status of a phone number (default to StatusEnum.Blocked).</param>
        public AddBlockedAllowedPhoneNumber(string phoneNumber = default(string), string label = default(string), StatusEnum? status = StatusEnum.Blocked)
        {
            this.PhoneNumber = phoneNumber;
            this.Label = label;
            // use default value if no "status" provided
            if (status == null)
            {
                this.Status = StatusEnum.Blocked;
            }
            else
            {
                this.Status = status;
            }
        }

        /// <summary>
        /// A blocked/allowed phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        /// <value>A blocked/allowed phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Custom name of a blocked/allowed phone number
        /// </summary>
        /// <value>Custom name of a blocked/allowed phone number</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddBlockedAllowedPhoneNumber {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as AddBlockedAllowedPhoneNumber);
        }

        /// <summary>
        /// Returns true if AddBlockedAllowedPhoneNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of AddBlockedAllowedPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddBlockedAllowedPhoneNumber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
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
