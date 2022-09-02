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
    /// MessageAttachmentInfo
    /// </summary>
    [DataContract]
    public partial class MessageAttachmentInfo :  IEquatable<MessageAttachmentInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of message attachment
        /// </summary>
        /// <value>Type of message attachment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AudioRecording for value: AudioRecording
            /// </summary>
            [EnumMember(Value = "AudioRecording")]
            AudioRecording = 1,

            /// <summary>
            /// Enum AudioTranscription for value: AudioTranscription
            /// </summary>
            [EnumMember(Value = "AudioTranscription")]
            AudioTranscription = 2,

            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 3,

            /// <summary>
            /// Enum SourceDocument for value: SourceDocument
            /// </summary>
            [EnumMember(Value = "SourceDocument")]
            SourceDocument = 4,

            /// <summary>
            /// Enum RenderedDocument for value: RenderedDocument
            /// </summary>
            [EnumMember(Value = "RenderedDocument")]
            RenderedDocument = 5,

            /// <summary>
            /// Enum MmsAttachment for value: MmsAttachment
            /// </summary>
            [EnumMember(Value = "MmsAttachment")]
            MmsAttachment = 6

        }

        /// <summary>
        /// Type of message attachment
        /// </summary>
        /// <value>Type of message attachment</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAttachmentInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a message attachment.</param>
        /// <param name="uri">Canonical URI of a message attachment.</param>
        /// <param name="type">Type of message attachment.</param>
        /// <param name="contentType">MIME type for a given attachment, for instance &#39;audio/wav&#39;.</param>
        /// <param name="vmDuration">Supported for &#x60;Voicemail&#x60; only. Duration of a voicemail in seconds.</param>
        /// <param name="fileName">Name of a file attached.</param>
        /// <param name="size">Size of attachment in bytes.</param>
        /// <param name="height">Attachment height in pixels if available.</param>
        /// <param name="width">Attachment width in pixels if available.</param>
        public MessageAttachmentInfo(long id = default(long), string uri = default(string), TypeEnum? type = default(TypeEnum?), string contentType = default(string), int vmDuration = default(int), string fileName = default(string), int size = default(int), int height = default(int), int width = default(int))
        {
            this.Id = id;
            this.Uri = uri;
            this.Type = type;
            this.ContentType = contentType;
            this.VmDuration = vmDuration;
            this.FileName = fileName;
            this.Size = size;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Internal identifier of a message attachment
        /// </summary>
        /// <value>Internal identifier of a message attachment</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Canonical URI of a message attachment
        /// </summary>
        /// <value>Canonical URI of a message attachment</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }


        /// <summary>
        /// MIME type for a given attachment, for instance &#39;audio/wav&#39;
        /// </summary>
        /// <value>MIME type for a given attachment, for instance &#39;audio/wav&#39;</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Supported for &#x60;Voicemail&#x60; only. Duration of a voicemail in seconds
        /// </summary>
        /// <value>Supported for &#x60;Voicemail&#x60; only. Duration of a voicemail in seconds</value>
        [DataMember(Name="vmDuration", EmitDefaultValue=false)]
        public int VmDuration { get; set; }

        /// <summary>
        /// Name of a file attached
        /// </summary>
        /// <value>Name of a file attached</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Size of attachment in bytes
        /// </summary>
        /// <value>Size of attachment in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int Size { get; set; }

        /// <summary>
        /// Attachment height in pixels if available
        /// </summary>
        /// <value>Attachment height in pixels if available</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int Height { get; set; }

        /// <summary>
        /// Attachment width in pixels if available
        /// </summary>
        /// <value>Attachment width in pixels if available</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageAttachmentInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  VmDuration: ").Append(VmDuration).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as MessageAttachmentInfo);
        }

        /// <summary>
        /// Returns true if MessageAttachmentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageAttachmentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageAttachmentInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                    this.VmDuration == input.VmDuration ||
                    (this.VmDuration != null &&
                    this.VmDuration.Equals(input.VmDuration))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.VmDuration != null)
                    hashCode = hashCode * 59 + this.VmDuration.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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
