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
    /// GlipNoteInfo
    /// </summary>
    [DataContract]
    public partial class GlipNoteInfo :  IEquatable<GlipNoteInfo>, IValidatableObject
    {
        /// <summary>
        /// Note publishing status. Any note is created in &#39;Draft&#39; status. After it is posted it becomes &#39;Active&#39;
        /// </summary>
        /// <value>Note publishing status. Any note is created in &#39;Draft&#39; status. After it is posted it becomes &#39;Active&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,

            /// <summary>
            /// Enum Draft for value: Draft
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft = 2

        }

        /// <summary>
        /// Note publishing status. Any note is created in &#39;Draft&#39; status. After it is posted it becomes &#39;Active&#39;
        /// </summary>
        /// <value>Note publishing status. Any note is created in &#39;Draft&#39; status. After it is posted it becomes &#39;Active&#39;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Note for value: Note
            /// </summary>
            [EnumMember(Value = "Note")]
            Note = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipNoteInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a note.</param>
        /// <param name="title">Title of a note.</param>
        /// <param name="chatIds">Internal identifiers of the chat(s) where the note is posted or shared..</param>
        /// <param name="preview">Preview of a note (first 150 characters of a body).</param>
        /// <param name="creator">creator.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="lockedBy">lockedBy.</param>
        /// <param name="status">Note publishing status. Any note is created in &#39;Draft&#39; status. After it is posted it becomes &#39;Active&#39;.</param>
        /// <param name="creationTime">Creation time.</param>
        /// <param name="lastModifiedTime">Datetime of the note last update.</param>
        /// <param name="type">type.</param>
        public GlipNoteInfo(string id = default(string), string title = default(string), List<string> chatIds = default(List<string>), string preview = default(string), GlipCreatorInfo creator = default(GlipCreatorInfo), LastModifiedByInfo lastModifiedBy = default(LastModifiedByInfo), LockedByInfo lockedBy = default(LockedByInfo), StatusEnum? status = default(StatusEnum?), string creationTime = default(string), string lastModifiedTime = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Title = title;
            this.ChatIds = chatIds;
            this.Preview = preview;
            this.Creator = creator;
            this.LastModifiedBy = lastModifiedBy;
            this.LockedBy = lockedBy;
            this.Status = status;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
            this.Type = type;
        }

        /// <summary>
        /// Internal identifier of a note
        /// </summary>
        /// <value>Internal identifier of a note</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Title of a note
        /// </summary>
        /// <value>Title of a note</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Internal identifiers of the chat(s) where the note is posted or shared.
        /// </summary>
        /// <value>Internal identifiers of the chat(s) where the note is posted or shared.</value>
        [DataMember(Name="chatIds", EmitDefaultValue=false)]
        public List<string> ChatIds { get; set; }

        /// <summary>
        /// Preview of a note (first 150 characters of a body)
        /// </summary>
        /// <value>Preview of a note (first 150 characters of a body)</value>
        [DataMember(Name="preview", EmitDefaultValue=false)]
        public string Preview { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public GlipCreatorInfo Creator { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
        public LastModifiedByInfo LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets LockedBy
        /// </summary>
        [DataMember(Name="lockedBy", EmitDefaultValue=false)]
        public LockedByInfo LockedBy { get; set; }


        /// <summary>
        /// Creation time
        /// </summary>
        /// <value>Creation time</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Datetime of the note last update
        /// </summary>
        /// <value>Datetime of the note last update</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public string LastModifiedTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipNoteInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ChatIds: ").Append(ChatIds).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LockedBy: ").Append(LockedBy).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
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
            return this.Equals(input as GlipNoteInfo);
        }

        /// <summary>
        /// Returns true if GlipNoteInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipNoteInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipNoteInfo input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ChatIds == input.ChatIds ||
                    this.ChatIds != null &&
                    input.ChatIds != null &&
                    this.ChatIds.SequenceEqual(input.ChatIds)
                ) && 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.LockedBy == input.LockedBy ||
                    (this.LockedBy != null &&
                    this.LockedBy.Equals(input.LockedBy))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ChatIds != null)
                    hashCode = hashCode * 59 + this.ChatIds.GetHashCode();
                if (this.Preview != null)
                    hashCode = hashCode * 59 + this.Preview.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.LockedBy != null)
                    hashCode = hashCode * 59 + this.LockedBy.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
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
