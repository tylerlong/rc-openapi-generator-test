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
    /// Queue settings applied for department (call queue) extension type, with the &#39;AgentQueue&#39; value specified as a call handling action
    /// </summary>
    [DataContract]
    public partial class QueueInfo :  IEquatable<QueueInfo>, IValidatableObject
    {
        /// <summary>
        /// Specifies how calls are transferred to group members
        /// </summary>
        /// <value>Specifies how calls are transferred to group members</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferModeEnum
        {
            /// <summary>
            /// Enum Rotating for value: Rotating
            /// </summary>
            [EnumMember(Value = "Rotating")]
            Rotating = 1,

            /// <summary>
            /// Enum Simultaneous for value: Simultaneous
            /// </summary>
            [EnumMember(Value = "Simultaneous")]
            Simultaneous = 2,

            /// <summary>
            /// Enum FixedOrder for value: FixedOrder
            /// </summary>
            [EnumMember(Value = "FixedOrder")]
            FixedOrder = 3

        }

        /// <summary>
        /// Specifies how calls are transferred to group members
        /// </summary>
        /// <value>Specifies how calls are transferred to group members</value>
        [DataMember(Name="transferMode", EmitDefaultValue=false)]
        public TransferModeEnum? TransferMode { get; set; }
        /// <summary>
        /// Specifies the type of action to be taken if: members are available but no one answers, or all members are busy/unavailable. This option is available for Business hours only. For simultaneous transfer mode only &#39;WaitPrimaryMembers&#39; and &#39;WaitPrimaryAndOverflowMembers&#39; are supported
        /// </summary>
        /// <value>Specifies the type of action to be taken if: members are available but no one answers, or all members are busy/unavailable. This option is available for Business hours only. For simultaneous transfer mode only &#39;WaitPrimaryMembers&#39; and &#39;WaitPrimaryAndOverflowMembers&#39; are supported</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NoAnswerActionEnum
        {
            /// <summary>
            /// Enum WaitPrimaryMembers for value: WaitPrimaryMembers
            /// </summary>
            [EnumMember(Value = "WaitPrimaryMembers")]
            WaitPrimaryMembers = 1,

            /// <summary>
            /// Enum WaitPrimaryAndOverflowMembers for value: WaitPrimaryAndOverflowMembers
            /// </summary>
            [EnumMember(Value = "WaitPrimaryAndOverflowMembers")]
            WaitPrimaryAndOverflowMembers = 2,

            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 3,

            /// <summary>
            /// Enum TransferToExtension for value: TransferToExtension
            /// </summary>
            [EnumMember(Value = "TransferToExtension")]
            TransferToExtension = 4,

            /// <summary>
            /// Enum UnconditionalForwarding for value: UnconditionalForwarding
            /// </summary>
            [EnumMember(Value = "UnconditionalForwarding")]
            UnconditionalForwarding = 5

        }

        /// <summary>
        /// Specifies the type of action to be taken if: members are available but no one answers, or all members are busy/unavailable. This option is available for Business hours only. For simultaneous transfer mode only &#39;WaitPrimaryMembers&#39; and &#39;WaitPrimaryAndOverflowMembers&#39; are supported
        /// </summary>
        /// <value>Specifies the type of action to be taken if: members are available but no one answers, or all members are busy/unavailable. This option is available for Business hours only. For simultaneous transfer mode only &#39;WaitPrimaryMembers&#39; and &#39;WaitPrimaryAndOverflowMembers&#39; are supported</value>
        [DataMember(Name="noAnswerAction", EmitDefaultValue=false)]
        public NoAnswerActionEnum? NoAnswerAction { get; set; }
        /// <summary>
        /// Connecting audio interruption mode
        /// </summary>
        /// <value>Connecting audio interruption mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HoldAudioInterruptionModeEnum
        {
            /// <summary>
            /// Enum Never for value: Never
            /// </summary>
            [EnumMember(Value = "Never")]
            Never = 1,

            /// <summary>
            /// Enum WhenMusicEnds for value: WhenMusicEnds
            /// </summary>
            [EnumMember(Value = "WhenMusicEnds")]
            WhenMusicEnds = 2,

            /// <summary>
            /// Enum Periodically for value: Periodically
            /// </summary>
            [EnumMember(Value = "Periodically")]
            Periodically = 3

        }

        /// <summary>
        /// Connecting audio interruption mode
        /// </summary>
        /// <value>Connecting audio interruption mode</value>
        [DataMember(Name="holdAudioInterruptionMode", EmitDefaultValue=false)]
        public HoldAudioInterruptionModeEnum? HoldAudioInterruptionMode { get; set; }
        /// <summary>
        /// Specifies the type of action to be taken after the hold time (waiting for an available call queue member) expires. If &#39;TransferToExtension&#39; option is selected, the extension specified in &#x60;transfer&#x60; field is used. The default value is &#x60;Voicemail&#x60;
        /// </summary>
        /// <value>Specifies the type of action to be taken after the hold time (waiting for an available call queue member) expires. If &#39;TransferToExtension&#39; option is selected, the extension specified in &#x60;transfer&#x60; field is used. The default value is &#x60;Voicemail&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HoldTimeExpirationActionEnum
        {
            /// <summary>
            /// Enum TransferToExtension for value: TransferToExtension
            /// </summary>
            [EnumMember(Value = "TransferToExtension")]
            TransferToExtension = 1,

            /// <summary>
            /// Enum UnconditionalForwarding for value: UnconditionalForwarding
            /// </summary>
            [EnumMember(Value = "UnconditionalForwarding")]
            UnconditionalForwarding = 2,

            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 3

        }

        /// <summary>
        /// Specifies the type of action to be taken after the hold time (waiting for an available call queue member) expires. If &#39;TransferToExtension&#39; option is selected, the extension specified in &#x60;transfer&#x60; field is used. The default value is &#x60;Voicemail&#x60;
        /// </summary>
        /// <value>Specifies the type of action to be taken after the hold time (waiting for an available call queue member) expires. If &#39;TransferToExtension&#39; option is selected, the extension specified in &#x60;transfer&#x60; field is used. The default value is &#x60;Voicemail&#x60;</value>
        [DataMember(Name="holdTimeExpirationAction", EmitDefaultValue=false)]
        public HoldTimeExpirationActionEnum? HoldTimeExpirationAction { get; set; }
        /// <summary>
        /// Specifies the type of action to be taken if count of callers on hold exceeds the supported maximum
        /// </summary>
        /// <value>Specifies the type of action to be taken if count of callers on hold exceeds the supported maximum</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MaxCallersActionEnum
        {
            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 1,

            /// <summary>
            /// Enum Announcement for value: Announcement
            /// </summary>
            [EnumMember(Value = "Announcement")]
            Announcement = 2,

            /// <summary>
            /// Enum TransferToExtension for value: TransferToExtension
            /// </summary>
            [EnumMember(Value = "TransferToExtension")]
            TransferToExtension = 3,

            /// <summary>
            /// Enum UnconditionalForwarding for value: UnconditionalForwarding
            /// </summary>
            [EnumMember(Value = "UnconditionalForwarding")]
            UnconditionalForwarding = 4

        }

        /// <summary>
        /// Specifies the type of action to be taken if count of callers on hold exceeds the supported maximum
        /// </summary>
        /// <value>Specifies the type of action to be taken if count of callers on hold exceeds the supported maximum</value>
        [DataMember(Name="maxCallersAction", EmitDefaultValue=false)]
        public MaxCallersActionEnum? MaxCallersAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueInfo" /> class.
        /// </summary>
        /// <param name="transferMode">Specifies how calls are transferred to group members.</param>
        /// <param name="transfer">Call transfer information.</param>
        /// <param name="noAnswerAction">Specifies the type of action to be taken if: members are available but no one answers, or all members are busy/unavailable. This option is available for Business hours only. For simultaneous transfer mode only &#39;WaitPrimaryMembers&#39; and &#39;WaitPrimaryAndOverflowMembers&#39; are supported.</param>
        /// <param name="fixedOrderAgents">Information on a call forwarding rule.</param>
        /// <param name="holdAudioInterruptionMode">Connecting audio interruption mode.</param>
        /// <param name="holdAudioInterruptionPeriod">Connecting audio interruption message period in seconds.</param>
        /// <param name="holdTimeExpirationAction">Specifies the type of action to be taken after the hold time (waiting for an available call queue member) expires. If &#39;TransferToExtension&#39; option is selected, the extension specified in &#x60;transfer&#x60; field is used. The default value is &#x60;Voicemail&#x60; (default to HoldTimeExpirationActionEnum.Voicemail).</param>
        /// <param name="agentTimeout">Maximum time in seconds to wait for a call queue member before trying the next member.</param>
        /// <param name="wrapUpTime">Minimum post-call wrap up time in seconds before agent status is automatically set; the value range is from 180 to 300.</param>
        /// <param name="holdTime">Maximum hold time in seconds to wait for an available call queue member.</param>
        /// <param name="maxCallers">Maximum count of callers on hold; the limitation is 25 callers.</param>
        /// <param name="maxCallersAction">Specifies the type of action to be taken if count of callers on hold exceeds the supported maximum.</param>
        /// <param name="unconditionalForwarding">unconditionalForwarding.</param>
        public QueueInfo(TransferModeEnum? transferMode = default(TransferModeEnum?), List<TransferInfo> transfer = default(List<TransferInfo>), NoAnswerActionEnum? noAnswerAction = default(NoAnswerActionEnum?), List<FixedOrderAgents> fixedOrderAgents = default(List<FixedOrderAgents>), HoldAudioInterruptionModeEnum? holdAudioInterruptionMode = default(HoldAudioInterruptionModeEnum?), int holdAudioInterruptionPeriod = default(int), HoldTimeExpirationActionEnum? holdTimeExpirationAction = HoldTimeExpirationActionEnum.Voicemail, int agentTimeout = default(int), int wrapUpTime = default(int), int holdTime = default(int), int maxCallers = default(int), MaxCallersActionEnum? maxCallersAction = default(MaxCallersActionEnum?), List<UnconditionalForwardingInfo> unconditionalForwarding = default(List<UnconditionalForwardingInfo>))
        {
            this.TransferMode = transferMode;
            this.Transfer = transfer;
            this.NoAnswerAction = noAnswerAction;
            this.FixedOrderAgents = fixedOrderAgents;
            this.HoldAudioInterruptionMode = holdAudioInterruptionMode;
            this.HoldAudioInterruptionPeriod = holdAudioInterruptionPeriod;
            // use default value if no "holdTimeExpirationAction" provided
            if (holdTimeExpirationAction == null)
            {
                this.HoldTimeExpirationAction = HoldTimeExpirationActionEnum.Voicemail;
            }
            else
            {
                this.HoldTimeExpirationAction = holdTimeExpirationAction;
            }
            this.AgentTimeout = agentTimeout;
            this.WrapUpTime = wrapUpTime;
            this.HoldTime = holdTime;
            this.MaxCallers = maxCallers;
            this.MaxCallersAction = maxCallersAction;
            this.UnconditionalForwarding = unconditionalForwarding;
        }


        /// <summary>
        /// Call transfer information
        /// </summary>
        /// <value>Call transfer information</value>
        [DataMember(Name="transfer", EmitDefaultValue=false)]
        public List<TransferInfo> Transfer { get; set; }


        /// <summary>
        /// Information on a call forwarding rule
        /// </summary>
        /// <value>Information on a call forwarding rule</value>
        [DataMember(Name="fixedOrderAgents", EmitDefaultValue=false)]
        public List<FixedOrderAgents> FixedOrderAgents { get; set; }


        /// <summary>
        /// Connecting audio interruption message period in seconds
        /// </summary>
        /// <value>Connecting audio interruption message period in seconds</value>
        [DataMember(Name="holdAudioInterruptionPeriod", EmitDefaultValue=false)]
        public int HoldAudioInterruptionPeriod { get; set; }


        /// <summary>
        /// Maximum time in seconds to wait for a call queue member before trying the next member
        /// </summary>
        /// <value>Maximum time in seconds to wait for a call queue member before trying the next member</value>
        [DataMember(Name="agentTimeout", EmitDefaultValue=false)]
        public int AgentTimeout { get; set; }

        /// <summary>
        /// Minimum post-call wrap up time in seconds before agent status is automatically set; the value range is from 180 to 300
        /// </summary>
        /// <value>Minimum post-call wrap up time in seconds before agent status is automatically set; the value range is from 180 to 300</value>
        [DataMember(Name="wrapUpTime", EmitDefaultValue=false)]
        public int WrapUpTime { get; set; }

        /// <summary>
        /// Maximum hold time in seconds to wait for an available call queue member
        /// </summary>
        /// <value>Maximum hold time in seconds to wait for an available call queue member</value>
        [DataMember(Name="holdTime", EmitDefaultValue=false)]
        public int HoldTime { get; set; }

        /// <summary>
        /// Maximum count of callers on hold; the limitation is 25 callers
        /// </summary>
        /// <value>Maximum count of callers on hold; the limitation is 25 callers</value>
        [DataMember(Name="maxCallers", EmitDefaultValue=false)]
        public int MaxCallers { get; set; }


        /// <summary>
        /// Gets or Sets UnconditionalForwarding
        /// </summary>
        [DataMember(Name="unconditionalForwarding", EmitDefaultValue=false)]
        public List<UnconditionalForwardingInfo> UnconditionalForwarding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueInfo {\n");
            sb.Append("  TransferMode: ").Append(TransferMode).Append("\n");
            sb.Append("  Transfer: ").Append(Transfer).Append("\n");
            sb.Append("  NoAnswerAction: ").Append(NoAnswerAction).Append("\n");
            sb.Append("  FixedOrderAgents: ").Append(FixedOrderAgents).Append("\n");
            sb.Append("  HoldAudioInterruptionMode: ").Append(HoldAudioInterruptionMode).Append("\n");
            sb.Append("  HoldAudioInterruptionPeriod: ").Append(HoldAudioInterruptionPeriod).Append("\n");
            sb.Append("  HoldTimeExpirationAction: ").Append(HoldTimeExpirationAction).Append("\n");
            sb.Append("  AgentTimeout: ").Append(AgentTimeout).Append("\n");
            sb.Append("  WrapUpTime: ").Append(WrapUpTime).Append("\n");
            sb.Append("  HoldTime: ").Append(HoldTime).Append("\n");
            sb.Append("  MaxCallers: ").Append(MaxCallers).Append("\n");
            sb.Append("  MaxCallersAction: ").Append(MaxCallersAction).Append("\n");
            sb.Append("  UnconditionalForwarding: ").Append(UnconditionalForwarding).Append("\n");
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
            return this.Equals(input as QueueInfo);
        }

        /// <summary>
        /// Returns true if QueueInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransferMode == input.TransferMode ||
                    (this.TransferMode != null &&
                    this.TransferMode.Equals(input.TransferMode))
                ) && 
                (
                    this.Transfer == input.Transfer ||
                    this.Transfer != null &&
                    input.Transfer != null &&
                    this.Transfer.SequenceEqual(input.Transfer)
                ) && 
                (
                    this.NoAnswerAction == input.NoAnswerAction ||
                    (this.NoAnswerAction != null &&
                    this.NoAnswerAction.Equals(input.NoAnswerAction))
                ) && 
                (
                    this.FixedOrderAgents == input.FixedOrderAgents ||
                    this.FixedOrderAgents != null &&
                    input.FixedOrderAgents != null &&
                    this.FixedOrderAgents.SequenceEqual(input.FixedOrderAgents)
                ) && 
                (
                    this.HoldAudioInterruptionMode == input.HoldAudioInterruptionMode ||
                    (this.HoldAudioInterruptionMode != null &&
                    this.HoldAudioInterruptionMode.Equals(input.HoldAudioInterruptionMode))
                ) && 
                (
                    this.HoldAudioInterruptionPeriod == input.HoldAudioInterruptionPeriod ||
                    (this.HoldAudioInterruptionPeriod != null &&
                    this.HoldAudioInterruptionPeriod.Equals(input.HoldAudioInterruptionPeriod))
                ) && 
                (
                    this.HoldTimeExpirationAction == input.HoldTimeExpirationAction ||
                    (this.HoldTimeExpirationAction != null &&
                    this.HoldTimeExpirationAction.Equals(input.HoldTimeExpirationAction))
                ) && 
                (
                    this.AgentTimeout == input.AgentTimeout ||
                    (this.AgentTimeout != null &&
                    this.AgentTimeout.Equals(input.AgentTimeout))
                ) && 
                (
                    this.WrapUpTime == input.WrapUpTime ||
                    (this.WrapUpTime != null &&
                    this.WrapUpTime.Equals(input.WrapUpTime))
                ) && 
                (
                    this.HoldTime == input.HoldTime ||
                    (this.HoldTime != null &&
                    this.HoldTime.Equals(input.HoldTime))
                ) && 
                (
                    this.MaxCallers == input.MaxCallers ||
                    (this.MaxCallers != null &&
                    this.MaxCallers.Equals(input.MaxCallers))
                ) && 
                (
                    this.MaxCallersAction == input.MaxCallersAction ||
                    (this.MaxCallersAction != null &&
                    this.MaxCallersAction.Equals(input.MaxCallersAction))
                ) && 
                (
                    this.UnconditionalForwarding == input.UnconditionalForwarding ||
                    this.UnconditionalForwarding != null &&
                    input.UnconditionalForwarding != null &&
                    this.UnconditionalForwarding.SequenceEqual(input.UnconditionalForwarding)
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
                if (this.TransferMode != null)
                    hashCode = hashCode * 59 + this.TransferMode.GetHashCode();
                if (this.Transfer != null)
                    hashCode = hashCode * 59 + this.Transfer.GetHashCode();
                if (this.NoAnswerAction != null)
                    hashCode = hashCode * 59 + this.NoAnswerAction.GetHashCode();
                if (this.FixedOrderAgents != null)
                    hashCode = hashCode * 59 + this.FixedOrderAgents.GetHashCode();
                if (this.HoldAudioInterruptionMode != null)
                    hashCode = hashCode * 59 + this.HoldAudioInterruptionMode.GetHashCode();
                if (this.HoldAudioInterruptionPeriod != null)
                    hashCode = hashCode * 59 + this.HoldAudioInterruptionPeriod.GetHashCode();
                if (this.HoldTimeExpirationAction != null)
                    hashCode = hashCode * 59 + this.HoldTimeExpirationAction.GetHashCode();
                if (this.AgentTimeout != null)
                    hashCode = hashCode * 59 + this.AgentTimeout.GetHashCode();
                if (this.WrapUpTime != null)
                    hashCode = hashCode * 59 + this.WrapUpTime.GetHashCode();
                if (this.HoldTime != null)
                    hashCode = hashCode * 59 + this.HoldTime.GetHashCode();
                if (this.MaxCallers != null)
                    hashCode = hashCode * 59 + this.MaxCallers.GetHashCode();
                if (this.MaxCallersAction != null)
                    hashCode = hashCode * 59 + this.MaxCallersAction.GetHashCode();
                if (this.UnconditionalForwarding != null)
                    hashCode = hashCode * 59 + this.UnconditionalForwarding.GetHashCode();
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