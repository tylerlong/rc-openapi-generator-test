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
    /// ForwardingNumberInfo
    /// </summary>
    [DataContract]
    public partial class ForwardingNumberInfo :  IEquatable<ForwardingNumberInfo>, IValidatableObject
    {
        /// <summary>
        /// Defines Features
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeaturesEnum
        {
            /// <summary>
            /// Enum CallFlip for value: CallFlip
            /// </summary>
            [EnumMember(Value = "CallFlip")]
            CallFlip = 1,

            /// <summary>
            /// Enum CallForwarding for value: CallForwarding
            /// </summary>
            [EnumMember(Value = "CallForwarding")]
            CallForwarding = 2

        }


        /// <summary>
        /// Type of option this phone number is used for. Multiple values are accepted
        /// </summary>
        /// <value>Type of option this phone number is used for. Multiple values are accepted</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<FeaturesEnum> Features { get; set; }
        /// <summary>
        /// Forwarding phone number type
        /// </summary>
        /// <value>Forwarding phone number type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Home for value: Home
            /// </summary>
            [EnumMember(Value = "Home")]
            Home = 1,

            /// <summary>
            /// Enum Mobile for value: Mobile
            /// </summary>
            [EnumMember(Value = "Mobile")]
            Mobile = 2,

            /// <summary>
            /// Enum Work for value: Work
            /// </summary>
            [EnumMember(Value = "Work")]
            Work = 3,

            /// <summary>
            /// Enum PhoneLine for value: PhoneLine
            /// </summary>
            [EnumMember(Value = "PhoneLine")]
            PhoneLine = 4,

            /// <summary>
            /// Enum Outage for value: Outage
            /// </summary>
            [EnumMember(Value = "Outage")]
            Outage = 5,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 6,

            /// <summary>
            /// Enum BusinessMobilePhone for value: BusinessMobilePhone
            /// </summary>
            [EnumMember(Value = "BusinessMobilePhone")]
            BusinessMobilePhone = 7,

            /// <summary>
            /// Enum ExternalCarrier for value: ExternalCarrier
            /// </summary>
            [EnumMember(Value = "ExternalCarrier")]
            ExternalCarrier = 8

        }

        /// <summary>
        /// Forwarding phone number type
        /// </summary>
        /// <value>Forwarding phone number type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardingNumberInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a forwarding/call flip phone number.</param>
        /// <param name="uri">Canonical URI of a forwarding/call flip phone number.</param>
        /// <param name="phoneNumber">Forwarding/Call flip phone number.</param>
        /// <param name="label">Forwarding/Call flip number title.</param>
        /// <param name="features">Type of option this phone number is used for. Multiple values are accepted.</param>
        /// <param name="flipNumber">Number assigned to the call flip phone number, corresponds to the shortcut dial number.</param>
        /// <param name="device">device.</param>
        /// <param name="type">Forwarding phone number type.</param>
        public ForwardingNumberInfo(string id = default(string), string uri = default(string), string phoneNumber = default(string), string label = default(string), List<FeaturesEnum> features = default(List<FeaturesEnum>), string flipNumber = default(string), CreateForwardingNumberDeviceInfo device = default(CreateForwardingNumberDeviceInfo), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Uri = uri;
            this.PhoneNumber = phoneNumber;
            this.Label = label;
            this.Features = features;
            this.FlipNumber = flipNumber;
            this.Device = device;
            this.Type = type;
        }

        /// <summary>
        /// Internal identifier of a forwarding/call flip phone number
        /// </summary>
        /// <value>Internal identifier of a forwarding/call flip phone number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Canonical URI of a forwarding/call flip phone number
        /// </summary>
        /// <value>Canonical URI of a forwarding/call flip phone number</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Forwarding/Call flip phone number
        /// </summary>
        /// <value>Forwarding/Call flip phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Forwarding/Call flip number title
        /// </summary>
        /// <value>Forwarding/Call flip number title</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }


        /// <summary>
        /// Number assigned to the call flip phone number, corresponds to the shortcut dial number
        /// </summary>
        /// <value>Number assigned to the call flip phone number, corresponds to the shortcut dial number</value>
        [DataMember(Name="flipNumber", EmitDefaultValue=false)]
        public string FlipNumber { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public CreateForwardingNumberDeviceInfo Device { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardingNumberInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  FlipNumber: ").Append(FlipNumber).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ForwardingNumberInfo);
        }

        /// <summary>
        /// Returns true if ForwardingNumberInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ForwardingNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardingNumberInfo input)
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
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
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
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.FlipNumber == input.FlipNumber ||
                    (this.FlipNumber != null &&
                    this.FlipNumber.Equals(input.FlipNumber))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.FlipNumber != null)
                    hashCode = hashCode * 59 + this.FlipNumber.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
