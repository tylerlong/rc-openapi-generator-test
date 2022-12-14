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
    /// GlipPostEvent
    /// </summary>
    [DataContract]
    public partial class GlipPostEvent :  IEquatable<GlipPostEvent>, IValidatableObject
    {
        /// <summary>
        /// Type of a post event
        /// </summary>
        /// <value>Type of a post event</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum PostAdded for value: PostAdded
            /// </summary>
            [EnumMember(Value = "PostAdded")]
            PostAdded = 1,

            /// <summary>
            /// Enum PostChanged for value: PostChanged
            /// </summary>
            [EnumMember(Value = "PostChanged")]
            PostChanged = 2,

            /// <summary>
            /// Enum PostRemoved for value: PostRemoved
            /// </summary>
            [EnumMember(Value = "PostRemoved")]
            PostRemoved = 3

        }

        /// <summary>
        /// Type of a post event
        /// </summary>
        /// <value>Type of a post event</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Type of a post. &#39;TextMessage&#39; - an incoming text message; &#39;PersonJoined&#39; - a message notifying that person has joined a conversation; &#39;PersonsAdded&#39; - a message notifying that a person(s) were added to a conversation
        /// </summary>
        /// <value>Type of a post. &#39;TextMessage&#39; - an incoming text message; &#39;PersonJoined&#39; - a message notifying that person has joined a conversation; &#39;PersonsAdded&#39; - a message notifying that a person(s) were added to a conversation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum TextMessage for value: TextMessage
            /// </summary>
            [EnumMember(Value = "TextMessage")]
            TextMessage = 1,

            /// <summary>
            /// Enum PersonJoined for value: PersonJoined
            /// </summary>
            [EnumMember(Value = "PersonJoined")]
            PersonJoined = 2,

            /// <summary>
            /// Enum PersonsAdded for value: PersonsAdded
            /// </summary>
            [EnumMember(Value = "PersonsAdded")]
            PersonsAdded = 3,

            /// <summary>
            /// Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")]
            Card = 4

        }

        /// <summary>
        /// Type of a post. &#39;TextMessage&#39; - an incoming text message; &#39;PersonJoined&#39; - a message notifying that person has joined a conversation; &#39;PersonsAdded&#39; - a message notifying that a person(s) were added to a conversation
        /// </summary>
        /// <value>Type of a post. &#39;TextMessage&#39; - an incoming text message; &#39;PersonJoined&#39; - a message notifying that person has joined a conversation; &#39;PersonsAdded&#39; - a message notifying that a person(s) were added to a conversation</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipPostEvent" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a post.</param>
        /// <param name="eventType">Type of a post event.</param>
        /// <param name="groupId">Internal identifier of a group a post belongs to.</param>
        /// <param name="type">Type of a post. &#39;TextMessage&#39; - an incoming text message; &#39;PersonJoined&#39; - a message notifying that person has joined a conversation; &#39;PersonsAdded&#39; - a message notifying that a person(s) were added to a conversation.</param>
        /// <param name="text">For &#39;TextMessage&#39; post type only. Message text.</param>
        /// <param name="creatorId">Internal identifier of a user - author of a post.</param>
        /// <param name="addedPersonIds">For PersonsAdded post type only. Identifiers of persons added to a group.</param>
        /// <param name="removedPersonIds">For PersonsRemoved post type only. Identifiers of persons removed from a group.</param>
        /// <param name="mentions">List of mentions in post text with names..</param>
        /// <param name="creationTime">Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</param>
        /// <param name="lastModifiedTime">Post last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</param>
        public GlipPostEvent(string id = default(string), EventTypeEnum? eventType = default(EventTypeEnum?), string groupId = default(string), TypeEnum? type = default(TypeEnum?), string text = default(string), string creatorId = default(string), List<string> addedPersonIds = default(List<string>), List<string> removedPersonIds = default(List<string>), List<GlipMentionsInfo> mentions = default(List<GlipMentionsInfo>), DateTime creationTime = default(DateTime), DateTime lastModifiedTime = default(DateTime))
        {
            this.Id = id;
            this.EventType = eventType;
            this.GroupId = groupId;
            this.Type = type;
            this.Text = text;
            this.CreatorId = creatorId;
            this.AddedPersonIds = addedPersonIds;
            this.RemovedPersonIds = removedPersonIds;
            this.Mentions = mentions;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
        }

        /// <summary>
        /// Internal identifier of a post
        /// </summary>
        /// <value>Internal identifier of a post</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Internal identifier of a group a post belongs to
        /// </summary>
        /// <value>Internal identifier of a group a post belongs to</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }


        /// <summary>
        /// For &#39;TextMessage&#39; post type only. Message text
        /// </summary>
        /// <value>For &#39;TextMessage&#39; post type only. Message text</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Internal identifier of a user - author of a post
        /// </summary>
        /// <value>Internal identifier of a user - author of a post</value>
        [DataMember(Name="creatorId", EmitDefaultValue=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// For PersonsAdded post type only. Identifiers of persons added to a group
        /// </summary>
        /// <value>For PersonsAdded post type only. Identifiers of persons added to a group</value>
        [DataMember(Name="addedPersonIds", EmitDefaultValue=false)]
        public List<string> AddedPersonIds { get; set; }

        /// <summary>
        /// For PersonsRemoved post type only. Identifiers of persons removed from a group
        /// </summary>
        /// <value>For PersonsRemoved post type only. Identifiers of persons removed from a group</value>
        [DataMember(Name="removedPersonIds", EmitDefaultValue=false)]
        public List<string> RemovedPersonIds { get; set; }

        /// <summary>
        /// List of mentions in post text with names.
        /// </summary>
        /// <value>List of mentions in post text with names.</value>
        [DataMember(Name="mentions", EmitDefaultValue=false)]
        public List<GlipMentionsInfo> Mentions { get; set; }

        /// <summary>
        /// Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        /// <value>Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Post last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        /// <value>Post last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipPostEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  AddedPersonIds: ").Append(AddedPersonIds).Append("\n");
            sb.Append("  RemovedPersonIds: ").Append(RemovedPersonIds).Append("\n");
            sb.Append("  Mentions: ").Append(Mentions).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
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
            return this.Equals(input as GlipPostEvent);
        }

        /// <summary>
        /// Returns true if GlipPostEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipPostEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipPostEvent input)
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
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.AddedPersonIds == input.AddedPersonIds ||
                    this.AddedPersonIds != null &&
                    input.AddedPersonIds != null &&
                    this.AddedPersonIds.SequenceEqual(input.AddedPersonIds)
                ) && 
                (
                    this.RemovedPersonIds == input.RemovedPersonIds ||
                    this.RemovedPersonIds != null &&
                    input.RemovedPersonIds != null &&
                    this.RemovedPersonIds.SequenceEqual(input.RemovedPersonIds)
                ) && 
                (
                    this.Mentions == input.Mentions ||
                    this.Mentions != null &&
                    input.Mentions != null &&
                    this.Mentions.SequenceEqual(input.Mentions)
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.AddedPersonIds != null)
                    hashCode = hashCode * 59 + this.AddedPersonIds.GetHashCode();
                if (this.RemovedPersonIds != null)
                    hashCode = hashCode * 59 + this.RemovedPersonIds.GetHashCode();
                if (this.Mentions != null)
                    hashCode = hashCode * 59 + this.Mentions.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
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
