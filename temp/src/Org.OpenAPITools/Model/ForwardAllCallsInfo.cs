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
    /// ForwardAllCallsInfo
    /// </summary>
    [DataContract]
    public partial class ForwardAllCallsInfo :  IEquatable<ForwardAllCallsInfo>, IValidatableObject
    {
        /// <summary>
        /// Specifies how incoming calls are forwarded
        /// </summary>
        /// <value>Specifies how incoming calls are forwarded</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CallHandlingActionEnum
        {
            /// <summary>
            /// Enum UnconditionalForwarding for value: UnconditionalForwarding
            /// </summary>
            [EnumMember(Value = "UnconditionalForwarding")]
            UnconditionalForwarding = 1,

            /// <summary>
            /// Enum TransferToExtension for value: TransferToExtension
            /// </summary>
            [EnumMember(Value = "TransferToExtension")]
            TransferToExtension = 2,

            /// <summary>
            /// Enum TakeMessagesOnly for value: TakeMessagesOnly
            /// </summary>
            [EnumMember(Value = "TakeMessagesOnly")]
            TakeMessagesOnly = 3,

            /// <summary>
            /// Enum PlayAnnouncementOnly for value: PlayAnnouncementOnly
            /// </summary>
            [EnumMember(Value = "PlayAnnouncementOnly")]
            PlayAnnouncementOnly = 4

        }

        /// <summary>
        /// Specifies how incoming calls are forwarded
        /// </summary>
        /// <value>Specifies how incoming calls are forwarded</value>
        [DataMember(Name="callHandlingAction", EmitDefaultValue=false)]
        public CallHandlingActionEnum? CallHandlingAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardAllCallsInfo" /> class.
        /// </summary>
        /// <param name="enabled">Indicates whether *Forward All Calls* feature is enabled or disabled for an extension.</param>
        /// <param name="ranges">Specific data ranges. If specified, weeklyRanges cannot be specified.</param>
        /// <param name="callHandlingAction">Specifies how incoming calls are forwarded.</param>
        /// <param name="extension">extension.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="reason">reason.</param>
        public ForwardAllCallsInfo(bool enabled = default(bool), List<RangesInfo> ranges = default(List<RangesInfo>), CallHandlingActionEnum? callHandlingAction = default(CallHandlingActionEnum?), ExtensionShortInfoResource extension = default(ExtensionShortInfoResource), UnconditionalForwardingInfo phoneNumber = default(UnconditionalForwardingInfo), ForwardAllCallsReason reason = default(ForwardAllCallsReason))
        {
            this.Enabled = enabled;
            this.Ranges = ranges;
            this.CallHandlingAction = callHandlingAction;
            this.Extension = extension;
            this.PhoneNumber = phoneNumber;
            this.Reason = reason;
        }

        /// <summary>
        /// Indicates whether *Forward All Calls* feature is enabled or disabled for an extension
        /// </summary>
        /// <value>Indicates whether *Forward All Calls* feature is enabled or disabled for an extension</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specific data ranges. If specified, weeklyRanges cannot be specified
        /// </summary>
        /// <value>Specific data ranges. If specified, weeklyRanges cannot be specified</value>
        [DataMember(Name="ranges", EmitDefaultValue=false)]
        public List<RangesInfo> Ranges { get; set; }


        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public ExtensionShortInfoResource Extension { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public UnconditionalForwardingInfo PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ForwardAllCallsReason Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardAllCallsInfo {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  CallHandlingAction: ").Append(CallHandlingAction).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as ForwardAllCallsInfo);
        }

        /// <summary>
        /// Returns true if ForwardAllCallsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ForwardAllCallsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardAllCallsInfo input)
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
                    this.Ranges == input.Ranges ||
                    this.Ranges != null &&
                    input.Ranges != null &&
                    this.Ranges.SequenceEqual(input.Ranges)
                ) && 
                (
                    this.CallHandlingAction == input.CallHandlingAction ||
                    (this.CallHandlingAction != null &&
                    this.CallHandlingAction.Equals(input.CallHandlingAction))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.Ranges != null)
                    hashCode = hashCode * 59 + this.Ranges.GetHashCode();
                if (this.CallHandlingAction != null)
                    hashCode = hashCode * 59 + this.CallHandlingAction.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
