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
    /// Status data of a call session
    /// </summary>
    [DataContract]
    public partial class CallStatusInfo :  IEquatable<CallStatusInfo>, IValidatableObject
    {
        /// <summary>
        /// Status code of a call
        /// </summary>
        /// <value>Status code of a call</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum Setup for value: Setup
            /// </summary>
            [EnumMember(Value = "Setup")]
            Setup = 1,

            /// <summary>
            /// Enum Proceeding for value: Proceeding
            /// </summary>
            [EnumMember(Value = "Proceeding")]
            Proceeding = 2,

            /// <summary>
            /// Enum Answered for value: Answered
            /// </summary>
            [EnumMember(Value = "Answered")]
            Answered = 3,

            /// <summary>
            /// Enum Disconnected for value: Disconnected
            /// </summary>
            [EnumMember(Value = "Disconnected")]
            Disconnected = 4,

            /// <summary>
            /// Enum Gone for value: Gone
            /// </summary>
            [EnumMember(Value = "Gone")]
            Gone = 5,

            /// <summary>
            /// Enum Parked for value: Parked
            /// </summary>
            [EnumMember(Value = "Parked")]
            Parked = 6,

            /// <summary>
            /// Enum Hold for value: Hold
            /// </summary>
            [EnumMember(Value = "Hold")]
            Hold = 7,

            /// <summary>
            /// Enum VoiceMail for value: VoiceMail
            /// </summary>
            [EnumMember(Value = "VoiceMail")]
            VoiceMail = 8,

            /// <summary>
            /// Enum FaxReceive for value: FaxReceive
            /// </summary>
            [EnumMember(Value = "FaxReceive")]
            FaxReceive = 9,

            /// <summary>
            /// Enum VoiceMailScreening for value: VoiceMailScreening
            /// </summary>
            [EnumMember(Value = "VoiceMailScreening")]
            VoiceMailScreening = 10

        }

        /// <summary>
        /// Status code of a call
        /// </summary>
        /// <value>Status code of a call</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum? Code { get; set; }
        /// <summary>
        /// Reason for call termination. For &#39;Disconnected&#39; code only
        /// </summary>
        /// <value>Reason for call termination. For &#39;Disconnected&#39; code only</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum Pickup for value: Pickup
            /// </summary>
            [EnumMember(Value = "Pickup")]
            Pickup = 1,

            /// <summary>
            /// Enum Supervising for value: Supervising
            /// </summary>
            [EnumMember(Value = "Supervising")]
            Supervising = 2,

            /// <summary>
            /// Enum TakeOver for value: TakeOver
            /// </summary>
            [EnumMember(Value = "TakeOver")]
            TakeOver = 3,

            /// <summary>
            /// Enum Timeout for value: Timeout
            /// </summary>
            [EnumMember(Value = "Timeout")]
            Timeout = 4,

            /// <summary>
            /// Enum BlindTransfer for value: BlindTransfer
            /// </summary>
            [EnumMember(Value = "BlindTransfer")]
            BlindTransfer = 5,

            /// <summary>
            /// Enum RccTransfer for value: RccTransfer
            /// </summary>
            [EnumMember(Value = "RccTransfer")]
            RccTransfer = 6,

            /// <summary>
            /// Enum AttendedTransfer for value: AttendedTransfer
            /// </summary>
            [EnumMember(Value = "AttendedTransfer")]
            AttendedTransfer = 7,

            /// <summary>
            /// Enum CallerInputRedirect for value: CallerInputRedirect
            /// </summary>
            [EnumMember(Value = "CallerInputRedirect")]
            CallerInputRedirect = 8,

            /// <summary>
            /// Enum CallFlip for value: CallFlip
            /// </summary>
            [EnumMember(Value = "CallFlip")]
            CallFlip = 9,

            /// <summary>
            /// Enum ParkLocation for value: ParkLocation
            /// </summary>
            [EnumMember(Value = "ParkLocation")]
            ParkLocation = 10,

            /// <summary>
            /// Enum DtmfTransfer for value: DtmfTransfer
            /// </summary>
            [EnumMember(Value = "DtmfTransfer")]
            DtmfTransfer = 11,

            /// <summary>
            /// Enum AgentAnswered for value: AgentAnswered
            /// </summary>
            [EnumMember(Value = "AgentAnswered")]
            AgentAnswered = 12,

            /// <summary>
            /// Enum AgentDropped for value: AgentDropped
            /// </summary>
            [EnumMember(Value = "AgentDropped")]
            AgentDropped = 13,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 14,

            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 15,

            /// <summary>
            /// Enum InternalError for value: InternalError
            /// </summary>
            [EnumMember(Value = "InternalError")]
            InternalError = 16,

            /// <summary>
            /// Enum NoAnswer for value: NoAnswer
            /// </summary>
            [EnumMember(Value = "NoAnswer")]
            NoAnswer = 17,

            /// <summary>
            /// Enum TargetBusy for value: TargetBusy
            /// </summary>
            [EnumMember(Value = "TargetBusy")]
            TargetBusy = 18,

            /// <summary>
            /// Enum InvalidNumber for value: InvalidNumber
            /// </summary>
            [EnumMember(Value = "InvalidNumber")]
            InvalidNumber = 19,

            /// <summary>
            /// Enum InternationalDisabled for value: InternationalDisabled
            /// </summary>
            [EnumMember(Value = "InternationalDisabled")]
            InternationalDisabled = 20,

            /// <summary>
            /// Enum DestinationBlocked for value: DestinationBlocked
            /// </summary>
            [EnumMember(Value = "DestinationBlocked")]
            DestinationBlocked = 21,

            /// <summary>
            /// Enum NotEnoughFunds for value: NotEnoughFunds
            /// </summary>
            [EnumMember(Value = "NotEnoughFunds")]
            NotEnoughFunds = 22,

            /// <summary>
            /// Enum NoSuchUser for value: NoSuchUser
            /// </summary>
            [EnumMember(Value = "NoSuchUser")]
            NoSuchUser = 23,

            /// <summary>
            /// Enum CallPark for value: CallPark
            /// </summary>
            [EnumMember(Value = "CallPark")]
            CallPark = 24,

            /// <summary>
            /// Enum CallRedirected for value: CallRedirected
            /// </summary>
            [EnumMember(Value = "CallRedirected")]
            CallRedirected = 25,

            /// <summary>
            /// Enum CallReplied for value: CallReplied
            /// </summary>
            [EnumMember(Value = "CallReplied")]
            CallReplied = 26,

            /// <summary>
            /// Enum CallSwitch for value: CallSwitch
            /// </summary>
            [EnumMember(Value = "CallSwitch")]
            CallSwitch = 27,

            /// <summary>
            /// Enum CallFinished for value: CallFinished
            /// </summary>
            [EnumMember(Value = "CallFinished")]
            CallFinished = 28,

            /// <summary>
            /// Enum CallDropped for value: CallDropped
            /// </summary>
            [EnumMember(Value = "CallDropped")]
            CallDropped = 29

        }

        /// <summary>
        /// Reason for call termination. For &#39;Disconnected&#39; code only
        /// </summary>
        /// <value>Reason for call termination. For &#39;Disconnected&#39; code only</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallStatusInfo" /> class.
        /// </summary>
        /// <param name="code">Status code of a call.</param>
        /// <param name="peerId">peerId.</param>
        /// <param name="reason">Reason for call termination. For &#39;Disconnected&#39; code only.</param>
        /// <param name="description">Optional message.</param>
        public CallStatusInfo(CodeEnum? code = default(CodeEnum?), PeerInfo peerId = default(PeerInfo), ReasonEnum? reason = default(ReasonEnum?), string description = default(string))
        {
            this.Code = code;
            this.PeerId = peerId;
            this.Reason = reason;
            this.Description = description;
        }


        /// <summary>
        /// Gets or Sets PeerId
        /// </summary>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public PeerInfo PeerId { get; set; }


        /// <summary>
        /// Optional message
        /// </summary>
        /// <value>Optional message</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallStatusInfo {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CallStatusInfo);
        }

        /// <summary>
        /// Returns true if CallStatusInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CallStatusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallStatusInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.PeerId == input.PeerId ||
                    (this.PeerId != null &&
                    this.PeerId.Equals(input.PeerId))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.PeerId != null)
                    hashCode = hashCode * 59 + this.PeerId.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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