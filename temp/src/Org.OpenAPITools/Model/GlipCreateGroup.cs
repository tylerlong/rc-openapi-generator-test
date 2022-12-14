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
    /// GlipCreateGroup
    /// </summary>
    [DataContract]
    public partial class GlipCreateGroup :  IEquatable<GlipCreateGroup>, IValidatableObject
    {
        /// <summary>
        /// Type of a group to be created. &#39;PrivateChat&#39; is a group of 2 members. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user
        /// </summary>
        /// <value>Type of a group to be created. &#39;PrivateChat&#39; is a group of 2 members. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PrivateChat for value: PrivateChat
            /// </summary>
            [EnumMember(Value = "PrivateChat")]
            PrivateChat = 1,

            /// <summary>
            /// Enum Team for value: Team
            /// </summary>
            [EnumMember(Value = "Team")]
            Team = 2

        }

        /// <summary>
        /// Type of a group to be created. &#39;PrivateChat&#39; is a group of 2 members. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user
        /// </summary>
        /// <value>Type of a group to be created. &#39;PrivateChat&#39; is a group of 2 members. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipCreateGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlipCreateGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipCreateGroup" /> class.
        /// </summary>
        /// <param name="type">Type of a group to be created. &#39;PrivateChat&#39; is a group of 2 members. &#39;Team&#39; is a chat of 1 and more participants, the membership can be modified in future. &#39;PersonalChat&#39; is a private chat thread of a user (required).</param>
        /// <param name="isPublic">For &#39;Team&#39; group type only. Team access level.</param>
        /// <param name="name">For &#39;Team&#39; group type only. Team name.</param>
        /// <param name="description">For &#39;Team&#39; group type only. Team description.</param>
        /// <param name="members">???List of glip members. For &#39;PrivateChat&#39; group type 2 members only are supported???.</param>
        public GlipCreateGroup(TypeEnum type = default(TypeEnum), bool isPublic = default(bool), string name = default(string), string description = default(string), List<GlipMemberInfo> members = default(List<GlipMemberInfo>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GlipCreateGroup and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            this.IsPublic = isPublic;
            this.Name = name;
            this.Description = description;
            this.Members = members;
        }


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
        /// ???List of glip members. For &#39;PrivateChat&#39; group type 2 members only are supported???
        /// </summary>
        /// <value>???List of glip members. For &#39;PrivateChat&#39; group type 2 members only are supported???</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<GlipMemberInfo> Members { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipCreateGroup {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
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
            return this.Equals(input as GlipCreateGroup);
        }

        /// <summary>
        /// Returns true if GlipCreateGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipCreateGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipCreateGroup input)
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
                if (this.IsPublic != null)
                    hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
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
