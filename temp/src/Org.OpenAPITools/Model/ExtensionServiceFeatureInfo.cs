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
    /// ExtensionServiceFeatureInfo
    /// </summary>
    [DataContract]
    public partial class ExtensionServiceFeatureInfo :  IEquatable<ExtensionServiceFeatureInfo>, IValidatableObject
    {
        /// <summary>
        /// Feature name
        /// </summary>
        /// <value>Feature name</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeatureNameEnum
        {
            /// <summary>
            /// Enum AccountFederation for value: AccountFederation
            /// </summary>
            [EnumMember(Value = "AccountFederation")]
            AccountFederation = 1,

            /// <summary>
            /// Enum Archiver for value: Archiver
            /// </summary>
            [EnumMember(Value = "Archiver")]
            Archiver = 2,

            /// <summary>
            /// Enum AutomaticCallRecordingMute for value: AutomaticCallRecordingMute
            /// </summary>
            [EnumMember(Value = "AutomaticCallRecordingMute")]
            AutomaticCallRecordingMute = 3,

            /// <summary>
            /// Enum AutomaticInboundCallRecording for value: AutomaticInboundCallRecording
            /// </summary>
            [EnumMember(Value = "AutomaticInboundCallRecording")]
            AutomaticInboundCallRecording = 4,

            /// <summary>
            /// Enum AutomaticOutboundCallRecording for value: AutomaticOutboundCallRecording
            /// </summary>
            [EnumMember(Value = "AutomaticOutboundCallRecording")]
            AutomaticOutboundCallRecording = 5,

            /// <summary>
            /// Enum BlockedMessageForwarding for value: BlockedMessageForwarding
            /// </summary>
            [EnumMember(Value = "BlockedMessageForwarding")]
            BlockedMessageForwarding = 6,

            /// <summary>
            /// Enum Calendar for value: Calendar
            /// </summary>
            [EnumMember(Value = "Calendar")]
            Calendar = 7,

            /// <summary>
            /// Enum CallerIdControl for value: CallerIdControl
            /// </summary>
            [EnumMember(Value = "CallerIdControl")]
            CallerIdControl = 8,

            /// <summary>
            /// Enum CallForwarding for value: CallForwarding
            /// </summary>
            [EnumMember(Value = "CallForwarding")]
            CallForwarding = 9,

            /// <summary>
            /// Enum CallPark for value: CallPark
            /// </summary>
            [EnumMember(Value = "CallPark")]
            CallPark = 10,

            /// <summary>
            /// Enum CallParkLocations for value: CallParkLocations
            /// </summary>
            [EnumMember(Value = "CallParkLocations")]
            CallParkLocations = 11,

            /// <summary>
            /// Enum CallSupervision for value: CallSupervision
            /// </summary>
            [EnumMember(Value = "CallSupervision")]
            CallSupervision = 12,

            /// <summary>
            /// Enum CallSwitch for value: CallSwitch
            /// </summary>
            [EnumMember(Value = "CallSwitch")]
            CallSwitch = 13,

            /// <summary>
            /// Enum CallQualitySurvey for value: CallQualitySurvey
            /// </summary>
            [EnumMember(Value = "CallQualitySurvey")]
            CallQualitySurvey = 14,

            /// <summary>
            /// Enum Conferencing for value: Conferencing
            /// </summary>
            [EnumMember(Value = "Conferencing")]
            Conferencing = 15,

            /// <summary>
            /// Enum ConferencingNumber for value: ConferencingNumber
            /// </summary>
            [EnumMember(Value = "ConferencingNumber")]
            ConferencingNumber = 16,

            /// <summary>
            /// Enum ConfigureDelegates for value: ConfigureDelegates
            /// </summary>
            [EnumMember(Value = "ConfigureDelegates")]
            ConfigureDelegates = 17,

            /// <summary>
            /// Enum DeveloperPortal for value: DeveloperPortal
            /// </summary>
            [EnumMember(Value = "DeveloperPortal")]
            DeveloperPortal = 18,

            /// <summary>
            /// Enum DND for value: DND
            /// </summary>
            [EnumMember(Value = "DND")]
            DND = 19,

            /// <summary>
            /// Enum DynamicConference for value: DynamicConference
            /// </summary>
            [EnumMember(Value = "DynamicConference")]
            DynamicConference = 20,

            /// <summary>
            /// Enum EmergencyAddressAutoUpdate for value: EmergencyAddressAutoUpdate
            /// </summary>
            [EnumMember(Value = "EmergencyAddressAutoUpdate")]
            EmergencyAddressAutoUpdate = 21,

            /// <summary>
            /// Enum EmergencyCalling for value: EmergencyCalling
            /// </summary>
            [EnumMember(Value = "EmergencyCalling")]
            EmergencyCalling = 22,

            /// <summary>
            /// Enum EncryptionAtRest for value: EncryptionAtRest
            /// </summary>
            [EnumMember(Value = "EncryptionAtRest")]
            EncryptionAtRest = 23,

            /// <summary>
            /// Enum ExternalDirectoryIntegration for value: ExternalDirectoryIntegration
            /// </summary>
            [EnumMember(Value = "ExternalDirectoryIntegration")]
            ExternalDirectoryIntegration = 24,

            /// <summary>
            /// Enum Fax for value: Fax
            /// </summary>
            [EnumMember(Value = "Fax")]
            Fax = 25,

            /// <summary>
            /// Enum FaxReceiving for value: FaxReceiving
            /// </summary>
            [EnumMember(Value = "FaxReceiving")]
            FaxReceiving = 26,

            /// <summary>
            /// Enum FreeSoftPhoneLines for value: FreeSoftPhoneLines
            /// </summary>
            [EnumMember(Value = "FreeSoftPhoneLines")]
            FreeSoftPhoneLines = 27,

            /// <summary>
            /// Enum HDVoice for value: HDVoice
            /// </summary>
            [EnumMember(Value = "HDVoice")]
            HDVoice = 28,

            /// <summary>
            /// Enum HipaaCompliance for value: HipaaCompliance
            /// </summary>
            [EnumMember(Value = "HipaaCompliance")]
            HipaaCompliance = 29,

            /// <summary>
            /// Enum Intercom for value: Intercom
            /// </summary>
            [EnumMember(Value = "Intercom")]
            Intercom = 30,

            /// <summary>
            /// Enum InternationalCalling for value: InternationalCalling
            /// </summary>
            [EnumMember(Value = "InternationalCalling")]
            InternationalCalling = 31,

            /// <summary>
            /// Enum InternationalSMS for value: InternationalSMS
            /// </summary>
            [EnumMember(Value = "InternationalSMS")]
            InternationalSMS = 32,

            /// <summary>
            /// Enum LinkedSoftphoneLines for value: LinkedSoftphoneLines
            /// </summary>
            [EnumMember(Value = "LinkedSoftphoneLines")]
            LinkedSoftphoneLines = 33,

            /// <summary>
            /// Enum MMS for value: MMS
            /// </summary>
            [EnumMember(Value = "MMS")]
            MMS = 34,

            /// <summary>
            /// Enum MobileVoipEmergencyCalling for value: MobileVoipEmergencyCalling
            /// </summary>
            [EnumMember(Value = "MobileVoipEmergencyCalling")]
            MobileVoipEmergencyCalling = 35,

            /// <summary>
            /// Enum OnDemandCallRecording for value: OnDemandCallRecording
            /// </summary>
            [EnumMember(Value = "OnDemandCallRecording")]
            OnDemandCallRecording = 36,

            /// <summary>
            /// Enum Pager for value: Pager
            /// </summary>
            [EnumMember(Value = "Pager")]
            Pager = 37,

            /// <summary>
            /// Enum PagerReceiving for value: PagerReceiving
            /// </summary>
            [EnumMember(Value = "PagerReceiving")]
            PagerReceiving = 38,

            /// <summary>
            /// Enum Paging for value: Paging
            /// </summary>
            [EnumMember(Value = "Paging")]
            Paging = 39,

            /// <summary>
            /// Enum PasswordAuth for value: PasswordAuth
            /// </summary>
            [EnumMember(Value = "PasswordAuth")]
            PasswordAuth = 40,

            /// <summary>
            /// Enum PromoMessage for value: PromoMessage
            /// </summary>
            [EnumMember(Value = "PromoMessage")]
            PromoMessage = 41,

            /// <summary>
            /// Enum Reports for value: Reports
            /// </summary>
            [EnumMember(Value = "Reports")]
            Reports = 42,

            /// <summary>
            /// Enum Presence for value: Presence
            /// </summary>
            [EnumMember(Value = "Presence")]
            Presence = 43,

            /// <summary>
            /// Enum RCTeams for value: RCTeams
            /// </summary>
            [EnumMember(Value = "RCTeams")]
            RCTeams = 44,

            /// <summary>
            /// Enum RingOut for value: RingOut
            /// </summary>
            [EnumMember(Value = "RingOut")]
            RingOut = 45,

            /// <summary>
            /// Enum SalesForce for value: SalesForce
            /// </summary>
            [EnumMember(Value = "SalesForce")]
            SalesForce = 46,

            /// <summary>
            /// Enum SharedLines for value: SharedLines
            /// </summary>
            [EnumMember(Value = "SharedLines")]
            SharedLines = 47,

            /// <summary>
            /// Enum SingleExtensionUI for value: SingleExtensionUI
            /// </summary>
            [EnumMember(Value = "SingleExtensionUI")]
            SingleExtensionUI = 48,

            /// <summary>
            /// Enum SiteCodes for value: SiteCodes
            /// </summary>
            [EnumMember(Value = "SiteCodes")]
            SiteCodes = 49,

            /// <summary>
            /// Enum SMS for value: SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMS = 50,

            /// <summary>
            /// Enum SMSReceiving for value: SMSReceiving
            /// </summary>
            [EnumMember(Value = "SMSReceiving")]
            SMSReceiving = 51,

            /// <summary>
            /// Enum SoftPhoneUpdate for value: SoftPhoneUpdate
            /// </summary>
            [EnumMember(Value = "SoftPhoneUpdate")]
            SoftPhoneUpdate = 52,

            /// <summary>
            /// Enum TelephonySessions for value: TelephonySessions
            /// </summary>
            [EnumMember(Value = "TelephonySessions")]
            TelephonySessions = 53,

            /// <summary>
            /// Enum UserManagement for value: UserManagement
            /// </summary>
            [EnumMember(Value = "UserManagement")]
            UserManagement = 54,

            /// <summary>
            /// Enum VideoConferencing for value: VideoConferencing
            /// </summary>
            [EnumMember(Value = "VideoConferencing")]
            VideoConferencing = 55,

            /// <summary>
            /// Enum VoipCalling for value: VoipCalling
            /// </summary>
            [EnumMember(Value = "VoipCalling")]
            VoipCalling = 56,

            /// <summary>
            /// Enum VoipCallingOnMobile for value: VoipCallingOnMobile
            /// </summary>
            [EnumMember(Value = "VoipCallingOnMobile")]
            VoipCallingOnMobile = 57,

            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 58,

            /// <summary>
            /// Enum VoicemailToText for value: VoicemailToText
            /// </summary>
            [EnumMember(Value = "VoicemailToText")]
            VoicemailToText = 59,

            /// <summary>
            /// Enum WebPhone for value: WebPhone
            /// </summary>
            [EnumMember(Value = "WebPhone")]
            WebPhone = 60

        }

        /// <summary>
        /// Feature name
        /// </summary>
        /// <value>Feature name</value>
        [DataMember(Name="featureName", EmitDefaultValue=false)]
        public FeatureNameEnum? FeatureName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionServiceFeatureInfo" /> class.
        /// </summary>
        /// <param name="enabled">Feature status; shows feature availability for an extension.</param>
        /// <param name="featureName">Feature name.</param>
        /// <param name="reason">Reason for limitation of a particular service feature. Returned only if the enabled parameter value is &#39;False&#39;, see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response.</param>
        public ExtensionServiceFeatureInfo(bool enabled = default(bool), FeatureNameEnum? featureName = default(FeatureNameEnum?), string reason = default(string))
        {
            this.Enabled = enabled;
            this.FeatureName = featureName;
            this.Reason = reason;
        }

        /// <summary>
        /// Feature status; shows feature availability for an extension
        /// </summary>
        /// <value>Feature status; shows feature availability for an extension</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }


        /// <summary>
        /// Reason for limitation of a particular service feature. Returned only if the enabled parameter value is &#39;False&#39;, see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response
        /// </summary>
        /// <value>Reason for limitation of a particular service feature. Returned only if the enabled parameter value is &#39;False&#39;, see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionServiceFeatureInfo {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as ExtensionServiceFeatureInfo);
        }

        /// <summary>
        /// Returns true if ExtensionServiceFeatureInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensionServiceFeatureInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionServiceFeatureInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.FeatureName == input.FeatureName ||
                    (this.FeatureName != null &&
                    this.FeatureName.Equals(input.FeatureName))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.FeatureName != null)
                    hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
