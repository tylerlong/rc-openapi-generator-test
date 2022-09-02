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
    /// GlipGroupsEvent
    /// </summary>
    [DataContract]
    public partial class GlipGroupsEvent :  IEquatable<GlipGroupsEvent>, IValidatableObject
    {
        /// <summary>
        /// Type of a group. &#39;PrivateChat&#39; is a group of 2 members. &#39;Group&#39; is a chat of 2 and more participants, the membership cannot be changed after group creation. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user
        /// </summary>
        /// <value>Type of a group. &#39;PrivateChat&#39; is a group of 2 members. &#39;Group&#39; is a chat of 2 and more participants, the membership cannot be changed after group creation. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PrivateChat for value: PrivateChat
            /// </summary>
            [EnumMember(Value = "PrivateChat")]
            PrivateChat = 1,

            /// <summary>
            /// Enum Group for value: Group
            /// </summary>
            [EnumMember(Value = "Group")]
            Group = 2,

            /// <summary>
            /// Enum Team for value: Team
            /// </summary>
            [EnumMember(Value = "Team")]
            Team = 3,

            /// <summary>
            /// Enum PersonalChat for value: PersonalChat
            /// </summary>
            [EnumMember(Value = "PersonalChat")]
            PersonalChat = 4

        }

        /// <summary>
        /// Type of a group. &#39;PrivateChat&#39; is a group of 2 members. &#39;Group&#39; is a chat of 2 and more participants, the membership cannot be changed after group creation. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user
        /// </summary>
        /// <value>Type of a group. &#39;PrivateChat&#39; is a group of 2 members. &#39;Group&#39; is a chat of 2 and more participants, the membership cannot be changed after group creation. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Type of a group event. Only the person who joined/was added to a group will receive &#39;GroupJoined&#39; notification. Only the person who left/was removed from a group will receive &#39;GroupLeft&#39; notification
        /// </summary>
        /// <value>Type of a group event. Only the person who joined/was added to a group will receive &#39;GroupJoined&#39; notification. Only the person who left/was removed from a group will receive &#39;GroupLeft&#39; notification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum GroupRenamed for value: GroupRenamed
            /// </summary>
            [EnumMember(Value = "GroupRenamed")]
            GroupRenamed = 1,

            /// <summary>
            /// Enum GroupJoined for value: GroupJoined
            /// </summary>
            [EnumMember(Value = "GroupJoined")]
            GroupJoined = 2,

            /// <summary>
            /// Enum GroupLeft for value: GroupLeft
            /// </summary>
            [EnumMember(Value = "GroupLeft")]
            GroupLeft = 3,

            /// <summary>
            /// Enum GroupChanged for value: GroupChanged
            /// </summary>
            [EnumMember(Value = "GroupChanged")]
            GroupChanged = 4

        }

        /// <summary>
        /// Type of a group event. Only the person who joined/was added to a group will receive &#39;GroupJoined&#39; notification. Only the person who left/was removed from a group will receive &#39;GroupLeft&#39; notification
        /// </summary>
        /// <value>Type of a group event. Only the person who joined/was added to a group will receive &#39;GroupJoined&#39; notification. Only the person who left/was removed from a group will receive &#39;GroupLeft&#39; notification</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipGroupsEvent" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a group.</param>
        /// <param name="type">Type of a group. &#39;PrivateChat&#39; is a group of 2 members. &#39;Group&#39; is a chat of 2 and more participants, the membership cannot be changed after group creation. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user.</param>
        /// <param name="isPublic">For &#39;Team&#39; group type only. Team access level.</param>
        /// <param name="name">For &#39;Team&#39; group type only. Team name.</param>
        /// <param name="description">For &#39;Team&#39; group type only. Team description.</param>
        /// <param name="members">“List of glip members”.</param>
        /// <param name="creationTime">Group creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</param>
        /// <param name="lastModifiedTime">Group last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</param>
        /// <param name="eventType">Type of a group event. Only the person who joined/was added to a group will receive &#39;GroupJoined&#39; notification. Only the person who left/was removed from a group will receive &#39;GroupLeft&#39; notification.</param>
        public GlipGroupsEvent(string id = default(string), TypeEnum? type = default(TypeEnum?), bool isPublic = default(bool), string name = default(string), string description = default(string), List<GlipMemberInfo> members = default(List<GlipMemberInfo>), DateTime creationTime = default(DateTime), DateTime lastModifiedTime = default(DateTime), EventTypeEnum? eventType = default(EventTypeEnum?))
        {
            this.Id = id;
            this.Type = type;
            this.IsPublic = isPublic;
            this.Name = name;
            this.Description = description;
            this.Members = members;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
            this.EventType = eventType;
        }

        /// <summary>
        /// Internal identifier of a group
        /// </summary>
        /// <value>Internal identifier of a group</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// For &#39;Team&#39; group type only. Team access level
        /// </summary>
        /// <value>For &#39;Team&#39; group type only. Team access level</value>
        [DataMember(Name="isPublic", EmitDefaultValue=false)]
        public bool IsPublic { get; set; }

        /// <summary>
        /// For &#39;Team&#39; group type only. Team name
        /// </summary>
        /// <value>For &#39;Team&#39; group type only. Team name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// For &#39;Team&#39; group type only. Team description
        /// </summary>
        /// <value>For &#39;Team&#39; group type only. Team description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// “List of glip members”
        /// </summary>
        /// <value>“List of glip members”</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<GlipMemberInfo> Members { get; set; }

        /// <summary>
        /// Group creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        /// <value>Group creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Group last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        /// <value>Group last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime LastModifiedTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipGroupsEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return this.Equals(input as GlipGroupsEvent);
        }

        /// <summary>
        /// Returns true if GlipGroupsEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipGroupsEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipGroupsEvent input)
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
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    (this.IsPublic != null &&
                    this.IsPublic.Equals(input.IsPublic))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
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
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
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
                if (this.IsPublic != null)
                    hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
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
