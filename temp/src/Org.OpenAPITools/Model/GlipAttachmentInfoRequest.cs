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
    /// GlipAttachmentInfoRequest
    /// </summary>
    [DataContract]
    public partial class GlipAttachmentInfoRequest :  IEquatable<GlipAttachmentInfoRequest>, IValidatableObject
    {
        /// <summary>
        /// Type of an attachment
        /// </summary>
        /// <value>Type of an attachment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum File for value: File
            /// </summary>
            [EnumMember(Value = "File")]
            File = 1,

            /// <summary>
            /// Enum Note for value: Note
            /// </summary>
            [EnumMember(Value = "Note")]
            Note = 2,

            /// <summary>
            /// Enum Event for value: Event
            /// </summary>
            [EnumMember(Value = "Event")]
            Event = 3,

            /// <summary>
            /// Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")]
            Card = 4

        }

        /// <summary>
        /// Type of an attachment
        /// </summary>
        /// <value>Type of an attachment</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipAttachmentInfoRequest" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of an attachment.</param>
        /// <param name="type">Type of an attachment.</param>
        public GlipAttachmentInfoRequest(string id = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Internal identifier of an attachment
        /// </summary>
        /// <value>Internal identifier of an attachment</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipAttachmentInfoRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GlipAttachmentInfoRequest);
        }

        /// <summary>
        /// Returns true if GlipAttachmentInfoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipAttachmentInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipAttachmentInfoRequest input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
