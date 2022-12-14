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
    /// SIP flags data
    /// </summary>
    [DataContract]
    public partial class SIPFlagsResponse :  IEquatable<SIPFlagsResponse>, IValidatableObject
    {
        /// <summary>
        /// If &#39;True&#39; VoIP calling feature is enabled
        /// </summary>
        /// <value>If &#39;True&#39; VoIP calling feature is enabled</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VoipFeatureEnabledEnum
        {
            /// <summary>
            /// Enum True for value: True
            /// </summary>
            [EnumMember(Value = "True")]
            True = 1,

            /// <summary>
            /// Enum False for value: False
            /// </summary>
            [EnumMember(Value = "False")]
            False = 2

        }

        /// <summary>
        /// If &#39;True&#39; VoIP calling feature is enabled
        /// </summary>
        /// <value>If &#39;True&#39; VoIP calling feature is enabled</value>
        [DataMember(Name="voipFeatureEnabled", EmitDefaultValue=false)]
        public VoipFeatureEnabledEnum? VoipFeatureEnabled { get; set; }
        /// <summary>
        /// If &#39;True&#39; the request is sent from IP address of a country blocked for VoIP calling
        /// </summary>
        /// <value>If &#39;True&#39; the request is sent from IP address of a country blocked for VoIP calling</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VoipCountryBlockedEnum
        {
            /// <summary>
            /// Enum True for value: True
            /// </summary>
            [EnumMember(Value = "True")]
            True = 1,

            /// <summary>
            /// Enum False for value: False
            /// </summary>
            [EnumMember(Value = "False")]
            False = 2

        }

        /// <summary>
        /// If &#39;True&#39; the request is sent from IP address of a country blocked for VoIP calling
        /// </summary>
        /// <value>If &#39;True&#39; the request is sent from IP address of a country blocked for VoIP calling</value>
        [DataMember(Name="voipCountryBlocked", EmitDefaultValue=false)]
        public VoipCountryBlockedEnum? VoipCountryBlocked { get; set; }
        /// <summary>
        /// If &#39;True&#39; outbound calls are enabled
        /// </summary>
        /// <value>If &#39;True&#39; outbound calls are enabled</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutboundCallsEnabledEnum
        {
            /// <summary>
            /// Enum True for value: True
            /// </summary>
            [EnumMember(Value = "True")]
            True = 1,

            /// <summary>
            /// Enum False for value: False
            /// </summary>
            [EnumMember(Value = "False")]
            False = 2

        }

        /// <summary>
        /// If &#39;True&#39; outbound calls are enabled
        /// </summary>
        /// <value>If &#39;True&#39; outbound calls are enabled</value>
        [DataMember(Name="outboundCallsEnabled", EmitDefaultValue=false)]
        public OutboundCallsEnabledEnum? OutboundCallsEnabled { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPFlagsResponse" /> class.
        /// </summary>
        /// <param name="voipFeatureEnabled">If &#39;True&#39; VoIP calling feature is enabled.</param>
        /// <param name="voipCountryBlocked">If &#39;True&#39; the request is sent from IP address of a country blocked for VoIP calling.</param>
        /// <param name="outboundCallsEnabled">If &#39;True&#39; outbound calls are enabled.</param>
        /// <param name="dscpEnabled">dscpEnabled.</param>
        /// <param name="dscpSignaling">dscpSignaling.</param>
        /// <param name="dscpVoice">dscpVoice.</param>
        /// <param name="dscpVideo">dscpVideo.</param>
        public SIPFlagsResponse(VoipFeatureEnabledEnum? voipFeatureEnabled = default(VoipFeatureEnabledEnum?), VoipCountryBlockedEnum? voipCountryBlocked = default(VoipCountryBlockedEnum?), OutboundCallsEnabledEnum? outboundCallsEnabled = default(OutboundCallsEnabledEnum?), bool dscpEnabled = default(bool), int dscpSignaling = default(int), int dscpVoice = default(int), int dscpVideo = default(int))
        {
            this.VoipFeatureEnabled = voipFeatureEnabled;
            this.VoipCountryBlocked = voipCountryBlocked;
            this.OutboundCallsEnabled = outboundCallsEnabled;
            this.DscpEnabled = dscpEnabled;
            this.DscpSignaling = dscpSignaling;
            this.DscpVoice = dscpVoice;
            this.DscpVideo = dscpVideo;
        }




        /// <summary>
        /// Gets or Sets DscpEnabled
        /// </summary>
        [DataMember(Name="dscpEnabled", EmitDefaultValue=false)]
        public bool DscpEnabled { get; set; }

        /// <summary>
        /// Gets or Sets DscpSignaling
        /// </summary>
        [DataMember(Name="dscpSignaling", EmitDefaultValue=false)]
        public int DscpSignaling { get; set; }

        /// <summary>
        /// Gets or Sets DscpVoice
        /// </summary>
        [DataMember(Name="dscpVoice", EmitDefaultValue=false)]
        public int DscpVoice { get; set; }

        /// <summary>
        /// Gets or Sets DscpVideo
        /// </summary>
        [DataMember(Name="dscpVideo", EmitDefaultValue=false)]
        public int DscpVideo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SIPFlagsResponse {\n");
            sb.Append("  VoipFeatureEnabled: ").Append(VoipFeatureEnabled).Append("\n");
            sb.Append("  VoipCountryBlocked: ").Append(VoipCountryBlocked).Append("\n");
            sb.Append("  OutboundCallsEnabled: ").Append(OutboundCallsEnabled).Append("\n");
            sb.Append("  DscpEnabled: ").Append(DscpEnabled).Append("\n");
            sb.Append("  DscpSignaling: ").Append(DscpSignaling).Append("\n");
            sb.Append("  DscpVoice: ").Append(DscpVoice).Append("\n");
            sb.Append("  DscpVideo: ").Append(DscpVideo).Append("\n");
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
            return this.Equals(input as SIPFlagsResponse);
        }

        /// <summary>
        /// Returns true if SIPFlagsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SIPFlagsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SIPFlagsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VoipFeatureEnabled == input.VoipFeatureEnabled ||
                    (this.VoipFeatureEnabled != null &&
                    this.VoipFeatureEnabled.Equals(input.VoipFeatureEnabled))
                ) && 
                (
                    this.VoipCountryBlocked == input.VoipCountryBlocked ||
                    (this.VoipCountryBlocked != null &&
                    this.VoipCountryBlocked.Equals(input.VoipCountryBlocked))
                ) && 
                (
                    this.OutboundCallsEnabled == input.OutboundCallsEnabled ||
                    (this.OutboundCallsEnabled != null &&
                    this.OutboundCallsEnabled.Equals(input.OutboundCallsEnabled))
                ) && 
                (
                    this.DscpEnabled == input.DscpEnabled ||
                    (this.DscpEnabled != null &&
                    this.DscpEnabled.Equals(input.DscpEnabled))
                ) && 
                (
                    this.DscpSignaling == input.DscpSignaling ||
                    (this.DscpSignaling != null &&
                    this.DscpSignaling.Equals(input.DscpSignaling))
                ) && 
                (
                    this.DscpVoice == input.DscpVoice ||
                    (this.DscpVoice != null &&
                    this.DscpVoice.Equals(input.DscpVoice))
                ) && 
                (
                    this.DscpVideo == input.DscpVideo ||
                    (this.DscpVideo != null &&
                    this.DscpVideo.Equals(input.DscpVideo))
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
                if (this.VoipFeatureEnabled != null)
                    hashCode = hashCode * 59 + this.VoipFeatureEnabled.GetHashCode();
                if (this.VoipCountryBlocked != null)
                    hashCode = hashCode * 59 + this.VoipCountryBlocked.GetHashCode();
                if (this.OutboundCallsEnabled != null)
                    hashCode = hashCode * 59 + this.OutboundCallsEnabled.GetHashCode();
                if (this.DscpEnabled != null)
                    hashCode = hashCode * 59 + this.DscpEnabled.GetHashCode();
                if (this.DscpSignaling != null)
                    hashCode = hashCode * 59 + this.DscpSignaling.GetHashCode();
                if (this.DscpVoice != null)
                    hashCode = hashCode * 59 + this.DscpVoice.GetHashCode();
                if (this.DscpVideo != null)
                    hashCode = hashCode * 59 + this.DscpVideo.GetHashCode();
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
