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
    /// PresenceInfoResponse
    /// </summary>
    [DataContract]
    public partial class PresenceInfoResponse :  IEquatable<PresenceInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines UserStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UserStatusEnum
        {
            /// <summary>
            /// Enum Offline for value: Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline = 1,

            /// <summary>
            /// Enum Busy for value: Busy
            /// </summary>
            [EnumMember(Value = "Busy")]
            Busy = 2,

            /// <summary>
            /// Enum Available for value: Available
            /// </summary>
            [EnumMember(Value = "Available")]
            Available = 3

        }

        /// <summary>
        /// Gets or Sets UserStatus
        /// </summary>
        [DataMember(Name="userStatus", EmitDefaultValue=false)]
        public UserStatusEnum? UserStatus { get; set; }
        /// <summary>
        /// Defines DndStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DndStatusEnum
        {
            /// <summary>
            /// Enum TakeAllCalls for value: TakeAllCalls
            /// </summary>
            [EnumMember(Value = "TakeAllCalls")]
            TakeAllCalls = 1,

            /// <summary>
            /// Enum DoNotAcceptDepartmentCalls for value: DoNotAcceptDepartmentCalls
            /// </summary>
            [EnumMember(Value = "DoNotAcceptDepartmentCalls")]
            DoNotAcceptDepartmentCalls = 2,

            /// <summary>
            /// Enum TakeDepartmentCallsOnly for value: TakeDepartmentCallsOnly
            /// </summary>
            [EnumMember(Value = "TakeDepartmentCallsOnly")]
            TakeDepartmentCallsOnly = 3,

            /// <summary>
            /// Enum DoNotAcceptAnyCalls for value: DoNotAcceptAnyCalls
            /// </summary>
            [EnumMember(Value = "DoNotAcceptAnyCalls")]
            DoNotAcceptAnyCalls = 4,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 5

        }

        /// <summary>
        /// Gets or Sets DndStatus
        /// </summary>
        [DataMember(Name="dndStatus", EmitDefaultValue=false)]
        public DndStatusEnum? DndStatus { get; set; }
        /// <summary>
        /// Meetings presence status
        /// </summary>
        /// <value>Meetings presence status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MeetingStatusEnum
        {
            /// <summary>
            /// Enum Connected for value: Connected
            /// </summary>
            [EnumMember(Value = "Connected")]
            Connected = 1,

            /// <summary>
            /// Enum Disconnected for value: Disconnected
            /// </summary>
            [EnumMember(Value = "Disconnected")]
            Disconnected = 2

        }

        /// <summary>
        /// Meetings presence status
        /// </summary>
        /// <value>Meetings presence status</value>
        [DataMember(Name="meetingStatus", EmitDefaultValue=false)]
        public MeetingStatusEnum? MeetingStatus { get; set; }
        /// <summary>
        /// Telephony presence status. Returned if telephony status is changed
        /// </summary>
        /// <value>Telephony presence status. Returned if telephony status is changed</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TelephonyStatusEnum
        {
            /// <summary>
            /// Enum NoCall for value: NoCall
            /// </summary>
            [EnumMember(Value = "NoCall")]
            NoCall = 1,

            /// <summary>
            /// Enum CallConnected for value: CallConnected
            /// </summary>
            [EnumMember(Value = "CallConnected")]
            CallConnected = 2,

            /// <summary>
            /// Enum Ringing for value: Ringing
            /// </summary>
            [EnumMember(Value = "Ringing")]
            Ringing = 3,

            /// <summary>
            /// Enum OnHold for value: OnHold
            /// </summary>
            [EnumMember(Value = "OnHold")]
            OnHold = 4,

            /// <summary>
            /// Enum ParkedCall for value: ParkedCall
            /// </summary>
            [EnumMember(Value = "ParkedCall")]
            ParkedCall = 5

        }

        /// <summary>
        /// Telephony presence status. Returned if telephony status is changed
        /// </summary>
        /// <value>Telephony presence status. Returned if telephony status is changed</value>
        [DataMember(Name="telephonyStatus", EmitDefaultValue=false)]
        public TelephonyStatusEnum? TelephonyStatus { get; set; }
        /// <summary>
        /// Aggregated presence status, calculated from a number of sources
        /// </summary>
        /// <value>Aggregated presence status, calculated from a number of sources</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PresenceStatusEnum
        {
            /// <summary>
            /// Enum Offline for value: Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline = 1,

            /// <summary>
            /// Enum Busy for value: Busy
            /// </summary>
            [EnumMember(Value = "Busy")]
            Busy = 2,

            /// <summary>
            /// Enum Available for value: Available
            /// </summary>
            [EnumMember(Value = "Available")]
            Available = 3

        }

        /// <summary>
        /// Aggregated presence status, calculated from a number of sources
        /// </summary>
        /// <value>Aggregated presence status, calculated from a number of sources</value>
        [DataMember(Name="presenceStatus", EmitDefaultValue=false)]
        public PresenceStatusEnum? PresenceStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceInfoResponse" /> class.
        /// </summary>
        /// <param name="uri">Link to the presence resource.</param>
        /// <param name="userStatus">userStatus.</param>
        /// <param name="dndStatus">dndStatus.</param>
        /// <param name="message">message.</param>
        /// <param name="allowSeeMyPresence">allowSeeMyPresence (default to false).</param>
        /// <param name="ringOnMonitoredCall">ringOnMonitoredCall (default to false).</param>
        /// <param name="pickUpCallsOnHold">pickUpCallsOnHold (default to false).</param>
        /// <param name="activeCalls">activeCalls.</param>
        /// <param name="extension">extension.</param>
        /// <param name="meetingStatus">Meetings presence status.</param>
        /// <param name="telephonyStatus">Telephony presence status. Returned if telephony status is changed.</param>
        /// <param name="presenceStatus">Aggregated presence status, calculated from a number of sources.</param>
        public PresenceInfoResponse(string uri = default(string), UserStatusEnum? userStatus = default(UserStatusEnum?), DndStatusEnum? dndStatus = default(DndStatusEnum?), string message = default(string), bool allowSeeMyPresence = false, bool ringOnMonitoredCall = false, bool pickUpCallsOnHold = false, List<ActiveCallInfo> activeCalls = default(List<ActiveCallInfo>), GetPresenceExtensionInfo extension = default(GetPresenceExtensionInfo), MeetingStatusEnum? meetingStatus = default(MeetingStatusEnum?), TelephonyStatusEnum? telephonyStatus = default(TelephonyStatusEnum?), PresenceStatusEnum? presenceStatus = default(PresenceStatusEnum?))
        {
            this.Uri = uri;
            this.UserStatus = userStatus;
            this.DndStatus = dndStatus;
            this.Message = message;
            // use default value if no "allowSeeMyPresence" provided
            if (allowSeeMyPresence == null)
            {
                this.AllowSeeMyPresence = false;
            }
            else
            {
                this.AllowSeeMyPresence = allowSeeMyPresence;
            }
            // use default value if no "ringOnMonitoredCall" provided
            if (ringOnMonitoredCall == null)
            {
                this.RingOnMonitoredCall = false;
            }
            else
            {
                this.RingOnMonitoredCall = ringOnMonitoredCall;
            }
            // use default value if no "pickUpCallsOnHold" provided
            if (pickUpCallsOnHold == null)
            {
                this.PickUpCallsOnHold = false;
            }
            else
            {
                this.PickUpCallsOnHold = pickUpCallsOnHold;
            }
            this.ActiveCalls = activeCalls;
            this.Extension = extension;
            this.MeetingStatus = meetingStatus;
            this.TelephonyStatus = telephonyStatus;
            this.PresenceStatus = presenceStatus;
        }

        /// <summary>
        /// Link to the presence resource
        /// </summary>
        /// <value>Link to the presence resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }



        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets AllowSeeMyPresence
        /// </summary>
        [DataMember(Name="allowSeeMyPresence", EmitDefaultValue=false)]
        public bool AllowSeeMyPresence { get; set; }

        /// <summary>
        /// Gets or Sets RingOnMonitoredCall
        /// </summary>
        [DataMember(Name="ringOnMonitoredCall", EmitDefaultValue=false)]
        public bool RingOnMonitoredCall { get; set; }

        /// <summary>
        /// Gets or Sets PickUpCallsOnHold
        /// </summary>
        [DataMember(Name="pickUpCallsOnHold", EmitDefaultValue=false)]
        public bool PickUpCallsOnHold { get; set; }

        /// <summary>
        /// Gets or Sets ActiveCalls
        /// </summary>
        [DataMember(Name="activeCalls", EmitDefaultValue=false)]
        public List<ActiveCallInfo> ActiveCalls { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public GetPresenceExtensionInfo Extension { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PresenceInfoResponse {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  DndStatus: ").Append(DndStatus).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  AllowSeeMyPresence: ").Append(AllowSeeMyPresence).Append("\n");
            sb.Append("  RingOnMonitoredCall: ").Append(RingOnMonitoredCall).Append("\n");
            sb.Append("  PickUpCallsOnHold: ").Append(PickUpCallsOnHold).Append("\n");
            sb.Append("  ActiveCalls: ").Append(ActiveCalls).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  MeetingStatus: ").Append(MeetingStatus).Append("\n");
            sb.Append("  TelephonyStatus: ").Append(TelephonyStatus).Append("\n");
            sb.Append("  PresenceStatus: ").Append(PresenceStatus).Append("\n");
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
            return this.Equals(input as PresenceInfoResponse);
        }

        /// <summary>
        /// Returns true if PresenceInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PresenceInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenceInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.UserStatus == input.UserStatus ||
                    (this.UserStatus != null &&
                    this.UserStatus.Equals(input.UserStatus))
                ) && 
                (
                    this.DndStatus == input.DndStatus ||
                    (this.DndStatus != null &&
                    this.DndStatus.Equals(input.DndStatus))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.AllowSeeMyPresence == input.AllowSeeMyPresence ||
                    (this.AllowSeeMyPresence != null &&
                    this.AllowSeeMyPresence.Equals(input.AllowSeeMyPresence))
                ) && 
                (
                    this.RingOnMonitoredCall == input.RingOnMonitoredCall ||
                    (this.RingOnMonitoredCall != null &&
                    this.RingOnMonitoredCall.Equals(input.RingOnMonitoredCall))
                ) && 
                (
                    this.PickUpCallsOnHold == input.PickUpCallsOnHold ||
                    (this.PickUpCallsOnHold != null &&
                    this.PickUpCallsOnHold.Equals(input.PickUpCallsOnHold))
                ) && 
                (
                    this.ActiveCalls == input.ActiveCalls ||
                    this.ActiveCalls != null &&
                    input.ActiveCalls != null &&
                    this.ActiveCalls.SequenceEqual(input.ActiveCalls)
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.MeetingStatus == input.MeetingStatus ||
                    (this.MeetingStatus != null &&
                    this.MeetingStatus.Equals(input.MeetingStatus))
                ) && 
                (
                    this.TelephonyStatus == input.TelephonyStatus ||
                    (this.TelephonyStatus != null &&
                    this.TelephonyStatus.Equals(input.TelephonyStatus))
                ) && 
                (
                    this.PresenceStatus == input.PresenceStatus ||
                    (this.PresenceStatus != null &&
                    this.PresenceStatus.Equals(input.PresenceStatus))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.UserStatus != null)
                    hashCode = hashCode * 59 + this.UserStatus.GetHashCode();
                if (this.DndStatus != null)
                    hashCode = hashCode * 59 + this.DndStatus.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.AllowSeeMyPresence != null)
                    hashCode = hashCode * 59 + this.AllowSeeMyPresence.GetHashCode();
                if (this.RingOnMonitoredCall != null)
                    hashCode = hashCode * 59 + this.RingOnMonitoredCall.GetHashCode();
                if (this.PickUpCallsOnHold != null)
                    hashCode = hashCode * 59 + this.PickUpCallsOnHold.GetHashCode();
                if (this.ActiveCalls != null)
                    hashCode = hashCode * 59 + this.ActiveCalls.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.MeetingStatus != null)
                    hashCode = hashCode * 59 + this.MeetingStatus.GetHashCode();
                if (this.TelephonyStatus != null)
                    hashCode = hashCode * 59 + this.TelephonyStatus.GetHashCode();
                if (this.PresenceStatus != null)
                    hashCode = hashCode * 59 + this.PresenceStatus.GetHashCode();
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
            // Message (string) maxLength
            if(this.Message != null && this.Message.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 75.", new [] { "Message" });
            }

            // Message (string) minLength
            if(this.Message != null && this.Message.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be greater than 0.", new [] { "Message" });
            }

            yield break;
        }
    }

}
