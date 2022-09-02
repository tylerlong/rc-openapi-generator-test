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
    /// AnsweringRuleInfo
    /// </summary>
    [DataContract]
    public partial class AnsweringRuleInfo :  IEquatable<AnsweringRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of an answering rule
        /// </summary>
        /// <value>Type of an answering rule</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BusinessHours for value: BusinessHours
            /// </summary>
            [EnumMember(Value = "BusinessHours")]
            BusinessHours = 1,

            /// <summary>
            /// Enum AfterHours for value: AfterHours
            /// </summary>
            [EnumMember(Value = "AfterHours")]
            AfterHours = 2,

            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 3

        }

        /// <summary>
        /// Type of an answering rule
        /// </summary>
        /// <value>Type of an answering rule</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Specifies how incoming calls are forwarded
        /// </summary>
        /// <value>Specifies how incoming calls are forwarded</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CallHandlingActionEnum
        {
            /// <summary>
            /// Enum ForwardCalls for value: ForwardCalls
            /// </summary>
            [EnumMember(Value = "ForwardCalls")]
            ForwardCalls = 1,

            /// <summary>
            /// Enum UnconditionalForwarding for value: UnconditionalForwarding
            /// </summary>
            [EnumMember(Value = "UnconditionalForwarding")]
            UnconditionalForwarding = 2,

            /// <summary>
            /// Enum AgentQueue for value: AgentQueue
            /// </summary>
            [EnumMember(Value = "AgentQueue")]
            AgentQueue = 3,

            /// <summary>
            /// Enum TransferToExtension for value: TransferToExtension
            /// </summary>
            [EnumMember(Value = "TransferToExtension")]
            TransferToExtension = 4,

            /// <summary>
            /// Enum TakeMessagesOnly for value: TakeMessagesOnly
            /// </summary>
            [EnumMember(Value = "TakeMessagesOnly")]
            TakeMessagesOnly = 5,

            /// <summary>
            /// Enum PlayAnnouncementOnly for value: PlayAnnouncementOnly
            /// </summary>
            [EnumMember(Value = "PlayAnnouncementOnly")]
            PlayAnnouncementOnly = 6,

            /// <summary>
            /// Enum SharedLines for value: SharedLines
            /// </summary>
            [EnumMember(Value = "SharedLines")]
            SharedLines = 7

        }

        /// <summary>
        /// Specifies how incoming calls are forwarded
        /// </summary>
        /// <value>Specifies how incoming calls are forwarded</value>
        [DataMember(Name="callHandlingAction", EmitDefaultValue=false)]
        public CallHandlingActionEnum? CallHandlingAction { get; set; }
        /// <summary>
        /// Call screening status. &#39;Off&#39; - no call screening; &#39;NoCallerId&#39; - if caller ID is missing, then callers are asked to say their name before connecting; &#39;UnknownCallerId&#39; - if caller ID is not in contact list, then callers are asked to say their name before connecting; &#39;Always&#39; - the callers are always asked to say their name before connecting. The default value is &#39;Off&#39;
        /// </summary>
        /// <value>Call screening status. &#39;Off&#39; - no call screening; &#39;NoCallerId&#39; - if caller ID is missing, then callers are asked to say their name before connecting; &#39;UnknownCallerId&#39; - if caller ID is not in contact list, then callers are asked to say their name before connecting; &#39;Always&#39; - the callers are always asked to say their name before connecting. The default value is &#39;Off&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScreeningEnum
        {
            /// <summary>
            /// Enum Off for value: Off
            /// </summary>
            [EnumMember(Value = "Off")]
            Off = 1,

            /// <summary>
            /// Enum NoCallerId for value: NoCallerId
            /// </summary>
            [EnumMember(Value = "NoCallerId")]
            NoCallerId = 2,

            /// <summary>
            /// Enum UnknownCallerId for value: UnknownCallerId
            /// </summary>
            [EnumMember(Value = "UnknownCallerId")]
            UnknownCallerId = 3,

            /// <summary>
            /// Enum Always for value: Always
            /// </summary>
            [EnumMember(Value = "Always")]
            Always = 4

        }

        /// <summary>
        /// Call screening status. &#39;Off&#39; - no call screening; &#39;NoCallerId&#39; - if caller ID is missing, then callers are asked to say their name before connecting; &#39;UnknownCallerId&#39; - if caller ID is not in contact list, then callers are asked to say their name before connecting; &#39;Always&#39; - the callers are always asked to say their name before connecting. The default value is &#39;Off&#39;
        /// </summary>
        /// <value>Call screening status. &#39;Off&#39; - no call screening; &#39;NoCallerId&#39; - if caller ID is missing, then callers are asked to say their name before connecting; &#39;UnknownCallerId&#39; - if caller ID is not in contact list, then callers are asked to say their name before connecting; &#39;Always&#39; - the callers are always asked to say their name before connecting. The default value is &#39;Off&#39;</value>
        [DataMember(Name="screening", EmitDefaultValue=false)]
        public ScreeningEnum? Screening { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnsweringRuleInfo" /> class.
        /// </summary>
        /// <param name="uri">Canonical URI to an answering rule resource.</param>
        /// <param name="id">Internal identifier of an answering rule.</param>
        /// <param name="type">Type of an answering rule.</param>
        /// <param name="name">Name of an answering rule specified by user.</param>
        /// <param name="enabled">Specifies if an answering rule is active or inactive.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="calledNumbers">Answering rules are applied when calling to selected number(s).</param>
        /// <param name="callers">Answering rules are applied when calls are received from specified caller(s).</param>
        /// <param name="callHandlingAction">Specifies how incoming calls are forwarded.</param>
        /// <param name="forwarding">forwarding.</param>
        /// <param name="unconditionalForwarding">unconditionalForwarding.</param>
        /// <param name="queue">queue.</param>
        /// <param name="transfer">transfer.</param>
        /// <param name="voicemail">voicemail.</param>
        /// <param name="greetings">Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List.</param>
        /// <param name="screening">Call screening status. &#39;Off&#39; - no call screening; &#39;NoCallerId&#39; - if caller ID is missing, then callers are asked to say their name before connecting; &#39;UnknownCallerId&#39; - if caller ID is not in contact list, then callers are asked to say their name before connecting; &#39;Always&#39; - the callers are always asked to say their name before connecting. The default value is &#39;Off&#39;.</param>
        /// <param name="sharedLines">sharedLines.</param>
        /// <param name="missedCall">missedCall.</param>
        public AnsweringRuleInfo(string uri = default(string), string id = default(string), TypeEnum? type = default(TypeEnum?), string name = default(string), bool enabled = default(bool), ScheduleInfo schedule = default(ScheduleInfo), List<CalledNumberInfo> calledNumbers = default(List<CalledNumberInfo>), List<CallersInfo> callers = default(List<CallersInfo>), CallHandlingActionEnum? callHandlingAction = default(CallHandlingActionEnum?), ForwardingInfo forwarding = default(ForwardingInfo), UnconditionalForwardingInfo unconditionalForwarding = default(UnconditionalForwardingInfo), QueueInfo queue = default(QueueInfo), TransferredExtensionInfo transfer = default(TransferredExtensionInfo), VoicemailInfo voicemail = default(VoicemailInfo), List<GreetingInfo> greetings = default(List<GreetingInfo>), ScreeningEnum? screening = default(ScreeningEnum?), SharedLinesInfo sharedLines = default(SharedLinesInfo), MissedCallInfo missedCall = default(MissedCallInfo))
        {
            this.Uri = uri;
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.Enabled = enabled;
            this.Schedule = schedule;
            this.CalledNumbers = calledNumbers;
            this.Callers = callers;
            this.CallHandlingAction = callHandlingAction;
            this.Forwarding = forwarding;
            this.UnconditionalForwarding = unconditionalForwarding;
            this.Queue = queue;
            this.Transfer = transfer;
            this.Voicemail = voicemail;
            this.Greetings = greetings;
            this.Screening = screening;
            this.SharedLines = sharedLines;
            this.MissedCall = missedCall;
        }

        /// <summary>
        /// Canonical URI to an answering rule resource
        /// </summary>
        /// <value>Canonical URI to an answering rule resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Internal identifier of an answering rule
        /// </summary>
        /// <value>Internal identifier of an answering rule</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Name of an answering rule specified by user
        /// </summary>
        /// <value>Name of an answering rule specified by user</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies if an answering rule is active or inactive
        /// </summary>
        /// <value>Specifies if an answering rule is active or inactive</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public ScheduleInfo Schedule { get; set; }

        /// <summary>
        /// Answering rules are applied when calling to selected number(s)
        /// </summary>
        /// <value>Answering rules are applied when calling to selected number(s)</value>
        [DataMember(Name="calledNumbers", EmitDefaultValue=false)]
        public List<CalledNumberInfo> CalledNumbers { get; set; }

        /// <summary>
        /// Answering rules are applied when calls are received from specified caller(s)
        /// </summary>
        /// <value>Answering rules are applied when calls are received from specified caller(s)</value>
        [DataMember(Name="callers", EmitDefaultValue=false)]
        public List<CallersInfo> Callers { get; set; }


        /// <summary>
        /// Gets or Sets Forwarding
        /// </summary>
        [DataMember(Name="forwarding", EmitDefaultValue=false)]
        public ForwardingInfo Forwarding { get; set; }

        /// <summary>
        /// Gets or Sets UnconditionalForwarding
        /// </summary>
        [DataMember(Name="unconditionalForwarding", EmitDefaultValue=false)]
        public UnconditionalForwardingInfo UnconditionalForwarding { get; set; }

        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public QueueInfo Queue { get; set; }

        /// <summary>
        /// Gets or Sets Transfer
        /// </summary>
        [DataMember(Name="transfer", EmitDefaultValue=false)]
        public TransferredExtensionInfo Transfer { get; set; }

        /// <summary>
        /// Gets or Sets Voicemail
        /// </summary>
        [DataMember(Name="voicemail", EmitDefaultValue=false)]
        public VoicemailInfo Voicemail { get; set; }

        /// <summary>
        /// Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        /// </summary>
        /// <value>Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List</value>
        [DataMember(Name="greetings", EmitDefaultValue=false)]
        public List<GreetingInfo> Greetings { get; set; }


        /// <summary>
        /// Gets or Sets SharedLines
        /// </summary>
        [DataMember(Name="sharedLines", EmitDefaultValue=false)]
        public SharedLinesInfo SharedLines { get; set; }

        /// <summary>
        /// Gets or Sets MissedCall
        /// </summary>
        [DataMember(Name="missedCall", EmitDefaultValue=false)]
        public MissedCallInfo MissedCall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnsweringRuleInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  CalledNumbers: ").Append(CalledNumbers).Append("\n");
            sb.Append("  Callers: ").Append(Callers).Append("\n");
            sb.Append("  CallHandlingAction: ").Append(CallHandlingAction).Append("\n");
            sb.Append("  Forwarding: ").Append(Forwarding).Append("\n");
            sb.Append("  UnconditionalForwarding: ").Append(UnconditionalForwarding).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Transfer: ").Append(Transfer).Append("\n");
            sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
            sb.Append("  Greetings: ").Append(Greetings).Append("\n");
            sb.Append("  Screening: ").Append(Screening).Append("\n");
            sb.Append("  SharedLines: ").Append(SharedLines).Append("\n");
            sb.Append("  MissedCall: ").Append(MissedCall).Append("\n");
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
            return this.Equals(input as AnsweringRuleInfo);
        }

        /// <summary>
        /// Returns true if AnsweringRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AnsweringRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnsweringRuleInfo input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.CalledNumbers == input.CalledNumbers ||
                    this.CalledNumbers != null &&
                    input.CalledNumbers != null &&
                    this.CalledNumbers.SequenceEqual(input.CalledNumbers)
                ) && 
                (
                    this.Callers == input.Callers ||
                    this.Callers != null &&
                    input.Callers != null &&
                    this.Callers.SequenceEqual(input.Callers)
                ) && 
                (
                    this.CallHandlingAction == input.CallHandlingAction ||
                    (this.CallHandlingAction != null &&
                    this.CallHandlingAction.Equals(input.CallHandlingAction))
                ) && 
                (
                    this.Forwarding == input.Forwarding ||
                    (this.Forwarding != null &&
                    this.Forwarding.Equals(input.Forwarding))
                ) && 
                (
                    this.UnconditionalForwarding == input.UnconditionalForwarding ||
                    (this.UnconditionalForwarding != null &&
                    this.UnconditionalForwarding.Equals(input.UnconditionalForwarding))
                ) && 
                (
                    this.Queue == input.Queue ||
                    (this.Queue != null &&
                    this.Queue.Equals(input.Queue))
                ) && 
                (
                    this.Transfer == input.Transfer ||
                    (this.Transfer != null &&
                    this.Transfer.Equals(input.Transfer))
                ) && 
                (
                    this.Voicemail == input.Voicemail ||
                    (this.Voicemail != null &&
                    this.Voicemail.Equals(input.Voicemail))
                ) && 
                (
                    this.Greetings == input.Greetings ||
                    this.Greetings != null &&
                    input.Greetings != null &&
                    this.Greetings.SequenceEqual(input.Greetings)
                ) && 
                (
                    this.Screening == input.Screening ||
                    (this.Screening != null &&
                    this.Screening.Equals(input.Screening))
                ) && 
                (
                    this.SharedLines == input.SharedLines ||
                    (this.SharedLines != null &&
                    this.SharedLines.Equals(input.SharedLines))
                ) && 
                (
                    this.MissedCall == input.MissedCall ||
                    (this.MissedCall != null &&
                    this.MissedCall.Equals(input.MissedCall))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.CalledNumbers != null)
                    hashCode = hashCode * 59 + this.CalledNumbers.GetHashCode();
                if (this.Callers != null)
                    hashCode = hashCode * 59 + this.Callers.GetHashCode();
                if (this.CallHandlingAction != null)
                    hashCode = hashCode * 59 + this.CallHandlingAction.GetHashCode();
                if (this.Forwarding != null)
                    hashCode = hashCode * 59 + this.Forwarding.GetHashCode();
                if (this.UnconditionalForwarding != null)
                    hashCode = hashCode * 59 + this.UnconditionalForwarding.GetHashCode();
                if (this.Queue != null)
                    hashCode = hashCode * 59 + this.Queue.GetHashCode();
                if (this.Transfer != null)
                    hashCode = hashCode * 59 + this.Transfer.GetHashCode();
                if (this.Voicemail != null)
                    hashCode = hashCode * 59 + this.Voicemail.GetHashCode();
                if (this.Greetings != null)
                    hashCode = hashCode * 59 + this.Greetings.GetHashCode();
                if (this.Screening != null)
                    hashCode = hashCode * 59 + this.Screening.GetHashCode();
                if (this.SharedLines != null)
                    hashCode = hashCode * 59 + this.SharedLines.GetHashCode();
                if (this.MissedCall != null)
                    hashCode = hashCode * 59 + this.MissedCall.GetHashCode();
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
