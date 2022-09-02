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
    /// CustomUserGreetingInfo
    /// </summary>
    [DataContract]
    public partial class CustomUserGreetingInfo :  IEquatable<CustomUserGreetingInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of a custom user greeting
        /// </summary>
        /// <value>Type of a custom user greeting</value>
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
            /// Enum InterruptPrompt for value: InterruptPrompt
            /// </summary>
            [EnumMember(Value = "InterruptPrompt")]
            InterruptPrompt = 3,

            /// <summary>
            /// Enum ConnectingAudio for value: ConnectingAudio
            /// </summary>
            [EnumMember(Value = "ConnectingAudio")]
            ConnectingAudio = 4,

            /// <summary>
            /// Enum ConnectingMessage for value: ConnectingMessage
            /// </summary>
            [EnumMember(Value = "ConnectingMessage")]
            ConnectingMessage = 5,

            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 6,

            /// <summary>
            /// Enum Unavailable for value: Unavailable
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable = 7,

            /// <summary>
            /// Enum HoldMusic for value: HoldMusic
            /// </summary>
            [EnumMember(Value = "HoldMusic")]
            HoldMusic = 8,

            /// <summary>
            /// Enum PronouncedName for value: PronouncedName
            /// </summary>
            [EnumMember(Value = "PronouncedName")]
            PronouncedName = 9

        }

        /// <summary>
        /// Type of a custom user greeting
        /// </summary>
        /// <value>Type of a custom user greeting</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Content media type
        /// </summary>
        /// <value>Content media type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContentTypeEnum
        {
            /// <summary>
            /// Enum Mpeg for value: audio/mpeg
            /// </summary>
            [EnumMember(Value = "audio/mpeg")]
            Mpeg = 1,

            /// <summary>
            /// Enum Wav for value: audio/wav
            /// </summary>
            [EnumMember(Value = "audio/wav")]
            Wav = 2

        }

        /// <summary>
        /// Content media type
        /// </summary>
        /// <value>Content media type</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomUserGreetingInfo" /> class.
        /// </summary>
        /// <param name="uri">Link to a custom user greeting.</param>
        /// <param name="id">Internal identifier of a custom user greeting.</param>
        /// <param name="type">Type of a custom user greeting.</param>
        /// <param name="contentType">Content media type.</param>
        /// <param name="contentUri">Link to a greeting content (audio file).</param>
        /// <param name="answeringRule">answeringRule.</param>
        public CustomUserGreetingInfo(string uri = default(string), string id = default(string), TypeEnum? type = default(TypeEnum?), ContentTypeEnum? contentType = default(ContentTypeEnum?), string contentUri = default(string), CustomGreetingAnsweringRuleInfo answeringRule = default(CustomGreetingAnsweringRuleInfo))
        {
            this.Uri = uri;
            this.Id = id;
            this.Type = type;
            this.ContentType = contentType;
            this.ContentUri = contentUri;
            this.AnsweringRule = answeringRule;
        }

        /// <summary>
        /// Link to a custom user greeting
        /// </summary>
        /// <value>Link to a custom user greeting</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Internal identifier of a custom user greeting
        /// </summary>
        /// <value>Internal identifier of a custom user greeting</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Link to a greeting content (audio file)
        /// </summary>
        /// <value>Link to a greeting content (audio file)</value>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }

        /// <summary>
        /// Gets or Sets AnsweringRule
        /// </summary>
        [DataMember(Name="answeringRule", EmitDefaultValue=false)]
        public CustomGreetingAnsweringRuleInfo AnsweringRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomUserGreetingInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
            sb.Append("  AnsweringRule: ").Append(AnsweringRule).Append("\n");
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
            return this.Equals(input as CustomUserGreetingInfo);
        }

        /// <summary>
        /// Returns true if CustomUserGreetingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomUserGreetingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomUserGreetingInfo input)
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
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.ContentUri == input.ContentUri ||
                    (this.ContentUri != null &&
                    this.ContentUri.Equals(input.ContentUri))
                ) && 
                (
                    this.AnsweringRule == input.AnsweringRule ||
                    (this.AnsweringRule != null &&
                    this.AnsweringRule.Equals(input.AnsweringRule))
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.ContentUri != null)
                    hashCode = hashCode * 59 + this.ContentUri.GetHashCode();
                if (this.AnsweringRule != null)
                    hashCode = hashCode * 59 + this.AnsweringRule.GetHashCode();
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