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
    /// Phone number information
    /// </summary>
    [DataContract]
    public partial class PhoneNumberInfoIntId :  IEquatable<PhoneNumberInfoIntId>, IValidatableObject
    {
        /// <summary>
        /// Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system
        /// </summary>
        /// <value>Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum External for value: External
            /// </summary>
            [EnumMember(Value = "External")]
            External = 1,

            /// <summary>
            /// Enum TollFree for value: TollFree
            /// </summary>
            [EnumMember(Value = "TollFree")]
            TollFree = 2,

            /// <summary>
            /// Enum Local for value: Local
            /// </summary>
            [EnumMember(Value = "Local")]
            Local = 3

        }

        /// <summary>
        /// Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system
        /// </summary>
        /// <value>Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system</value>
        [DataMember(Name="paymentType", EmitDefaultValue=false)]
        public PaymentTypeEnum? PaymentType { get; set; }
        /// <summary>
        /// Phone number type
        /// </summary>
        /// <value>Phone number type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum VoiceFax for value: VoiceFax
            /// </summary>
            [EnumMember(Value = "VoiceFax")]
            VoiceFax = 1,

            /// <summary>
            /// Enum FaxOnly for value: FaxOnly
            /// </summary>
            [EnumMember(Value = "FaxOnly")]
            FaxOnly = 2,

            /// <summary>
            /// Enum VoiceOnly for value: VoiceOnly
            /// </summary>
            [EnumMember(Value = "VoiceOnly")]
            VoiceOnly = 3

        }

        /// <summary>
        /// Phone number type
        /// </summary>
        /// <value>Phone number type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Usage type of the phone number
        /// </summary>
        /// <value>Usage type of the phone number</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UsageTypeEnum
        {
            /// <summary>
            /// Enum MainCompanyNumber for value: MainCompanyNumber
            /// </summary>
            [EnumMember(Value = "MainCompanyNumber")]
            MainCompanyNumber = 1,

            /// <summary>
            /// Enum AdditionalCompanyNumber for value: AdditionalCompanyNumber
            /// </summary>
            [EnumMember(Value = "AdditionalCompanyNumber")]
            AdditionalCompanyNumber = 2,

            /// <summary>
            /// Enum CompanyNumber for value: CompanyNumber
            /// </summary>
            [EnumMember(Value = "CompanyNumber")]
            CompanyNumber = 3,

            /// <summary>
            /// Enum DirectNumber for value: DirectNumber
            /// </summary>
            [EnumMember(Value = "DirectNumber")]
            DirectNumber = 4,

            /// <summary>
            /// Enum CompanyFaxNumber for value: CompanyFaxNumber
            /// </summary>
            [EnumMember(Value = "CompanyFaxNumber")]
            CompanyFaxNumber = 5,

            /// <summary>
            /// Enum ForwardedNumber for value: ForwardedNumber
            /// </summary>
            [EnumMember(Value = "ForwardedNumber")]
            ForwardedNumber = 6,

            /// <summary>
            /// Enum ForwardedCompanyNumber for value: ForwardedCompanyNumber
            /// </summary>
            [EnumMember(Value = "ForwardedCompanyNumber")]
            ForwardedCompanyNumber = 7,

            /// <summary>
            /// Enum ContactCenterNumber for value: ContactCenterNumber
            /// </summary>
            [EnumMember(Value = "ContactCenterNumber")]
            ContactCenterNumber = 8

        }

        /// <summary>
        /// Usage type of the phone number
        /// </summary>
        /// <value>Usage type of the phone number</value>
        [DataMember(Name="usageType", EmitDefaultValue=false)]
        public UsageTypeEnum? UsageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberInfoIntId" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a phone number.</param>
        /// <param name="country">country.</param>
        /// <param name="extension">extension.</param>
        /// <param name="label">Custom user name of a phone number, if any.</param>
        /// <param name="location">Location (City, State). Filled for local US numbers.</param>
        /// <param name="paymentType">Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system.</param>
        /// <param name="phoneNumber">Phone number.</param>
        /// <param name="status">Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral.</param>
        /// <param name="type">Phone number type.</param>
        /// <param name="usageType">Usage type of the phone number.</param>
        public PhoneNumberInfoIntId(long id = default(long), PhoneNumberCountryInfo country = default(PhoneNumberCountryInfo), DeviceProvisioningExtensionInfo extension = default(DeviceProvisioningExtensionInfo), string label = default(string), string location = default(string), PaymentTypeEnum? paymentType = default(PaymentTypeEnum?), string phoneNumber = default(string), string status = default(string), TypeEnum? type = default(TypeEnum?), UsageTypeEnum? usageType = default(UsageTypeEnum?))
        {
            this.Id = id;
            this.Country = country;
            this.Extension = extension;
            this.Label = label;
            this.Location = location;
            this.PaymentType = paymentType;
            this.PhoneNumber = phoneNumber;
            this.Status = status;
            this.Type = type;
            this.UsageType = usageType;
        }

        /// <summary>
        /// Internal identifier of a phone number
        /// </summary>
        /// <value>Internal identifier of a phone number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public PhoneNumberCountryInfo Country { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public DeviceProvisioningExtensionInfo Extension { get; set; }

        /// <summary>
        /// Custom user name of a phone number, if any
        /// </summary>
        /// <value>Custom user name of a phone number, if any</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Location (City, State). Filled for local US numbers
        /// </summary>
        /// <value>Location (City, State). Filled for local US numbers</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }


        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
        /// </summary>
        /// <value>Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumberInfoIntId {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UsageType: ").Append(UsageType).Append("\n");
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
            return this.Equals(input as PhoneNumberInfoIntId);
        }

        /// <summary>
        /// Returns true if PhoneNumberInfoIntId instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumberInfoIntId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumberInfoIntId input)
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
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UsageType == input.UsageType ||
                    (this.UsageType != null &&
                    this.UsageType.Equals(input.UsageType))
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
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UsageType != null)
                    hashCode = hashCode * 59 + this.UsageType.GetHashCode();
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
