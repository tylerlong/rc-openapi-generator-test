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
    /// AutomaticLocationUpdatesPhoneLine
    /// </summary>
    [DataContract]
    public partial class AutomaticLocationUpdatesPhoneLine :  IEquatable<AutomaticLocationUpdatesPhoneLine>, IValidatableObject
    {
        /// <summary>
        /// Defines LineType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineTypeEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Standalone for value: Standalone
            /// </summary>
            [EnumMember(Value = "Standalone")]
            Standalone = 2,

            /// <summary>
            /// Enum StandaloneFree for value: StandaloneFree
            /// </summary>
            [EnumMember(Value = "StandaloneFree")]
            StandaloneFree = 3,

            /// <summary>
            /// Enum BlaPrimary for value: BlaPrimary
            /// </summary>
            [EnumMember(Value = "BlaPrimary")]
            BlaPrimary = 4,

            /// <summary>
            /// Enum BlaSecondary for value: BlaSecondary
            /// </summary>
            [EnumMember(Value = "BlaSecondary")]
            BlaSecondary = 5,

            /// <summary>
            /// Enum BLF for value: BLF
            /// </summary>
            [EnumMember(Value = "BLF")]
            BLF = 6

        }

        /// <summary>
        /// Gets or Sets LineType
        /// </summary>
        [DataMember(Name="lineType", EmitDefaultValue=false)]
        public LineTypeEnum? LineType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticLocationUpdatesPhoneLine" /> class.
        /// </summary>
        /// <param name="lineType">lineType.</param>
        /// <param name="phoneInfo">phoneInfo.</param>
        public AutomaticLocationUpdatesPhoneLine(LineTypeEnum? lineType = default(LineTypeEnum?), AutomaticLocationUpdatesPhoneNumberInfo phoneInfo = default(AutomaticLocationUpdatesPhoneNumberInfo))
        {
            this.LineType = lineType;
            this.PhoneInfo = phoneInfo;
        }


        /// <summary>
        /// Gets or Sets PhoneInfo
        /// </summary>
        [DataMember(Name="phoneInfo", EmitDefaultValue=false)]
        public AutomaticLocationUpdatesPhoneNumberInfo PhoneInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomaticLocationUpdatesPhoneLine {\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            sb.Append("  PhoneInfo: ").Append(PhoneInfo).Append("\n");
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
            return this.Equals(input as AutomaticLocationUpdatesPhoneLine);
        }

        /// <summary>
        /// Returns true if AutomaticLocationUpdatesPhoneLine instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomaticLocationUpdatesPhoneLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticLocationUpdatesPhoneLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineType == input.LineType ||
                    (this.LineType != null &&
                    this.LineType.Equals(input.LineType))
                ) && 
                (
                    this.PhoneInfo == input.PhoneInfo ||
                    (this.PhoneInfo != null &&
                    this.PhoneInfo.Equals(input.PhoneInfo))
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
                if (this.LineType != null)
                    hashCode = hashCode * 59 + this.LineType.GetHashCode();
                if (this.PhoneInfo != null)
                    hashCode = hashCode * 59 + this.PhoneInfo.GetHashCode();
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
