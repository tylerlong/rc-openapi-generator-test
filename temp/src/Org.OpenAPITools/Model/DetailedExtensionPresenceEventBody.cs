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
    /// Notification payload body
    /// </summary>
    [DataContract]
    public partial class DetailedExtensionPresenceEventBody :  IEquatable<DetailedExtensionPresenceEventBody>, IValidatableObject
    {
        /// <summary>
        /// Telephony presence status. Returned if telephony status is changed.
        /// </summary>
        /// <value>Telephony presence status. Returned if telephony status is changed.</value>
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
        /// Telephony presence status. Returned if telephony status is changed.
        /// </summary>
        /// <value>Telephony presence status. Returned if telephony status is changed.</value>
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
        /// User-defined presence status (as previously published by the user)
        /// </summary>
        /// <value>User-defined presence status (as previously published by the user)</value>
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
        /// User-defined presence status (as previously published by the user)
        /// </summary>
        /// <value>User-defined presence status (as previously published by the user)</value>
        [DataMember(Name="userStatus", EmitDefaultValue=false)]
        public UserStatusEnum? UserStatus { get; set; }
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
        /// Extended DnD (Do not Disturb) status
        /// </summary>
        /// <value>Extended DnD (Do not Disturb) status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DndStatusEnum
        {
            /// <summary>
            /// Enum TakeAllCalls for value: TakeAllCalls
            /// </summary>
            [EnumMember(Value = "TakeAllCalls")]
            TakeAllCalls = 1,

            /// <summary>
            /// Enum DoNotAcceptAnyCalls for value: DoNotAcceptAnyCalls
            /// </summary>
            [EnumMember(Value = "DoNotAcceptAnyCalls")]
            DoNotAcceptAnyCalls = 2,

            /// <summary>
            /// Enum DoNotAcceptDepartmentCalls for value: DoNotAcceptDepartmentCalls
            /// </summary>
            [EnumMember(Value = "DoNotAcceptDepartmentCalls")]
            DoNotAcceptDepartmentCalls = 3,

            /// <summary>
            /// Enum TakeDepartmentCallsOnly for value: TakeDepartmentCallsOnly
            /// </summary>
            [EnumMember(Value = "TakeDepartmentCallsOnly")]
            TakeDepartmentCallsOnly = 4

        }

        /// <summary>
        /// Extended DnD (Do not Disturb) status
        /// </summary>
        /// <value>Extended DnD (Do not Disturb) status</value>
        [DataMember(Name="dndStatus", EmitDefaultValue=false)]
        public DndStatusEnum? DndStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedExtensionPresenceEventBody" /> class.
        /// </summary>
        /// <param name="extensionId">Internal identifier of an extension (default to &quot;~&quot;).</param>
        /// <param name="telephonyStatus">Telephony presence status. Returned if telephony status is changed..</param>
        /// <param name="activeCalls">List of the latest 7 active calls on extension.</param>
        /// <param name="sequence">Order number of a notification to state the chronology.</param>
        /// <param name="presenceStatus">Aggregated presence status, calculated from a number of sources.</param>
        /// <param name="userStatus">User-defined presence status (as previously published by the user).</param>
        /// <param name="meetingStatus">Meetings presence status.</param>
        /// <param name="dndStatus">Extended DnD (Do not Disturb) status.</param>
        /// <param name="allowSeeMyPresence">If &#39;True&#39; enables other extensions to see the extension presence status.</param>
        /// <param name="ringOnMonitoredCall">If &#39;True&#39; enables to ring extension phone, if any user monitored by this extension is ringing.</param>
        /// <param name="pickUpCallsOnHold">If &#39;True&#39; enables the extension user to pick up a monitored line on hold.</param>
        /// <param name="totalActiveCalls">Total number of active calls on extension at the present moment.</param>
        /// <param name="ownerId">Internal identifier of a subscription owner extension.</param>
        public DetailedExtensionPresenceEventBody(string extensionId = "~", TelephonyStatusEnum? telephonyStatus = default(TelephonyStatusEnum?), List<ActiveCallInfoWithoutSIP> activeCalls = default(List<ActiveCallInfoWithoutSIP>), int sequence = default(int), PresenceStatusEnum? presenceStatus = default(PresenceStatusEnum?), UserStatusEnum? userStatus = default(UserStatusEnum?), MeetingStatusEnum? meetingStatus = default(MeetingStatusEnum?), DndStatusEnum? dndStatus = default(DndStatusEnum?), bool allowSeeMyPresence = default(bool), bool ringOnMonitoredCall = default(bool), bool pickUpCallsOnHold = default(bool), int totalActiveCalls = default(int), string ownerId = default(string))
        {
            // use default value if no "extensionId" provided
            if (extensionId == null)
            {
                this.ExtensionId = "~";
            }
            else
            {
                this.ExtensionId = extensionId;
            }
            this.TelephonyStatus = telephonyStatus;
            this.ActiveCalls = activeCalls;
            this.Sequence = sequence;
            this.PresenceStatus = presenceStatus;
            this.UserStatus = userStatus;
            this.MeetingStatus = meetingStatus;
            this.DndStatus = dndStatus;
            this.AllowSeeMyPresence = allowSeeMyPresence;
            this.RingOnMonitoredCall = ringOnMonitoredCall;
            this.PickUpCallsOnHold = pickUpCallsOnHold;
            this.TotalActiveCalls = totalActiveCalls;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="extensionId", EmitDefaultValue=false)]
        public string ExtensionId { get; set; }


        /// <summary>
        /// List of the latest 7 active calls on extension
        /// </summary>
        /// <value>List of the latest 7 active calls on extension</value>
        [DataMember(Name="activeCalls", EmitDefaultValue=false)]
        public List<ActiveCallInfoWithoutSIP> ActiveCalls { get; set; }

        /// <summary>
        /// Order number of a notification to state the chronology
        /// </summary>
        /// <value>Order number of a notification to state the chronology</value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public int Sequence { get; set; }





        /// <summary>
        /// If &#39;True&#39; enables other extensions to see the extension presence status
        /// </summary>
        /// <value>If &#39;True&#39; enables other extensions to see the extension presence status</value>
        [DataMember(Name="allowSeeMyPresence", EmitDefaultValue=false)]
        public bool AllowSeeMyPresence { get; set; }

        /// <summary>
        /// If &#39;True&#39; enables to ring extension phone, if any user monitored by this extension is ringing
        /// </summary>
        /// <value>If &#39;True&#39; enables to ring extension phone, if any user monitored by this extension is ringing</value>
        [DataMember(Name="ringOnMonitoredCall", EmitDefaultValue=false)]
        public bool RingOnMonitoredCall { get; set; }

        /// <summary>
        /// If &#39;True&#39; enables the extension user to pick up a monitored line on hold
        /// </summary>
        /// <value>If &#39;True&#39; enables the extension user to pick up a monitored line on hold</value>
        [DataMember(Name="pickUpCallsOnHold", EmitDefaultValue=false)]
        public bool PickUpCallsOnHold { get; set; }

        /// <summary>
        /// Total number of active calls on extension at the present moment
        /// </summary>
        /// <value>Total number of active calls on extension at the present moment</value>
        [DataMember(Name="totalActiveCalls", EmitDefaultValue=false)]
        public int TotalActiveCalls { get; set; }

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        /// <value>Internal identifier of a subscription owner extension</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedExtensionPresenceEventBody {\n");
            sb.Append("  ExtensionId: ").Append(ExtensionId).Append("\n");
            sb.Append("  TelephonyStatus: ").Append(TelephonyStatus).Append("\n");
            sb.Append("  ActiveCalls: ").Append(ActiveCalls).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  PresenceStatus: ").Append(PresenceStatus).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  MeetingStatus: ").Append(MeetingStatus).Append("\n");
            sb.Append("  DndStatus: ").Append(DndStatus).Append("\n");
            sb.Append("  AllowSeeMyPresence: ").Append(AllowSeeMyPresence).Append("\n");
            sb.Append("  RingOnMonitoredCall: ").Append(RingOnMonitoredCall).Append("\n");
            sb.Append("  PickUpCallsOnHold: ").Append(PickUpCallsOnHold).Append("\n");
            sb.Append("  TotalActiveCalls: ").Append(TotalActiveCalls).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
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
            return this.Equals(input as DetailedExtensionPresenceEventBody);
        }

        /// <summary>
        /// Returns true if DetailedExtensionPresenceEventBody instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedExtensionPresenceEventBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedExtensionPresenceEventBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtensionId == input.ExtensionId ||
                    (this.ExtensionId != null &&
                    this.ExtensionId.Equals(input.ExtensionId))
                ) && 
                (
                    this.TelephonyStatus == input.TelephonyStatus ||
                    (this.TelephonyStatus != null &&
                    this.TelephonyStatus.Equals(input.TelephonyStatus))
                ) && 
                (
                    this.ActiveCalls == input.ActiveCalls ||
                    this.ActiveCalls != null &&
                    input.ActiveCalls != null &&
                    this.ActiveCalls.SequenceEqual(input.ActiveCalls)
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.PresenceStatus == input.PresenceStatus ||
                    (this.PresenceStatus != null &&
                    this.PresenceStatus.Equals(input.PresenceStatus))
                ) && 
                (
                    this.UserStatus == input.UserStatus ||
                    (this.UserStatus != null &&
                    this.UserStatus.Equals(input.UserStatus))
                ) && 
                (
                    this.MeetingStatus == input.MeetingStatus ||
                    (this.MeetingStatus != null &&
                    this.MeetingStatus.Equals(input.MeetingStatus))
                ) && 
                (
                    this.DndStatus == input.DndStatus ||
                    (this.DndStatus != null &&
                    this.DndStatus.Equals(input.DndStatus))
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
                    this.TotalActiveCalls == input.TotalActiveCalls ||
                    (this.TotalActiveCalls != null &&
                    this.TotalActiveCalls.Equals(input.TotalActiveCalls))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
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
                if (this.ExtensionId != null)
                    hashCode = hashCode * 59 + this.ExtensionId.GetHashCode();
                if (this.TelephonyStatus != null)
                    hashCode = hashCode * 59 + this.TelephonyStatus.GetHashCode();
                if (this.ActiveCalls != null)
                    hashCode = hashCode * 59 + this.ActiveCalls.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.PresenceStatus != null)
                    hashCode = hashCode * 59 + this.PresenceStatus.GetHashCode();
                if (this.UserStatus != null)
                    hashCode = hashCode * 59 + this.UserStatus.GetHashCode();
                if (this.MeetingStatus != null)
                    hashCode = hashCode * 59 + this.MeetingStatus.GetHashCode();
                if (this.DndStatus != null)
                    hashCode = hashCode * 59 + this.DndStatus.GetHashCode();
                if (this.AllowSeeMyPresence != null)
                    hashCode = hashCode * 59 + this.AllowSeeMyPresence.GetHashCode();
                if (this.RingOnMonitoredCall != null)
                    hashCode = hashCode * 59 + this.RingOnMonitoredCall.GetHashCode();
                if (this.PickUpCallsOnHold != null)
                    hashCode = hashCode * 59 + this.PickUpCallsOnHold.GetHashCode();
                if (this.TotalActiveCalls != null)
                    hashCode = hashCode * 59 + this.TotalActiveCalls.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
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
