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
    /// Forwarding parameters. Returned if &#39;ForwardCalls&#39; is specified in &#39;callHandlingAction&#39;. These settings determine the forwarding numbers to which the call will be forwarded
    /// </summary>
    [DataContract]
    public partial class ForwardingInfo :  IEquatable<ForwardingInfo>, IValidatableObject
    {
        /// <summary>
        /// Specifies the order in which the forwarding numbers ring. &#39;Sequentially&#39; means that forwarding numbers are ringing one at a time, in order of priority. &#39;Simultaneously&#39; means that forwarding numbers are ring all at the same time
        /// </summary>
        /// <value>Specifies the order in which the forwarding numbers ring. &#39;Sequentially&#39; means that forwarding numbers are ringing one at a time, in order of priority. &#39;Simultaneously&#39; means that forwarding numbers are ring all at the same time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RingingModeEnum
        {
            /// <summary>
            /// Enum Sequentially for value: Sequentially
            /// </summary>
            [EnumMember(Value = "Sequentially")]
            Sequentially = 1,

            /// <summary>
            /// Enum Simultaneously for value: Simultaneously
            /// </summary>
            [EnumMember(Value = "Simultaneously")]
            Simultaneously = 2

        }

        /// <summary>
        /// Specifies the order in which the forwarding numbers ring. &#39;Sequentially&#39; means that forwarding numbers are ringing one at a time, in order of priority. &#39;Simultaneously&#39; means that forwarding numbers are ring all at the same time
        /// </summary>
        /// <value>Specifies the order in which the forwarding numbers ring. &#39;Sequentially&#39; means that forwarding numbers are ringing one at a time, in order of priority. &#39;Simultaneously&#39; means that forwarding numbers are ring all at the same time</value>
        [DataMember(Name="ringingMode", EmitDefaultValue=false)]
        public RingingModeEnum? RingingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardingInfo" /> class.
        /// </summary>
        /// <param name="notifyMySoftPhones">Specifies if the user&#39;s softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers.</param>
        /// <param name="notifyAdminSoftPhones">Deprecated parameter. Specifies if the administrator&#39;s softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is &#39;False&#39;.</param>
        /// <param name="softPhonesRingCount">Number of rings before forwarding starts.</param>
        /// <param name="softPhonesAlwaysRing">Specifies that desktop and mobile applications of the user will ring till the end of their forwarding list. If set to &#39;True&#39; then &#x60;softPhonesRingCount&#x60; is ignored (default to true).</param>
        /// <param name="ringingMode">Specifies the order in which the forwarding numbers ring. &#39;Sequentially&#39; means that forwarding numbers are ringing one at a time, in order of priority. &#39;Simultaneously&#39; means that forwarding numbers are ring all at the same time.</param>
        /// <param name="rules">Information on a call forwarding rule.</param>
        /// <param name="softPhonesPositionTop">Specifies if desktop and mobile applications of the user are notified before (true) or after (false) forwarding the incoming call to desk phones and forwarding numbers. Applicable only if &#x60;notifyMySoftPhones&#x60; parameter is set to &#x60;true&#x60;.</param>
        /// <param name="mobileTimeout">Deprecated parameter. Specifies if mobile timeout is activated for the rule.</param>
        public ForwardingInfo(bool notifyMySoftPhones = default(bool), bool notifyAdminSoftPhones = default(bool), int softPhonesRingCount = default(int), bool softPhonesAlwaysRing = true, RingingModeEnum? ringingMode = default(RingingModeEnum?), List<RuleInfo> rules = default(List<RuleInfo>), bool softPhonesPositionTop = default(bool), bool mobileTimeout = default(bool))
        {
            this.NotifyMySoftPhones = notifyMySoftPhones;
            this.NotifyAdminSoftPhones = notifyAdminSoftPhones;
            this.SoftPhonesRingCount = softPhonesRingCount;
            // use default value if no "softPhonesAlwaysRing" provided
            if (softPhonesAlwaysRing == null)
            {
                this.SoftPhonesAlwaysRing = true;
            }
            else
            {
                this.SoftPhonesAlwaysRing = softPhonesAlwaysRing;
            }
            this.RingingMode = ringingMode;
            this.Rules = rules;
            this.SoftPhonesPositionTop = softPhonesPositionTop;
            this.MobileTimeout = mobileTimeout;
        }

        /// <summary>
        /// Specifies if the user&#39;s softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers
        /// </summary>
        /// <value>Specifies if the user&#39;s softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers</value>
        [DataMember(Name="notifyMySoftPhones", EmitDefaultValue=false)]
        public bool NotifyMySoftPhones { get; set; }

        /// <summary>
        /// Deprecated parameter. Specifies if the administrator&#39;s softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is &#39;False&#39;
        /// </summary>
        /// <value>Deprecated parameter. Specifies if the administrator&#39;s softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is &#39;False&#39;</value>
        [DataMember(Name="notifyAdminSoftPhones", EmitDefaultValue=false)]
        [Obsolete]
        public bool NotifyAdminSoftPhones { get; set; }

        /// <summary>
        /// Number of rings before forwarding starts
        /// </summary>
        /// <value>Number of rings before forwarding starts</value>
        [DataMember(Name="softPhonesRingCount", EmitDefaultValue=false)]
        public int SoftPhonesRingCount { get; set; }

        /// <summary>
        /// Specifies that desktop and mobile applications of the user will ring till the end of their forwarding list. If set to &#39;True&#39; then &#x60;softPhonesRingCount&#x60; is ignored
        /// </summary>
        /// <value>Specifies that desktop and mobile applications of the user will ring till the end of their forwarding list. If set to &#39;True&#39; then &#x60;softPhonesRingCount&#x60; is ignored</value>
        [DataMember(Name="softPhonesAlwaysRing", EmitDefaultValue=false)]
        public bool SoftPhonesAlwaysRing { get; set; }


        /// <summary>
        /// Information on a call forwarding rule
        /// </summary>
        /// <value>Information on a call forwarding rule</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<RuleInfo> Rules { get; set; }

        /// <summary>
        /// Specifies if desktop and mobile applications of the user are notified before (true) or after (false) forwarding the incoming call to desk phones and forwarding numbers. Applicable only if &#x60;notifyMySoftPhones&#x60; parameter is set to &#x60;true&#x60;
        /// </summary>
        /// <value>Specifies if desktop and mobile applications of the user are notified before (true) or after (false) forwarding the incoming call to desk phones and forwarding numbers. Applicable only if &#x60;notifyMySoftPhones&#x60; parameter is set to &#x60;true&#x60;</value>
        [DataMember(Name="softPhonesPositionTop", EmitDefaultValue=false)]
        public bool SoftPhonesPositionTop { get; set; }

        /// <summary>
        /// Deprecated parameter. Specifies if mobile timeout is activated for the rule
        /// </summary>
        /// <value>Deprecated parameter. Specifies if mobile timeout is activated for the rule</value>
        [DataMember(Name="mobileTimeout", EmitDefaultValue=false)]
        [Obsolete]
        public bool MobileTimeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardingInfo {\n");
            sb.Append("  NotifyMySoftPhones: ").Append(NotifyMySoftPhones).Append("\n");
            sb.Append("  NotifyAdminSoftPhones: ").Append(NotifyAdminSoftPhones).Append("\n");
            sb.Append("  SoftPhonesRingCount: ").Append(SoftPhonesRingCount).Append("\n");
            sb.Append("  SoftPhonesAlwaysRing: ").Append(SoftPhonesAlwaysRing).Append("\n");
            sb.Append("  RingingMode: ").Append(RingingMode).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  SoftPhonesPositionTop: ").Append(SoftPhonesPositionTop).Append("\n");
            sb.Append("  MobileTimeout: ").Append(MobileTimeout).Append("\n");
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
            return this.Equals(input as ForwardingInfo);
        }

        /// <summary>
        /// Returns true if ForwardingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ForwardingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotifyMySoftPhones == input.NotifyMySoftPhones ||
                    (this.NotifyMySoftPhones != null &&
                    this.NotifyMySoftPhones.Equals(input.NotifyMySoftPhones))
                ) && 
                (
                    this.NotifyAdminSoftPhones == input.NotifyAdminSoftPhones ||
                    (this.NotifyAdminSoftPhones != null &&
                    this.NotifyAdminSoftPhones.Equals(input.NotifyAdminSoftPhones))
                ) && 
                (
                    this.SoftPhonesRingCount == input.SoftPhonesRingCount ||
                    (this.SoftPhonesRingCount != null &&
                    this.SoftPhonesRingCount.Equals(input.SoftPhonesRingCount))
                ) && 
                (
                    this.SoftPhonesAlwaysRing == input.SoftPhonesAlwaysRing ||
                    (this.SoftPhonesAlwaysRing != null &&
                    this.SoftPhonesAlwaysRing.Equals(input.SoftPhonesAlwaysRing))
                ) && 
                (
                    this.RingingMode == input.RingingMode ||
                    (this.RingingMode != null &&
                    this.RingingMode.Equals(input.RingingMode))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.SoftPhonesPositionTop == input.SoftPhonesPositionTop ||
                    (this.SoftPhonesPositionTop != null &&
                    this.SoftPhonesPositionTop.Equals(input.SoftPhonesPositionTop))
                ) && 
                (
                    this.MobileTimeout == input.MobileTimeout ||
                    (this.MobileTimeout != null &&
                    this.MobileTimeout.Equals(input.MobileTimeout))
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
                if (this.NotifyMySoftPhones != null)
                    hashCode = hashCode * 59 + this.NotifyMySoftPhones.GetHashCode();
                if (this.NotifyAdminSoftPhones != null)
                    hashCode = hashCode * 59 + this.NotifyAdminSoftPhones.GetHashCode();
                if (this.SoftPhonesRingCount != null)
                    hashCode = hashCode * 59 + this.SoftPhonesRingCount.GetHashCode();
                if (this.SoftPhonesAlwaysRing != null)
                    hashCode = hashCode * 59 + this.SoftPhonesAlwaysRing.GetHashCode();
                if (this.RingingMode != null)
                    hashCode = hashCode * 59 + this.RingingMode.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.SoftPhonesPositionTop != null)
                    hashCode = hashCode * 59 + this.SoftPhonesPositionTop.GetHashCode();
                if (this.MobileTimeout != null)
                    hashCode = hashCode * 59 + this.MobileTimeout.GetHashCode();
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