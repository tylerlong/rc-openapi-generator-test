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
    /// GreetingInfo
    /// </summary>
    [DataContract]
    public partial class GreetingInfo :  IEquatable<GreetingInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played.
        /// </summary>
        /// <value>Type of a greeting, specifying the case when the greeting is played.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Introductory for value: Introductory
            /// </summary>
            [EnumMember(Value = "Introductory")]
            Introductory = 1,

            /// <summary>
            /// Enum Announcement for value: Announcement
            /// </summary>
            [EnumMember(Value = "Announcement")]
            Announcement = 2,

            /// <summary>
            /// Enum ConnectingMessage for value: ConnectingMessage
            /// </summary>
            [EnumMember(Value = "ConnectingMessage")]
            ConnectingMessage = 3,

            /// <summary>
            /// Enum ConnectingAudio for value: ConnectingAudio
            /// </summary>
            [EnumMember(Value = "ConnectingAudio")]
            ConnectingAudio = 4,

            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 5,

            /// <summary>
            /// Enum Unavailable for value: Unavailable
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable = 6,

            /// <summary>
            /// Enum InterruptPrompt for value: InterruptPrompt
            /// </summary>
            [EnumMember(Value = "InterruptPrompt")]
            InterruptPrompt = 7,

            /// <summary>
            /// Enum HoldMusic for value: HoldMusic
            /// </summary>
            [EnumMember(Value = "HoldMusic")]
            HoldMusic = 8,

            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 9,

            /// <summary>
            /// Enum Company for value: Company
            /// </summary>
            [EnumMember(Value = "Company")]
            Company = 10,

            /// <summary>
            /// Enum BlockedCallersSpecific for value: BlockedCallersSpecific
            /// </summary>
            [EnumMember(Value = "BlockedCallersSpecific")]
            BlockedCallersSpecific = 11,

            /// <summary>
            /// Enum BlockedCallersAll for value: BlockedCallersAll
            /// </summary>
            [EnumMember(Value = "BlockedCallersAll")]
            BlockedCallersAll = 12,

            /// <summary>
            /// Enum BlockedNoCallerId for value: BlockedNoCallerId
            /// </summary>
            [EnumMember(Value = "BlockedNoCallerId")]
            BlockedNoCallerId = 13,

            /// <summary>
            /// Enum BlockedPayPhones for value: BlockedPayPhones
            /// </summary>
            [EnumMember(Value = "BlockedPayPhones")]
            BlockedPayPhones = 14,

            /// <summary>
            /// Enum StartRecording for value: StartRecording
            /// </summary>
            [EnumMember(Value = "StartRecording")]
            StartRecording = 15,

            /// <summary>
            /// Enum StopRecording for value: StopRecording
            /// </summary>
            [EnumMember(Value = "StopRecording")]
            StopRecording = 16,

            /// <summary>
            /// Enum AutomaticRecording for value: AutomaticRecording
            /// </summary>
            [EnumMember(Value = "AutomaticRecording")]
            AutomaticRecording = 17

        }

        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played.
        /// </summary>
        /// <value>Type of a greeting, specifying the case when the greeting is played.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GreetingInfo" /> class.
        /// </summary>
        /// <param name="type">Type of a greeting, specifying the case when the greeting is played..</param>
        /// <param name="preset">preset.</param>
        /// <param name="custom">custom.</param>
        public GreetingInfo(TypeEnum? type = default(TypeEnum?), PresetInfo preset = default(PresetInfo), CustomGreetingInfoRequest custom = default(CustomGreetingInfoRequest))
        {
            this.Type = type;
            this.Preset = preset;
            this.Custom = custom;
        }


        /// <summary>
        /// Gets or Sets Preset
        /// </summary>
        [DataMember(Name="preset", EmitDefaultValue=false)]
        public PresetInfo Preset { get; set; }

        /// <summary>
        /// Gets or Sets Custom
        /// </summary>
        [DataMember(Name="custom", EmitDefaultValue=false)]
        public CustomGreetingInfoRequest Custom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GreetingInfo {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Preset: ").Append(Preset).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
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
            return this.Equals(input as GreetingInfo);
        }

        /// <summary>
        /// Returns true if GreetingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GreetingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GreetingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Preset == input.Preset ||
                    (this.Preset != null &&
                    this.Preset.Equals(input.Preset))
                ) && 
                (
                    this.Custom == input.Custom ||
                    (this.Custom != null &&
                    this.Custom.Equals(input.Custom))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Preset != null)
                    hashCode = hashCode * 59 + this.Preset.GetHashCode();
                if (this.Custom != null)
                    hashCode = hashCode * 59 + this.Custom.GetHashCode();
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
