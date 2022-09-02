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
    /// CreateUser
    /// </summary>
    [DataContract]
    public partial class CreateUser :  IEquatable<CreateUser>, IValidatableObject
    {
        /// <summary>
        /// Defines Schemas
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemasEnum
        {
            /// <summary>
            /// Enum Urnietfparamsscimschemascore20User for value: urn:ietf:params:scim:schemas:core:2.0:User
            /// </summary>
            [EnumMember(Value = "urn:ietf:params:scim:schemas:core:2.0:User")]
            Urnietfparamsscimschemascore20User = 1

        }


        /// <summary>
        /// Gets or Sets Schemas
        /// </summary>
        [DataMember(Name="schemas", EmitDefaultValue=true)]
        public List<SchemasEnum> Schemas { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUser" /> class.
        /// </summary>
        /// <param name="active">User status (default to false).</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="emails">emails (required).</param>
        /// <param name="externalId">external unique resource id defined by provisioning client.</param>
        /// <param name="name">name (required).</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="photos">photos.</param>
        /// <param name="schemas">schemas (required).</param>
        /// <param name="urnietfparamsscimschemasextensionenterprise20User">urnietfparamsscimschemasextensionenterprise20User.</param>
        /// <param name="userName">MUST be same as work type email address (required).</param>
        public CreateUser(bool active = false, List<UserAddress> addresses = default(List<UserAddress>), List<Email> emails = default(List<Email>), string externalId = default(string), Name name = default(Name), List<PhoneNumber> phoneNumbers = default(List<PhoneNumber>), List<Photo> photos = default(List<Photo>), List<SchemasEnum> schemas = default(List<SchemasEnum>), EnterpriseUser urnietfparamsscimschemasextensionenterprise20User = default(EnterpriseUser), string userName = default(string))
        {
            // to ensure "emails" is required (not null)
            if (emails == null)
            {
                throw new InvalidDataException("emails is a required property for CreateUser and cannot be null");
            }
            else
            {
                this.Emails = emails;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateUser and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "schemas" is required (not null)
            if (schemas == null)
            {
                throw new InvalidDataException("schemas is a required property for CreateUser and cannot be null");
            }
            else
            {
                this.Schemas = schemas;
            }

            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new InvalidDataException("userName is a required property for CreateUser and cannot be null");
            }
            else
            {
                this.UserName = userName;
            }

            // use default value if no "active" provided
            if (active == null)
            {
                this.Active = false;
            }
            else
            {
                this.Active = active;
            }
            this.Addresses = addresses;
            this.ExternalId = externalId;
            this.PhoneNumbers = phoneNumbers;
            this.Photos = photos;
            this.Urnietfparamsscimschemasextensionenterprise20User = urnietfparamsscimschemasextensionenterprise20User;
        }

        /// <summary>
        /// User status
        /// </summary>
        /// <value>User status</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<UserAddress> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=true)]
        public List<Email> Emails { get; set; }

        /// <summary>
        /// external unique resource id defined by provisioning client
        /// </summary>
        /// <value>external unique resource id defined by provisioning client</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Name Name { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Photos
        /// </summary>
        [DataMember(Name="photos", EmitDefaultValue=false)]
        public List<Photo> Photos { get; set; }


        /// <summary>
        /// Gets or Sets Urnietfparamsscimschemasextensionenterprise20User
        /// </summary>
        [DataMember(Name="urn:ietf:params:scim:schemas:extension:enterprise:2.0:User", EmitDefaultValue=false)]
        public EnterpriseUser Urnietfparamsscimschemasextensionenterprise20User { get; set; }

        /// <summary>
        /// MUST be same as work type email address
        /// </summary>
        /// <value>MUST be same as work type email address</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUser {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
            sb.Append("  Urnietfparamsscimschemasextensionenterprise20User: ").Append(Urnietfparamsscimschemasextensionenterprise20User).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as CreateUser);
        }

        /// <summary>
        /// Returns true if CreateUser instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.Photos == input.Photos ||
                    this.Photos != null &&
                    input.Photos != null &&
                    this.Photos.SequenceEqual(input.Photos)
                ) && 
                (
                    this.Schemas == input.Schemas ||
                    this.Schemas != null &&
                    input.Schemas != null &&
                    this.Schemas.SequenceEqual(input.Schemas)
                ) && 
                (
                    this.Urnietfparamsscimschemasextensionenterprise20User == input.Urnietfparamsscimschemasextensionenterprise20User ||
                    (this.Urnietfparamsscimschemasextensionenterprise20User != null &&
                    this.Urnietfparamsscimschemasextensionenterprise20User.Equals(input.Urnietfparamsscimschemasextensionenterprise20User))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.Photos != null)
                    hashCode = hashCode * 59 + this.Photos.GetHashCode();
                if (this.Schemas != null)
                    hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.Urnietfparamsscimschemasextensionenterprise20User != null)
                    hashCode = hashCode * 59 + this.Urnietfparamsscimschemasextensionenterprise20User.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
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
