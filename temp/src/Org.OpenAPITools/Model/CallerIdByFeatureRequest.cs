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
    /// Caller ID settings by feature
    /// </summary>
    [DataContract]
    public partial class CallerIdByFeatureRequest :  IEquatable<CallerIdByFeatureRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Feature
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeatureEnum
        {
            /// <summary>
            /// Enum RingOut for value: RingOut
            /// </summary>
            [EnumMember(Value = "RingOut")]
            RingOut = 1,

            /// <summary>
            /// Enum RingMe for value: RingMe
            /// </summary>
            [EnumMember(Value = "RingMe")]
            RingMe = 2,

            /// <summary>
            /// Enum CallFlip for value: CallFlip
            /// </summary>
            [EnumMember(Value = "CallFlip")]
            CallFlip = 3,

            /// <summary>
            /// Enum FaxNumber for value: FaxNumber
            /// </summary>
            [EnumMember(Value = "FaxNumber")]
            FaxNumber = 4,

            /// <summary>
            /// Enum AdditionalSoftphone for value: AdditionalSoftphone
            /// </summary>
            [EnumMember(Value = "AdditionalSoftphone")]
            AdditionalSoftphone = 5,

            /// <summary>
            /// Enum Alternate for value: Alternate
            /// </summary>
            [EnumMember(Value = "Alternate")]
            Alternate = 6,

            /// <summary>
            /// Enum CommonPhone for value: CommonPhone
            /// </summary>
            [EnumMember(Value = "CommonPhone")]
            CommonPhone = 7,

            /// <summary>
            /// Enum MobileApp for value: MobileApp
            /// </summary>
            [EnumMember(Value = "MobileApp")]
            MobileApp = 8,

            /// <summary>
            /// Enum Delegated for value: Delegated
            /// </summary>
            [EnumMember(Value = "Delegated")]
            Delegated = 9

        }

        /// <summary>
        /// Gets or Sets Feature
        /// </summary>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public FeatureEnum? Feature { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallerIdByFeatureRequest" /> class.
        /// </summary>
        /// <param name="feature">feature.</param>
        /// <param name="callerId">callerId.</param>
        public CallerIdByFeatureRequest(FeatureEnum? feature = default(FeatureEnum?), CallerIdByFeatureInfoRequest callerId = default(CallerIdByFeatureInfoRequest))
        {
            this.Feature = feature;
            this.CallerId = callerId;
        }


        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name="callerId", EmitDefaultValue=false)]
        public CallerIdByFeatureInfoRequest CallerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallerIdByFeatureRequest {\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
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
            return this.Equals(input as CallerIdByFeatureRequest);
        }

        /// <summary>
        /// Returns true if CallerIdByFeatureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CallerIdByFeatureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallerIdByFeatureRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Feature == input.Feature ||
                    (this.Feature != null &&
                    this.Feature.Equals(input.Feature))
                ) && 
                (
                    this.CallerId == input.CallerId ||
                    (this.CallerId != null &&
                    this.CallerId.Equals(input.CallerId))
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
                if (this.Feature != null)
                    hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.CallerId != null)
                    hashCode = hashCode * 59 + this.CallerId.GetHashCode();
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
