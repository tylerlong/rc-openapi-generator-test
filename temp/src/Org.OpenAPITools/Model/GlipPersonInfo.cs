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
    /// GlipPersonInfo
    /// </summary>
    [DataContract]
    public partial class GlipPersonInfo :  IEquatable<GlipPersonInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipPersonInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlipPersonInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipPersonInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a user (required).</param>
        /// <param name="firstName">First name of a user.</param>
        /// <param name="lastName">Last name of a user.</param>
        /// <param name="email">Email of a user.</param>
        /// <param name="avatar">Photo of a user.</param>
        /// <param name="companyId">Internal identifier of a company.</param>
        /// <param name="creationTime">Time of creation in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</param>
        /// <param name="lastModifiedTime">Time of the last modification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</param>
        public GlipPersonInfo(string id = default(string), string firstName = default(string), string lastName = default(string), string email = default(string), string avatar = default(string), string companyId = default(string), DateTime creationTime = default(DateTime), DateTime lastModifiedTime = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GlipPersonInfo and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Avatar = avatar;
            this.CompanyId = companyId;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
        }

        /// <summary>
        /// Internal identifier of a user
        /// </summary>
        /// <value>Internal identifier of a user</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// First name of a user
        /// </summary>
        /// <value>First name of a user</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of a user
        /// </summary>
        /// <value>Last name of a user</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Email of a user
        /// </summary>
        /// <value>Email of a user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Photo of a user
        /// </summary>
        /// <value>Photo of a user</value>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Internal identifier of a company
        /// </summary>
        /// <value>Internal identifier of a company</value>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Time of creation in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        /// <value>Time of creation in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Time of the last modification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        /// <value>Time of the last modification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipPersonInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
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
            return this.Equals(input as GlipPersonInfo);
        }

        /// <summary>
        /// Returns true if GlipPersonInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipPersonInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipPersonInfo input)
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
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
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