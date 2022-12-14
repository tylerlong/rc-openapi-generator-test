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
    /// ExtensionBulkUpdateInfo
    /// </summary>
    [DataContract]
    public partial class ExtensionBulkUpdateInfo :  IEquatable<ExtensionBulkUpdateInfo>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Disabled for value: Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled = 1,

            /// <summary>
            /// Enum Enabled for value: Enabled
            /// </summary>
            [EnumMember(Value = "Enabled")]
            Enabled = 2,

            /// <summary>
            /// Enum NotActivated for value: NotActivated
            /// </summary>
            [EnumMember(Value = "NotActivated")]
            NotActivated = 3,

            /// <summary>
            /// Enum Frozen for value: Frozen
            /// </summary>
            [EnumMember(Value = "Frozen")]
            Frozen = 4

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines SetupWizardState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SetupWizardStateEnum
        {
            /// <summary>
            /// Enum NotStarted for value: NotStarted
            /// </summary>
            [EnumMember(Value = "NotStarted")]
            NotStarted = 1,

            /// <summary>
            /// Enum Incomplete for value: Incomplete
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            Incomplete = 2,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3

        }

        /// <summary>
        /// Gets or Sets SetupWizardState
        /// </summary>
        [DataMember(Name="setupWizardState", EmitDefaultValue=false)]
        public SetupWizardStateEnum? SetupWizardState { get; set; }
        /// <summary>
        /// Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology
        /// </summary>
        /// <value>Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,

            /// <summary>
            /// Enum FaxUser for value: Fax User
            /// </summary>
            [EnumMember(Value = "Fax User")]
            FaxUser = 2,

            /// <summary>
            /// Enum VirtualUser for value: VirtualUser
            /// </summary>
            [EnumMember(Value = "VirtualUser")]
            VirtualUser = 3,

            /// <summary>
            /// Enum DigitalUser for value: DigitalUser
            /// </summary>
            [EnumMember(Value = "DigitalUser")]
            DigitalUser = 4,

            /// <summary>
            /// Enum Department for value: Department
            /// </summary>
            [EnumMember(Value = "Department")]
            Department = 5,

            /// <summary>
            /// Enum Announcement for value: Announcement
            /// </summary>
            [EnumMember(Value = "Announcement")]
            Announcement = 6,

            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 7,

            /// <summary>
            /// Enum SharedLinesGroup for value: SharedLinesGroup
            /// </summary>
            [EnumMember(Value = "SharedLinesGroup")]
            SharedLinesGroup = 8,

            /// <summary>
            /// Enum PagingOnly for value: PagingOnly
            /// </summary>
            [EnumMember(Value = "PagingOnly")]
            PagingOnly = 9,

            /// <summary>
            /// Enum IvrMenu for value: IvrMenu
            /// </summary>
            [EnumMember(Value = "IvrMenu")]
            IvrMenu = 10,

            /// <summary>
            /// Enum ApplicationExtension for value: ApplicationExtension
            /// </summary>
            [EnumMember(Value = "ApplicationExtension")]
            ApplicationExtension = 11,

            /// <summary>
            /// Enum ParkLocation for value: ParkLocation
            /// </summary>
            [EnumMember(Value = "ParkLocation")]
            ParkLocation = 12,

            /// <summary>
            /// Enum DelegatedLinesGroup for value: DelegatedLinesGroup
            /// </summary>
            [EnumMember(Value = "DelegatedLinesGroup")]
            DelegatedLinesGroup = 13

        }

        /// <summary>
        /// Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology
        /// </summary>
        /// <value>Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBulkUpdateInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of an extension.</param>
        /// <param name="status">status.</param>
        /// <param name="statusInfo">statusInfo.</param>
        /// <param name="reason">Type of suspension.</param>
        /// <param name="comment">Free form user comment.</param>
        /// <param name="extensionNumber">Extension number available.</param>
        /// <param name="contact">contact.</param>
        /// <param name="regionalSettings">regionalSettings.</param>
        /// <param name="setupWizardState">setupWizardState.</param>
        /// <param name="partnerId">Additional extension identifier created by partner application and applied on client side.</param>
        /// <param name="ivrPin">IVR PIN.</param>
        /// <param name="password">Password for extension.</param>
        /// <param name="callQueueInfo">callQueueInfo.</param>
        /// <param name="transition">transition.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="hidden">Hides extension from showing in company directory. Supported for extensions of User type only.</param>
        /// <param name="site">site.</param>
        /// <param name="type">Extension type. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology.</param>
        /// <param name="references">List of non-RC internal identifiers assigned to an extension.</param>
        public ExtensionBulkUpdateInfo(string id = default(string), StatusEnum? status = default(StatusEnum?), ExtensionStatusInfo statusInfo = default(ExtensionStatusInfo), string reason = default(string), string comment = default(string), string extensionNumber = default(string), ContactInfoUpdateRequest contact = default(ContactInfoUpdateRequest), ExtensionRegionalSettingRequest regionalSettings = default(ExtensionRegionalSettingRequest), SetupWizardStateEnum? setupWizardState = default(SetupWizardStateEnum?), string partnerId = default(string), string ivrPin = default(string), string password = default(string), CallQueueInfoRequest callQueueInfo = default(CallQueueInfoRequest), UserTransitionInfo transition = default(UserTransitionInfo), List<CustomFieldInfo> customFields = default(List<CustomFieldInfo>), bool hidden = default(bool), AutomaticLocationUpdatesSiteInfo site = default(AutomaticLocationUpdatesSiteInfo), TypeEnum? type = default(TypeEnum?), List<ReferenceInfo> references = default(List<ReferenceInfo>))
        {
            this.Id = id;
            this.Status = status;
            this.StatusInfo = statusInfo;
            this.Reason = reason;
            this.Comment = comment;
            this.ExtensionNumber = extensionNumber;
            this.Contact = contact;
            this.RegionalSettings = regionalSettings;
            this.SetupWizardState = setupWizardState;
            this.PartnerId = partnerId;
            this.IvrPin = ivrPin;
            this.Password = password;
            this.CallQueueInfo = callQueueInfo;
            this.Transition = transition;
            this.CustomFields = customFields;
            this.Hidden = hidden;
            this.Site = site;
            this.Type = type;
            this.References = references;
        }

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Gets or Sets StatusInfo
        /// </summary>
        [DataMember(Name="statusInfo", EmitDefaultValue=false)]
        public ExtensionStatusInfo StatusInfo { get; set; }

        /// <summary>
        /// Type of suspension
        /// </summary>
        /// <value>Type of suspension</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Free form user comment
        /// </summary>
        /// <value>Free form user comment</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Extension number available
        /// </summary>
        /// <value>Extension number available</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ContactInfoUpdateRequest Contact { get; set; }

        /// <summary>
        /// Gets or Sets RegionalSettings
        /// </summary>
        [DataMember(Name="regionalSettings", EmitDefaultValue=false)]
        public ExtensionRegionalSettingRequest RegionalSettings { get; set; }


        /// <summary>
        /// Additional extension identifier created by partner application and applied on client side
        /// </summary>
        /// <value>Additional extension identifier created by partner application and applied on client side</value>
        [DataMember(Name="partnerId", EmitDefaultValue=false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// IVR PIN
        /// </summary>
        /// <value>IVR PIN</value>
        [DataMember(Name="ivrPin", EmitDefaultValue=false)]
        public string IvrPin { get; set; }

        /// <summary>
        /// Password for extension
        /// </summary>
        /// <value>Password for extension</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets CallQueueInfo
        /// </summary>
        [DataMember(Name="callQueueInfo", EmitDefaultValue=false)]
        public CallQueueInfoRequest CallQueueInfo { get; set; }

        /// <summary>
        /// Gets or Sets Transition
        /// </summary>
        [DataMember(Name="transition", EmitDefaultValue=false)]
        public UserTransitionInfo Transition { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public List<CustomFieldInfo> CustomFields { get; set; }

        /// <summary>
        /// Hides extension from showing in company directory. Supported for extensions of User type only
        /// </summary>
        /// <value>Hides extension from showing in company directory. Supported for extensions of User type only</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public AutomaticLocationUpdatesSiteInfo Site { get; set; }


        /// <summary>
        /// List of non-RC internal identifiers assigned to an extension
        /// </summary>
        /// <value>List of non-RC internal identifiers assigned to an extension</value>
        [DataMember(Name="references", EmitDefaultValue=false)]
        public List<ReferenceInfo> References { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionBulkUpdateInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusInfo: ").Append(StatusInfo).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  RegionalSettings: ").Append(RegionalSettings).Append("\n");
            sb.Append("  SetupWizardState: ").Append(SetupWizardState).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  IvrPin: ").Append(IvrPin).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  CallQueueInfo: ").Append(CallQueueInfo).Append("\n");
            sb.Append("  Transition: ").Append(Transition).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  References: ").Append(References).Append("\n");
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
            return this.Equals(input as ExtensionBulkUpdateInfo);
        }

        /// <summary>
        /// Returns true if ExtensionBulkUpdateInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensionBulkUpdateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionBulkUpdateInfo input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusInfo == input.StatusInfo ||
                    (this.StatusInfo != null &&
                    this.StatusInfo.Equals(input.StatusInfo))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.ExtensionNumber == input.ExtensionNumber ||
                    (this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(input.ExtensionNumber))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.RegionalSettings == input.RegionalSettings ||
                    (this.RegionalSettings != null &&
                    this.RegionalSettings.Equals(input.RegionalSettings))
                ) && 
                (
                    this.SetupWizardState == input.SetupWizardState ||
                    (this.SetupWizardState != null &&
                    this.SetupWizardState.Equals(input.SetupWizardState))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.IvrPin == input.IvrPin ||
                    (this.IvrPin != null &&
                    this.IvrPin.Equals(input.IvrPin))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.CallQueueInfo == input.CallQueueInfo ||
                    (this.CallQueueInfo != null &&
                    this.CallQueueInfo.Equals(input.CallQueueInfo))
                ) && 
                (
                    this.Transition == input.Transition ||
                    (this.Transition != null &&
                    this.Transition.Equals(input.Transition))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.References == input.References ||
                    this.References != null &&
                    input.References != null &&
                    this.References.SequenceEqual(input.References)
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusInfo != null)
                    hashCode = hashCode * 59 + this.StatusInfo.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.ExtensionNumber != null)
                    hashCode = hashCode * 59 + this.ExtensionNumber.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.RegionalSettings != null)
                    hashCode = hashCode * 59 + this.RegionalSettings.GetHashCode();
                if (this.SetupWizardState != null)
                    hashCode = hashCode * 59 + this.SetupWizardState.GetHashCode();
                if (this.PartnerId != null)
                    hashCode = hashCode * 59 + this.PartnerId.GetHashCode();
                if (this.IvrPin != null)
                    hashCode = hashCode * 59 + this.IvrPin.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.CallQueueInfo != null)
                    hashCode = hashCode * 59 + this.CallQueueInfo.GetHashCode();
                if (this.Transition != null)
                    hashCode = hashCode * 59 + this.Transition.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Site != null)
                    hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.References != null)
                    hashCode = hashCode * 59 + this.References.GetHashCode();
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
