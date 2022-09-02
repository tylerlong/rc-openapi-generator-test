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
    /// PhoneLinesInfo
    /// </summary>
    [DataContract]
    public partial class PhoneLinesInfo :  IEquatable<PhoneLinesInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of phone line
        /// </summary>
        /// <value>Type of phone line</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineTypeEnum
        {
            /// <summary>
            /// Enum Standalone for value: Standalone
            /// </summary>
            [EnumMember(Value = "Standalone")]
            Standalone = 1,

            /// <summary>
            /// Enum StandaloneFree for value: StandaloneFree
            /// </summary>
            [EnumMember(Value = "StandaloneFree")]
            StandaloneFree = 2,

            /// <summary>
            /// Enum BlaPrimary for value: BlaPrimary
            /// </summary>
            [EnumMember(Value = "BlaPrimary")]
            BlaPrimary = 3,

            /// <summary>
            /// Enum BlaSecondary for value: BlaSecondary
            /// </summary>
            [EnumMember(Value = "BlaSecondary")]
            BlaSecondary = 4

        }

        /// <summary>
        /// Type of phone line
        /// </summary>
        /// <value>Type of phone line</value>
        [DataMember(Name="lineType", EmitDefaultValue=false)]
        public LineTypeEnum? LineType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneLinesInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a phone line.</param>
        /// <param name="lineType">Type of phone line.</param>
        /// <param name="phoneInfo">phoneInfo.</param>
        /// <param name="emergencyAddress">emergencyAddress.</param>
        public PhoneLinesInfo(string id = default(string), LineTypeEnum? lineType = default(LineTypeEnum?), PhoneNumberInfoIntId phoneInfo = default(PhoneNumberInfoIntId), EmergencyAddress emergencyAddress = default(EmergencyAddress))
        {
            this.Id = id;
            this.LineType = lineType;
            this.PhoneInfo = phoneInfo;
            this.EmergencyAddress = emergencyAddress;
        }

        /// <summary>
        /// Internal identifier of a phone line
        /// </summary>
        /// <value>Internal identifier of a phone line</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Gets or Sets PhoneInfo
        /// </summary>
        [DataMember(Name="phoneInfo", EmitDefaultValue=false)]
        public PhoneNumberInfoIntId PhoneInfo { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyAddress
        /// </summary>
        [DataMember(Name="emergencyAddress", EmitDefaultValue=false)]
        public EmergencyAddress EmergencyAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneLinesInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            sb.Append("  PhoneInfo: ").Append(PhoneInfo).Append("\n");
            sb.Append("  EmergencyAddress: ").Append(EmergencyAddress).Append("\n");
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
            return this.Equals(input as PhoneLinesInfo);
        }

        /// <summary>
        /// Returns true if PhoneLinesInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneLinesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneLinesInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LineType == input.LineType ||
                    (this.LineType != null &&
                    this.LineType.Equals(input.LineType))
                ) && 
                (
                    this.PhoneInfo == input.PhoneInfo ||
                    (this.PhoneInfo != null &&
                    this.PhoneInfo.Equals(input.PhoneInfo))
                ) && 
                (
                    this.EmergencyAddress == input.EmergencyAddress ||
                    (this.EmergencyAddress != null &&
                    this.EmergencyAddress.Equals(input.EmergencyAddress))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LineType != null)
                    hashCode = hashCode * 59 + this.LineType.GetHashCode();
                if (this.PhoneInfo != null)
                    hashCode = hashCode * 59 + this.PhoneInfo.GetHashCode();
                if (this.EmergencyAddress != null)
                    hashCode = hashCode * 59 + this.EmergencyAddress.GetHashCode();
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