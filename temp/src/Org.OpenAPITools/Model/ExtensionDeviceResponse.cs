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
    /// ExtensionDeviceResponse
    /// </summary>
    [DataContract]
    public partial class ExtensionDeviceResponse :  IEquatable<ExtensionDeviceResponse>, IValidatableObject
    {
        /// <summary>
        /// Device type
        /// </summary>
        /// <value>Device type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Room for value: Room
            /// </summary>
            [EnumMember(Value = "Room")]
            Room = 1,

            /// <summary>
            /// Enum SoftPhone for value: SoftPhone
            /// </summary>
            [EnumMember(Value = "SoftPhone")]
            SoftPhone = 2,

            /// <summary>
            /// Enum OtherPhone for value: OtherPhone
            /// </summary>
            [EnumMember(Value = "OtherPhone")]
            OtherPhone = 3,

            /// <summary>
            /// Enum HardPhone for value: HardPhone
            /// </summary>
            [EnumMember(Value = "HardPhone")]
            HardPhone = 4,

            /// <summary>
            /// Enum Paging for value: Paging
            /// </summary>
            [EnumMember(Value = "Paging")]
            Paging = 5,

            /// <summary>
            /// Enum WebRTC for value: WebRTC
            /// </summary>
            [EnumMember(Value = "WebRTC")]
            WebRTC = 6

        }

        /// <summary>
        /// Device type
        /// </summary>
        /// <value>Device type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Device status
        /// </summary>
        /// <value>Device status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Offline for value: Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline = 1,

            /// <summary>
            /// Enum Online for value: Online
            /// </summary>
            [EnumMember(Value = "Online")]
            Online = 2

        }

        /// <summary>
        /// Device status
        /// </summary>
        /// <value>Device status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) &#x3D; [&#39;Host&#39;, &#39;Guest&#39;, &#39;None&#39;]
        /// </summary>
        /// <value>Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) &#x3D; [&#39;Host&#39;, &#39;Guest&#39;, &#39;None&#39;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LinePoolingEnum
        {
            /// <summary>
            /// Enum Host for value: Host
            /// </summary>
            [EnumMember(Value = "Host")]
            Host = 1,

            /// <summary>
            /// Enum Guest for value: Guest
            /// </summary>
            [EnumMember(Value = "Guest")]
            Guest = 2,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3

        }

        /// <summary>
        /// Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) &#x3D; [&#39;Host&#39;, &#39;Guest&#39;, &#39;None&#39;]
        /// </summary>
        /// <value>Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) &#x3D; [&#39;Host&#39;, &#39;Guest&#39;, &#39;None&#39;]</value>
        [DataMember(Name="linePooling", EmitDefaultValue=false)]
        public LinePoolingEnum? LinePooling { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionDeviceResponse" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a device.</param>
        /// <param name="uri">Canonical URI of a device.</param>
        /// <param name="sku">Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example &#39;HP-56-2-2&#39;.</param>
        /// <param name="type">Device type (default to TypeEnum.HardPhone).</param>
        /// <param name="name">Device name. Mandatory if ordering  SoftPhone  or  OtherPhone. Optional for  HardPhone. If not specified for HardPhone, then device model name is used as device name.</param>
        /// <param name="status">Device status.</param>
        /// <param name="serial">Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications.</param>
        /// <param name="computerName">PC name for softphone.</param>
        /// <param name="model">model.</param>
        /// <param name="extension">extension.</param>
        /// <param name="emergencyServiceAddress">emergencyServiceAddress.</param>
        /// <param name="emergency">emergency.</param>
        /// <param name="phoneLines">Phone lines information.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="boxBillingId">Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either model  structure, or  boxBillingId  must be specified for HardPhone.</param>
        /// <param name="useAsCommonPhone">Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone..</param>
        /// <param name="linePooling">Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) &#x3D; [&#39;Host&#39;, &#39;Guest&#39;, &#39;None&#39;].</param>
        /// <param name="inCompanyNet">Network location status. &#39;True&#39; if the device is located in the configured corporate network (On-Net); &#39;False&#39; for Off-Net location. Parameter is not returned if &#x60;EmergencyAddressAutoUpdate&#x60; feature is not enabled for the account/user, or if device network location is not determined.</param>
        /// <param name="site">site.</param>
        /// <param name="lastLocationReportTime">Datetime of receiving last location report in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z.</param>
        public ExtensionDeviceResponse(string id = default(string), string uri = default(string), string sku = default(string), TypeEnum? type = TypeEnum.HardPhone, string name = default(string), StatusEnum? status = default(StatusEnum?), string serial = default(string), string computerName = default(string), ModelInfo model = default(ModelInfo), ExtensionInfoIntId extension = default(ExtensionInfoIntId), EmergencyServiceAddressResource emergencyServiceAddress = default(EmergencyServiceAddressResource), DeviceEmergencyInfo emergency = default(DeviceEmergencyInfo), List<PhoneLinesInfo> phoneLines = default(List<PhoneLinesInfo>), ShippingInfo shipping = default(ShippingInfo), long boxBillingId = default(long), bool useAsCommonPhone = default(bool), LinePoolingEnum? linePooling = default(LinePoolingEnum?), bool inCompanyNet = default(bool), DeviceSiteInfo site = default(DeviceSiteInfo), string lastLocationReportTime = default(string))
        {
            this.Id = id;
            this.Uri = uri;
            this.Sku = sku;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = TypeEnum.HardPhone;
            }
            else
            {
                this.Type = type;
            }
            this.Name = name;
            this.Status = status;
            this.Serial = serial;
            this.ComputerName = computerName;
            this.Model = model;
            this.Extension = extension;
            this.EmergencyServiceAddress = emergencyServiceAddress;
            this.Emergency = emergency;
            this.PhoneLines = phoneLines;
            this.Shipping = shipping;
            this.BoxBillingId = boxBillingId;
            this.UseAsCommonPhone = useAsCommonPhone;
            this.LinePooling = linePooling;
            this.InCompanyNet = inCompanyNet;
            this.Site = site;
            this.LastLocationReportTime = lastLocationReportTime;
        }

        /// <summary>
        /// Internal identifier of a device
        /// </summary>
        /// <value>Internal identifier of a device</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Canonical URI of a device
        /// </summary>
        /// <value>Canonical URI of a device</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example &#39;HP-56-2-2&#39;
        /// </summary>
        /// <value>Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example &#39;HP-56-2-2&#39;</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }


        /// <summary>
        /// Device name. Mandatory if ordering  SoftPhone  or  OtherPhone. Optional for  HardPhone. If not specified for HardPhone, then device model name is used as device name
        /// </summary>
        /// <value>Device name. Mandatory if ordering  SoftPhone  or  OtherPhone. Optional for  HardPhone. If not specified for HardPhone, then device model name is used as device name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
        /// </summary>
        /// <value>Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications</value>
        [DataMember(Name="serial", EmitDefaultValue=false)]
        public string Serial { get; set; }

        /// <summary>
        /// PC name for softphone
        /// </summary>
        /// <value>PC name for softphone</value>
        [DataMember(Name="computerName", EmitDefaultValue=false)]
        public string ComputerName { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public ModelInfo Model { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public ExtensionInfoIntId Extension { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyServiceAddress
        /// </summary>
        [DataMember(Name="emergencyServiceAddress", EmitDefaultValue=false)]
        public EmergencyServiceAddressResource EmergencyServiceAddress { get; set; }

        /// <summary>
        /// Gets or Sets Emergency
        /// </summary>
        [DataMember(Name="emergency", EmitDefaultValue=false)]
        public DeviceEmergencyInfo Emergency { get; set; }

        /// <summary>
        /// Phone lines information
        /// </summary>
        /// <value>Phone lines information</value>
        [DataMember(Name="phoneLines", EmitDefaultValue=false)]
        public List<PhoneLinesInfo> PhoneLines { get; set; }

        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public ShippingInfo Shipping { get; set; }

        /// <summary>
        /// Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either model  structure, or  boxBillingId  must be specified for HardPhone
        /// </summary>
        /// <value>Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either model  structure, or  boxBillingId  must be specified for HardPhone</value>
        [DataMember(Name="boxBillingId", EmitDefaultValue=false)]
        public long BoxBillingId { get; set; }

        /// <summary>
        /// Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone.
        /// </summary>
        /// <value>Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone.</value>
        [DataMember(Name="useAsCommonPhone", EmitDefaultValue=false)]
        public bool UseAsCommonPhone { get; set; }


        /// <summary>
        /// Network location status. &#39;True&#39; if the device is located in the configured corporate network (On-Net); &#39;False&#39; for Off-Net location. Parameter is not returned if &#x60;EmergencyAddressAutoUpdate&#x60; feature is not enabled for the account/user, or if device network location is not determined
        /// </summary>
        /// <value>Network location status. &#39;True&#39; if the device is located in the configured corporate network (On-Net); &#39;False&#39; for Off-Net location. Parameter is not returned if &#x60;EmergencyAddressAutoUpdate&#x60; feature is not enabled for the account/user, or if device network location is not determined</value>
        [DataMember(Name="inCompanyNet", EmitDefaultValue=false)]
        public bool InCompanyNet { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public DeviceSiteInfo Site { get; set; }

        /// <summary>
        /// Datetime of receiving last location report in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Datetime of receiving last location report in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="lastLocationReportTime", EmitDefaultValue=false)]
        public string LastLocationReportTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionDeviceResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  ComputerName: ").Append(ComputerName).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  EmergencyServiceAddress: ").Append(EmergencyServiceAddress).Append("\n");
            sb.Append("  Emergency: ").Append(Emergency).Append("\n");
            sb.Append("  PhoneLines: ").Append(PhoneLines).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  BoxBillingId: ").Append(BoxBillingId).Append("\n");
            sb.Append("  UseAsCommonPhone: ").Append(UseAsCommonPhone).Append("\n");
            sb.Append("  LinePooling: ").Append(LinePooling).Append("\n");
            sb.Append("  InCompanyNet: ").Append(InCompanyNet).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  LastLocationReportTime: ").Append(LastLocationReportTime).Append("\n");
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
            return this.Equals(input as ExtensionDeviceResponse);
        }

        /// <summary>
        /// Returns true if ExtensionDeviceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensionDeviceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionDeviceResponse input)
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
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Serial == input.Serial ||
                    (this.Serial != null &&
                    this.Serial.Equals(input.Serial))
                ) && 
                (
                    this.ComputerName == input.ComputerName ||
                    (this.ComputerName != null &&
                    this.ComputerName.Equals(input.ComputerName))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.EmergencyServiceAddress == input.EmergencyServiceAddress ||
                    (this.EmergencyServiceAddress != null &&
                    this.EmergencyServiceAddress.Equals(input.EmergencyServiceAddress))
                ) && 
                (
                    this.Emergency == input.Emergency ||
                    (this.Emergency != null &&
                    this.Emergency.Equals(input.Emergency))
                ) && 
                (
                    this.PhoneLines == input.PhoneLines ||
                    this.PhoneLines != null &&
                    input.PhoneLines != null &&
                    this.PhoneLines.SequenceEqual(input.PhoneLines)
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) && 
                (
                    this.BoxBillingId == input.BoxBillingId ||
                    (this.BoxBillingId != null &&
                    this.BoxBillingId.Equals(input.BoxBillingId))
                ) && 
                (
                    this.UseAsCommonPhone == input.UseAsCommonPhone ||
                    (this.UseAsCommonPhone != null &&
                    this.UseAsCommonPhone.Equals(input.UseAsCommonPhone))
                ) && 
                (
                    this.LinePooling == input.LinePooling ||
                    (this.LinePooling != null &&
                    this.LinePooling.Equals(input.LinePooling))
                ) && 
                (
                    this.InCompanyNet == input.InCompanyNet ||
                    (this.InCompanyNet != null &&
                    this.InCompanyNet.Equals(input.InCompanyNet))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.LastLocationReportTime == input.LastLocationReportTime ||
                    (this.LastLocationReportTime != null &&
                    this.LastLocationReportTime.Equals(input.LastLocationReportTime))
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
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Serial != null)
                    hashCode = hashCode * 59 + this.Serial.GetHashCode();
                if (this.ComputerName != null)
                    hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.EmergencyServiceAddress != null)
                    hashCode = hashCode * 59 + this.EmergencyServiceAddress.GetHashCode();
                if (this.Emergency != null)
                    hashCode = hashCode * 59 + this.Emergency.GetHashCode();
                if (this.PhoneLines != null)
                    hashCode = hashCode * 59 + this.PhoneLines.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.BoxBillingId != null)
                    hashCode = hashCode * 59 + this.BoxBillingId.GetHashCode();
                if (this.UseAsCommonPhone != null)
                    hashCode = hashCode * 59 + this.UseAsCommonPhone.GetHashCode();
                if (this.LinePooling != null)
                    hashCode = hashCode * 59 + this.LinePooling.GetHashCode();
                if (this.InCompanyNet != null)
                    hashCode = hashCode * 59 + this.InCompanyNet.GetHashCode();
                if (this.Site != null)
                    hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.LastLocationReportTime != null)
                    hashCode = hashCode * 59 + this.LastLocationReportTime.GetHashCode();
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